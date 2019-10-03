using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Linq.Enumerable;
using static ScoreManager.Utility;

namespace ScoreManager
{
    public partial class TargetForm : Form
    {
        public TargetForm(ScoreManager manager)
        {
            InitializeComponent();
            this.targetType.SelectedIndex = 0;
            this.manager = manager;
            this.actions = new Func<decimal, decimal, int, Func<int, bool>>[5];
            this.actions[0] = TargetPotential;
            this.actions[1] = TargetBaseStep;
            this.actions[2] = TargetGrievousLady;
            this.actions[3] = TargetAxium;
            this.actions[4] = TargetFracture;
        }
        ScoreManager manager;
        Func<decimal, decimal, int, Func<int, bool>>[] actions;

        private void Accept(object sender, EventArgs e)
        {
            var action = this.actions[this.targetType.SelectedIndex];
            this.dataGridView1.Rows.Clear();
            if (decimal.TryParse(this.targetValue.Text, out var target))
            {
                foreach (var (name, index) in this.manager.Indexed())
                {
                    if (this.manager[name] is ScoreManager.Unit unit)
                    {
                        var past = PartitionPoint(0, unit.Notes[0], action(target, unit.Potentials[0], unit.Notes[0]));
                        var present = PartitionPoint(0, unit.Notes[1], action(target, unit.Potentials[1], unit.Notes[1]));
                        var future = PartitionPoint(0, unit.Notes[2], action(target, unit.Potentials[2], unit.Notes[2]));
                        this.dataGridView1.Rows.Add(name,
                            GetScore(past, unit.Notes[0])?.ToString() ?? "不可能", (unit.Notes[0] - past)?.ToString() ?? "",
                            GetScore(present, unit.Notes[1])?.ToString() ?? "不可能", (unit.Notes[1] - present)?.ToString() ?? "",
                            GetScore(future, unit.Notes[2])?.ToString() ?? "不可能", (unit.Notes[2] - future)?.ToString() ?? "");
                        SetColor(1, index, GetScore(past, unit.Notes[0]));
                        SetColor(3, index, GetScore(present, unit.Notes[1]));
                        SetColor(5, index, GetScore(future, unit.Notes[2]));
                    }
                }
            }
            else
            {
                MessageBox.Show("正しい値を入力してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? GetScore(int? pure, int notes)
        {
            return (int?)(1000_0000L * pure / notes);
        }

        private Func<int, bool> TargetPotential(decimal target, decimal scorePotential, int notes)
        {
            return v => target <= GetPotential(scorePotential, (int)(1000_0000L * v / notes));
        }

        private Func<int, bool> TargetBaseStep(decimal target, decimal scorePotential, int notes)
        {
            return v => target <= GetStep(scorePotential, (int)(1000_0000L * v / notes));
        }

        private Func<int, bool> TargetGrievousLady(decimal target, decimal scorePotential, int notes)
        {
            return v => target <= GetStep(scorePotential, (int)(1000_0000L * v / notes)) * 102m / 50m;
        }

        private Func<int, bool> TargetAxium(decimal target, decimal scorePotential, int notes)
        {
            return v => target <= GetStep(scorePotential, (int)(1000_0000L * v / notes)) * 90m / 50m;
        }

        private Func<int, bool> TargetFracture(decimal target, decimal scorePotential, int notes)
        {
            return v => target <= GetStep(scorePotential, (int)(1000_0000L * v / notes)) * 99m / 50m;
        }

        private void SetColor(int column, int row, int? score)
        {
            if (score is int point)
            {
                SetPointColor(this.dataGridView1, column, row, point);
            }
            else
            {
                this.dataGridView1[column, row].Style.BackColor = Color.Black;
                this.dataGridView1[column, row].Style.ForeColor = Color.White;
            }
        }
    }
}
