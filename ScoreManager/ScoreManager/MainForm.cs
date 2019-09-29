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
            foreach(var name in this.manager)
            {
                this.addDataSong.Items.Add(name);
            }
            PaintReset();
            PaintScoreData();
        }

        ScoreManager manager;
        IEnumerable<(string Name, int Difficulty, int Level, decimal Potential, int Score, int Rank)> paints;

        private void DataManagerClick(object sender, EventArgs e)
        {
            using (var form = new DataManagerForm(this, this.manager))
            {
                form.ShowDialog();
            }
            this.addDataSong.Items.Clear();
            foreach (var name in this.manager)
            {
                this.addDataSong.Items.Add(name);
            }
            PaintReset();
            PaintScoreData();
        }

        private void PaintScoreData()
        {
            this.dataGridView1.Rows.Clear();
            var index = 0;
            foreach (var data in this.paints)
            {
                var potential = GetPotential(data.Potential, data.Score);
                var step = GetStep(potential);
                this.dataGridView1.Rows.Add();
                this.dataGridView1[0, index].Value = data.Rank;
                this.dataGridView1[1, index].Value = data.Name;
                this.dataGridView1[2, index].Value = DifficultyToString(data.Difficulty);
                this.dataGridView1[3, index].Value = LevelToString(data.Level);
                this.dataGridView1[4, index].Value = data.Potential;
                this.dataGridView1[5, index].Value = data.Score;
                this.dataGridView1[6, index].Value = RoundDown(potential);
                this.dataGridView1[7, index].Value = RoundDown(step);
                this.dataGridView1[8, index].Value = RoundDown(step * 102m / 50m, 1);
                this.dataGridView1[9, index].Value = RoundDown(step * 90m / 50m, 1);
                this.dataGridView1[10, index].Value = RoundDown(step * 99m / 50m, 1);
                ++index;
            }
        }

        private void PaintReset()
        {
            var list = new List<(string Name, int Difficulty, int Level, decimal Potential, int Score, int Rank)>();
            foreach (var name in this.manager)
            {
                foreach (var i in Range(0, 3))
                {
                    list.Add((name, i, this.manager[name].Levels[i], this.manager[name].Potentials[i], this.manager[name].Bests[i], 0));
                }
            }
            list.Sort((a, b) =>
            {
                return
                GetPotential(this.manager[a.Name].Potentials[a.Difficulty], a.Score)
                .CompareTo(GetPotential(this.manager[b.Name].Potentials[b.Difficulty], b.Score));
            });
            list.Reverse();
            foreach(var i in Range(0, list.Count))
            {
                var p = list[i];
                list[i] = (p.Name, p.Difficulty, p.Level, p.Potential, p.Score, i + 1);
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

        private void AddScore(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(this.manager[this.addDataSong.Text] is null)
                {
                    MessageBox.Show("正しい曲名を選択してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var difficulty = StringToDifficulty(this.addDataDifficulty.Text);
                if(difficulty is null)
                {
                    MessageBox.Show("正しい難易度を選択してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(!int.TryParse(this.addDataScore.Text,out var score))
                {
                    MessageBox.Show("数値を入力してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var best = this.manager[this.addDataSong.Text].Bests[difficulty.Value];
                this.manager[this.addDataSong.Text].Bests[difficulty.Value] = Math.Max(best, score);
                PaintReset();
                PaintScoreData();
            }
        }

        private void EditScore(object sender, EventArgs e)
        {
            using (var form = new EditScoreForm(this, this.manager))
            {
                form.ShowDialog();
                PaintReset();
                PaintScoreData();
            }
        }

        public void PointDataSet(DataGridView view)
        {
            foreach (var i in Range(0, view.Rows.Count - 1))
            {
                var name = view[0, i].Value.ToString();
                foreach (var j in Range(0, 3))
                {
                    if (int.TryParse(view[1 + j, i].Value.ToString(), out var score))
                    {
                        this.manager[name].Bests[j] = score;
                    }
                    else if (view[1 + j, i].Value.ToString() == "")
                    {
                        this.manager[name].Bests[j] = 0;
                    }
                }
            }
        }

        private void FilterClick(object sender, EventArgs e)
        {
            using(var form = new FilterForm(this))
            {
                form.ShowDialog();
            }
            PaintScoreData();
        }

        public void SetFilter(Filter filter)
        {
            bool Check((string Name, int Difficulty, int Level, decimal Potential, int Score, int Rank) data)
            {
                if (!filter.LevelFilters[data.Level])
                {
                    return false;
                }
                if (!filter.DifficultyFilters[data.Difficulty])
                {
                    return false;
                }
                if(filter.PotentialFilter is decimal potential)
                {
                    switch (filter.PotentialFlag)
                    {
                        case Filter.Comparison.more:
                            if (!(potential < data.Potential))
                            {
                                return false;
                            }
                            break;
                        case Filter.Comparison.moreEqual:
                            if (!(potential <= data.Potential))
                            {
                                return false;
                            }
                            break;
                        case Filter.Comparison.equal:
                            if (!(potential == data.Potential))
                            {
                                return false;
                            }
                            break;
                        case Filter.Comparison.lessEqual:
                            if (!(data.Potential <= potential))
                            {
                                return false;
                            }
                            break;
                        case Filter.Comparison.less:
                            if (!(data.Potential < potential))
                            {
                                return false;
                            }
                            break;
                    }
                }
                if(filter.ScoreFilter is int score)
                {
                    switch (filter.ScoreFlag)
                    {
                        case Filter.Comparison.more:
                            if (!(score < data.Score))
                            {
                                return false;
                            }
                            break;
                        case Filter.Comparison.moreEqual:
                            if (!(score <= data.Score))
                            {
                                return false;
                            }
                            break;
                        case Filter.Comparison.equal:
                            if (!(score == data.Score))
                            {
                                return false;
                            }
                            break;
                        case Filter.Comparison.lessEqual:
                            if (!(data.Score <= score))
                            {
                                return false;
                            }
                            break;
                        case Filter.Comparison.less:
                            if (!(data.Score < score))
                            {
                                return false;
                            }
                            break;
                    }
                }
                return true;
            }
            PaintReset();
            this.paints = this.paints.Where(Check);
        }

        private void TargetClick(object sender, EventArgs e)
        {
            using (var form = new TargetForm(this.manager))
            {
                form.ShowDialog();
            }
        }

        private void StatisticsClick(object sender, EventArgs e)
        {
            using(var form = new StatisticsForm(this.manager))
            {
                form.ShowDialog();
            }
        }
    }
}