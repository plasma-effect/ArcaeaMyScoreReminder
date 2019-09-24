using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using static ScoreManager.Utility;
using static System.Linq.Enumerable;

namespace ScoreManager
{
    public partial class MainForm : Form
    {
        const string saveAddress = "arcaeadata.dat";
        
        public MainForm()
        {
            InitializeComponent();
            if (File.Exists(saveAddress))
            {
                using (var stream = new FileStream(saveAddress, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    this.manager = formatter.Deserialize(stream) as ScoreManager;
                }
            }
            if(this.manager is null)
            {
                this.manager = new ScoreManager();
            }
        }

        ScoreManager manager;
        IEnumerable<(string Name, int Difficulty, int Score, int Rank)> paints;

        private void DataManagerClick(object sender, EventArgs e)
        {
            using (var form = new DataManagerForm(this, this.manager))
            {
                form.ShowDialog();
            }
            PaintReset();
        }

        private void PaintReset()
        {
            var list = new List<(string Name, int Difficulty, int Score, int Rank)>();
            foreach (var name in this.manager)
            {
                foreach(var i in Range(0, 3))
                {
                    list.Add((name, i, this.manager[name].Bests[i], 0));
                }
            }
            list.Sort((a, b) =>
            {
                return
                GetPotential(this.manager[a.Name].Potentials[a.Difficulty], a.Score)
                .CompareTo(GetPotential(this.manager[b.Name].Potentials[b.Difficulty], b.Score));
            });
            foreach(var i in Range(0, list.Count))
            {
                var p = list[i];
                list[i] = (p.Name, p.Difficulty, p.Score, i + 1);
            }
            this.paints = list;
        }

        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            using(var stream = new FileStream(saveAddress, FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, this.manager);
            }
        }

        public void ScoreDataSet(DataGridView view)
        {
            var must = new SortedSet<string>(this.manager);
            foreach (var name in Range(0, view.Rows.Count - 1).Select(i => view[0, i].ToString()))
            {
                if (must.Contains(name))
                {
                    must.Remove(name);
                }
            }
            if (must.Count != 0)
            {
                throw new ArgumentException("楽曲の削除には対応していません");
            }
            foreach (var index in Range(0, view.Rows.Count - 1))
            {
                var name = view[0, index].Value.ToString();
                if (name == "")
                {
                    throw new ArgumentException($"{index + 1} 行目: 曲名を入力してください");
                }
                if (this.manager[name] is ScoreManager.Unit unit)
                {
                    foreach (var i in Range(0, 3))
                    {
                        if (StringToLevel(view[3 * i + 1, index].Value.ToString()) is int level &&
                            decimal.TryParse(view[3 * i + 2, index].Value.ToString(), out var potential) &&
                            int.TryParse(view[3 * i + 3, index].Value.ToString(), out var notes))
                        {
                            this.manager[name].Notes[i] = notes;
                            this.manager[name].Potentials[i] = potential;
                            this.manager[name].Notes[i] = notes;
                        }
                        else
                        {
                            throw new ArgumentException($"{index + 1} 行目({name}): 正しい形式ではありません");
                        }
                    }
                }
                else
                {
                    if (StringToLevel(view[1, index].Value.ToString()) is int pstLevel &&
                        StringToLevel(view[4, index].Value.ToString()) is int prsLevel &&
                        StringToLevel(view[7, index].Value.ToString()) is int ftrLevel &&
                        decimal.TryParse(view[2, index].Value.ToString(), out var pstPotential) &&
                        decimal.TryParse(view[5, index].Value.ToString(), out var prsPotential) &&
                        decimal.TryParse(view[8, index].Value.ToString(), out var ftrPotential) &&
                        int.TryParse(view[3, index].Value.ToString(), out var pstNotes) &&
                        int.TryParse(view[6, index].Value.ToString(), out var prsNotes) &&
                        int.TryParse(view[9, index].Value.ToString(), out var ftrNotes))
                    {
                        this.manager.Add(name,
                            pstLevel, pstPotential, pstNotes,
                            prsLevel, prsPotential, prsNotes,
                            ftrLevel, ftrPotential, ftrNotes);
                    }
                    else
                    {
                        throw new ArgumentException($"{index + 1} 行目({name}): 正しい形式ではありません");
                    }
                }
            }
        }
    }
}
