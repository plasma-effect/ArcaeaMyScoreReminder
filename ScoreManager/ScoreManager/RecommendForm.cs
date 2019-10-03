using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ScoreManager.Utility;
using static System.Linq.Enumerable;

namespace ScoreManager
{
    public partial class RecommendForm : Form
    {
        public RecommendForm(List<ScoreData> list)
        {
            InitializeComponent();
            this.restrict.SelectedIndex = 0;
            this.list = list;
            this.restrictScore = new int[] { 980_0000, 995_0000, 1000_0000, 9999_9999 };
            this.Text = $"Recommend [Target Potential:{RoundDown(list[Math.Min(this.list.Count - 1, 29)].CalcPotential)}]";
            SetRecommend();
        }

        List<ScoreData> list;
        int[] restrictScore;

        private void ButtonClick(object sender, EventArgs e)
        {
            SetRecommend();
        }

        private void SetRecommend()
        {
            if (this.restrict.SelectedIndex < 0 || 4 <= this.restrict.SelectedIndex)
            {
                MessageBox.Show("制限の設定が異常です", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var targetPotential = this.list[Math.Min(this.list.Count - 1, 29)].CalcPotential;
            var restrict = this.restrictScore[this.restrict.SelectedIndex];
            var list = new List<(decimal Potential, int TargetCount, int Index)>();
            foreach (var i in Range(0, this.list.Count))
            {
                if (targetPotential <= this.list[i].CalcPotential)
                {
                    continue;
                }
                if (this.list[i].Potential + 2.0m < targetPotential)
                {
                    continue;
                }
                var min = PartitionPoint(0, this.list[i].Notes,
                    v => targetPotential <= GetPotential(this.list[i].Potential, GetScore(v, i)));
                var score = GetScore(min.Value, i);
                if (restrict <= score)
                {
                    continue;
                }
                list.Add((this.list[i].Potential, min.Value, i));
            }
            list.Sort();
            this.dataGridView1.Rows.Clear();
            foreach (var ((potential, pure, index), row) in list.Indexed())
            {
                this.dataGridView1.Rows.Add(
                    this.list[index].Name,
                    DifficultyToString(this.list[index].Difficulty),
                    this.list[index].Level,
                    potential,
                    GetScore(pure, index),
                    this.list[index].Notes - pure);
                SetDifficultyColor(this.dataGridView1, 1, row, this.list[index].Difficulty);
                SetPointColor(this.dataGridView1, 4, row, GetScore(pure, index));
            }
        }

        private int GetScore(int pure,int index)
        {
            return (int)(1000_0000L * pure / this.list[index].Notes);
        }
    }
}
