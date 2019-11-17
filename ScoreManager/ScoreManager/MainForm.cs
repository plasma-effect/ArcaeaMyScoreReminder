using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.IO;
using static ScoreManager.Utility;
using static System.Linq.Enumerable;

namespace ScoreManager
{
    public partial class MainForm : Form
    {
        const string masterSaveAddress = "arcaeadata.dat";
        const string logSaveAddress = "arcaealog.dat";

        public MainForm()
        {
            InitializeComponent();
            this.filter = new Filter();
            LoadLogData();
            LoadMasterData();
            PaintReset();
            PaintScoreData();
        }

        private void LoadLogData()
        {
            if (File.Exists(logSaveAddress))
            {
                using (var stream = new FileStream(logSaveAddress, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    this.scoreLog = formatter.Deserialize(stream) as List<ScoreChangeLog>;
                }
            }
            if (this.scoreLog is null)
            {
                this.scoreLog = new List<ScoreChangeLog>();
            }
        }

        private void LoadMasterData()
        {
            if (File.Exists(masterSaveAddress))
            {
                using (var stream = new FileStream(masterSaveAddress, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    this.manager = formatter.Deserialize(stream) as ScoreManager;
                }
                if (this.manager is ScoreManager manager &&
                    this.scoreLog.Count != 0 &&
                    File.GetLastWriteTime(masterSaveAddress) < this.scoreLog.Last().TimeStamp)
                {
                    var last = File.GetLastWriteTime(masterSaveAddress);
                    foreach(var data in this.scoreLog)
                    {
                        if (last < data.TimeStamp)
                        {
                            manager[data.SongName].Bests[data.Difficulty] = data.Current;
                        }
                    }
                    SaveMasterData();
                }
            }
            if (this.manager is null)
            {
                this.manager = new ScoreManager();
            }
            foreach (var name in this.manager)
            {
                this.addDataSong.Items.Add(name);
            }
        }

        Filter filter;
        ScoreManager manager;
        IEnumerable<ScoreData> paints;
        List<ScoreData> list;
        List<ScoreChangeLog> scoreLog;

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
            foreach (var data in this.paints)
            {
                var potential = GetPotential(data.Potential, data.Score);
                var step = GetStep(potential);
                this.dataGridView1.Rows.Add(
                    data.Rank,
                    data.Name,
                    DifficultyToString(data.Difficulty),
                    LevelToString(data.Level),
                    data.Potential,
                    data.Score,
                    RoundDown(potential),
                    RoundDown(step),
                    RoundDown(step * 102m / 50m, 1),
                    RoundDown(step * 90m / 50m, 1),
                    RoundDown(step * 99m / 50m, 1));
            }
            foreach (var (data, row) in this.paints.Indexed())
            {
                SetDifficultyColor(this.dataGridView1, 2, row, data.Difficulty);
                SetPointColor(this.dataGridView1, 5, row, data.Score);
            }
        }

        private void PaintReset()
        {
            this.list = new List<ScoreData>();
            foreach (var name in this.manager)
            {
                var unit = this.manager[name];
                foreach (var i in Range(0, 3))
                {
                    this.list.Add(new ScoreData(name, i, unit.Levels[i], unit.Potentials[i], unit.Bests[i], unit.Notes[i]));
                }
            }
            this.list.Sort();
            this.list.Reverse();
            foreach (var i in Range(0, this.list.Count))
            {
                this.list[i] = new ScoreData(this.list[i], i + 1);
            }
            this.paints = this.list;
            SetFilter(this.filter);
            ParsonalPotentialCalc(this.list);
        }

        private void ParsonalPotentialCalc(List<ScoreData> list)
        {
            var sum = 0.0m;
            const int best = 30;
            foreach (var i in Range(0, Math.Min(best, list.Count)))
            {
                sum += GetPotential(list[i].Potential, list[i].Score);
            }
            var min = RoundDown(sum / (best + 10), 2);
            var max = this.list.Count == 0 ? min : RoundDown((sum + 10 * GetPotential(list[0].Potential, list[0].Score)) / (best + 10), 2);
            this.Text = $"Arcaea Score Manager [Min Potential: {min}, Max Potential: {max}]";
        }

        private void SaveMasterData()
        {
            using (var stream = new FileStream(masterSaveAddress, FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, this.manager);
            }
        }

        public void ScoreDataSet(DataGridView view)
        {
            var must = new SortedSet<string>(this.manager);
            foreach (var name in Range(0, view.Rows.Count - 1).Select(i => view[0, i].Value.ToString()))
            {
                if (must.Contains(name))
                {
                    must.Remove(name);
                }
            }
            if (must.Count != 0)
            {
                var builder = new StringBuilder();
                builder.AppendLine("楽曲の削除には対応していません");
                foreach (var name in must)
                {
                    builder.AppendLine(name);
                }
                throw new ArgumentException(builder.ToString());
            }
            foreach (var index in Range(0, view.Rows.Count - 1))
            {
                SingleScoreDataSet(view, index);
            }
            SaveMasterData();
            ResetScoreLog();
        }

        private void ResetScoreLog()
        {
            this.scoreLog.Clear();
            SaveLogData();
        }

        private void SingleScoreDataSet(DataGridView view, int index)
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

        private void AddScore(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(this.manager[this.addDataSong.Text] is null)
                {
                    MessageBox.Show("正しい曲名を選択してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var name = this.addDataSong.Text;
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
                if (best < score)
                {
                    CommitLog(name, difficulty.Value, best, score);
                    ChangeSingleScore(name, difficulty.Value, score);
                }
                this.addDataSong.Text = "";
                this.addDataDifficulty.SelectedIndex = -1;
                this.addDataScore.Text = "";
            }
        }

        private void ChangeSingleScore(string name, int difficulty, int score)
        {
            var prev = this.list.Find(d => d.Name == name && d.Difficulty == difficulty);
            this.manager[name].Bests[difficulty] = score;
            PaintReset();
            PaintScoreData();
            var now = this.list.Find(d => d.Name == name && d.Difficulty == difficulty);
            if (prev.Score < now.Score)
            {
                StatusTextSet($@"""{this.addDataSong.Text}({this.addDataDifficulty.Text})""の自己ベストを更新しました：[Score: {prev.Score}, Potential: {RoundDown(prev.CalcPotential)}, Rank: {prev.Rank}]→[Score: {now.Score}, Potential: {RoundDown(now.CalcPotential)}, Rank: {now.Rank}]");
            }
        }

        private void CommitLog(string name, int difficulty, int prev, int score)
        {
            this.scoreLog.Add(new ScoreChangeLog(name, difficulty, prev, score, DateTime.Now));
            SaveLogData();
        }

        public void Rollback(int count)
        {
            var index = this.scoreLog.Count;
            foreach (var i in Range(0, count))
            {
                --index;
                ChangeSingleScore(
                    this.scoreLog[index].SongName,
                    this.scoreLog[index].Difficulty,
                    this.scoreLog[index].Previous);
            }
            this.scoreLog.RemoveRange(this.scoreLog.Count - count, count);
            SaveLogData();
        }

        private void SaveLogData()
        {
            using (var stream = new FileStream(logSaveAddress, FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, this.scoreLog);
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
                }
            }
            StatusTextSet("スコア記録を変更しました");
            SaveMasterData();
            ResetScoreLog();
        }

        private void FilterClick(object sender, EventArgs e)
        {
            using (var form = new FilterForm(this, this.filter))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    StatusTextSet("フィルター設定を変更しました");
                    PaintScoreData();
                }
            }
        }

        public void SetFilter(Filter filter)
        {
            this.filter = filter;
            bool Check(ScoreData data)
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
            this.paints = this.list.Where(Check);
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

        public void StatusTextSet(string str)
        {
            this.statusText.Text = str;
        }

        private void ShowRecommend(object sender, EventArgs e)
        {
            using (var form = new RecommendForm(this.list))
            {
                form.ShowDialog();
            }
        }

        private void ExportScoreData(object sender, EventArgs e)
        {
            using(var sfd = new SaveFileDialog()
            {
                Filter = "JSONファイル(*.json)|*.json|すべてのファイル(*.*)|*.+"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var list = new List<SongData>();
                    foreach (var name in this.manager)
                    {
                        var unit = this.manager[name];
                        list.Add(new SongData(name, unit.Levels, unit.Potentials, unit.Notes));
                    }
                    var serializer = new DataContractJsonSerializer(typeof(List<SongData>));
                    using(var stream = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                    {
                        serializer.WriteObject(stream, list);
                    }
                }
            }
        }

        private void ImportScoreData(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog()
            {
                Filter = "JSONファイル(*.json)|*.json|すべてのファイル(*.*)|*.+"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var deserializer = new DataContractJsonSerializer(typeof(List<SongData>));
                        using (var stream = new FileStream(ofd.FileName, FileMode.Open))
                        {
                            if(deserializer.ReadObject(stream) is List<SongData> list)
                            {
                                foreach(var data in list)
                                {
                                    if (!this.manager.ContainsKey(data.Name))
                                    {
                                        this.manager.Add(data.Name,
                                            data.Levels[0], data.Potentials[0], data.Notes[0],
                                            data.Levels[1], data.Potentials[1], data.Notes[1],
                                            data.Levels[2], data.Potentials[2], data.Notes[2]);
                                    }
                                }
                                PaintReset();
                                PaintScoreData();
                                SaveMasterData();
                            }
                            else
                            {
                                throw new InvalidDataException("適切なJSONファイルではありません");
                            }
                        }
                    }
                    catch(Exception exp)
                    {
                        MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            SaveMasterData();
        }

        private void RollBackClick(object sender, EventArgs e)
        {
            using(var form = new RollBackForm(this.scoreLog, this))
            {
                form.ShowDialog();
            }
        }

        private void CheckClearLineClick(object sender, EventArgs e)
        {
            using(var form = new ClearLineForm(this.manager))
            {
                form.ShowDialog();
            }
        }
    }

    [DataContract]
    struct SongData
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int[] Levels { get; set; }
        [DataMember]
        public decimal[] Potentials { get; set; }
        [DataMember]
        public int[] Notes { get; set; }

        public SongData(string name, int[] levels, decimal[] potentials, int[] notes)
        {
            this.Name = name;
            this.Levels = levels;
            this.Potentials = potentials;
            this.Notes = notes;
        }
    }
}