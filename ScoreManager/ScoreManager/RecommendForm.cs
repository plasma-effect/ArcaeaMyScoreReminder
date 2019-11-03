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
            this.scoreRestrict.SelectedIndex = 0;
            this.rankRestrict.SelectedIndex = 29;
            this.list = list;
            this.restrictScore = new int[] { 980_0000, 995_0000, 1000_0000, 9999_9999 };
            
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
            if (this.scoreRestrict.SelectedIndex < 0 || 4 <= this.scoreRestrict.SelectedIndex)
            {
                MessageBox.Show("制限の設定が異常です", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var targetPotential = this.list[Math.Min(this.list.Count - 1, this.rankRestrict.SelectedIndex)].CalcPotential;
            var restrict = this.restrictScore[this.scoreRestrict.SelectedIndex];
            var list = new List<(decimal Potential, int TargetCount, int Index)>();
            RecommendCheck(targetPotential, restrict, list);
            list.Sort();
            ViewRecommendData(list);
            this.Text = $"Recommend [Target Potential:{RoundDown(targetPotential)}]";
        }

        private void ViewRecommendData(List<(decimal Potential, int TargetCount, int Index)> list)
        {
            this.dataGridView1.Rows.Clear();
            foreach (var ((potential, far, index), row) in list.Indexed())
            {
                this.dataGridView1.Rows.Add(
                    this.list[index].Name,
                    DifficultyToString(this.list[index].Difficulty),
                    LevelToString(this.list[index].Level),
                    potential,
                    this.list[index].Score,
                    GetScore(far, index),
                    2 * this.list[index].Notes - FarCount(this.list[index].Score, this.list[index].Notes),
                    2 * this.list[index].Notes - far);
                SetDifficultyColor(this.dataGridView1, 1, row, this.list[index].Difficulty);
                SetPointColor(this.dataGridView1, 4, row, this.list[index].Score);
                SetPointColor(this.dataGridView1, 5, row, GetScore(far, index));
            }
        }

        private void RecommendCheck(decimal targetPotential, int restrict, List<(decimal Potential, int TargetCount, int Index)> list)
        {
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
                var min = PartitionPoint(0, 2 * this.list[i].Notes,
                    v => targetPotential <= GetPotential(this.list[i].Potential, GetScore(v, i)));
                var score = GetScore(min.Value, i);
                if (restrict <= score)
                {
                    continue;
                }
                list.Add((this.list[i].Potential, min.Value, i));
            }
        }

        private int GetScore(int far,int index)
        {
            return (int)(1000_0000L * far / (2 * this.list[index].Notes));
        }
    }
}
