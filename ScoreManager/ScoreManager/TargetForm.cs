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
            var index = 0;
            foreach (var name in manager)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1[0, index].Value = name;
                foreach (var i in Range(0, 3))
                {
                    this.dataGridView1[1 + i, index].Value = 0;
                }
                ++index;
            }
            this.actions = new Func<decimal, decimal, Func<int, bool>>[5];
            this.actions[0] = TargetPotential;
            this.actions[1] = TargetBaseStep;
            this.actions[2] = TargetGrievousLady;
            this.actions[3] = TargetAxium;
            this.actions[4] = TargetFracture;
        }
        ScoreManager manager;
        Func<decimal, decimal, Func<int, bool>>[] actions;

        private void Accept(object sender, EventArgs e)
        {
            var action = this.actions[this.targetType.SelectedIndex];
            if (decimal.TryParse(this.targetValue.Text, out var target))
            {
                this.dataGridView1.Rows.Clear();
                foreach (var (name, index) in this.manager.Indexed())
                {
                    if (this.manager[name] is ScoreManager.Unit unit)
                    {
                        var past = PartitionPoint(0, 1000_0000 + unit.Notes[0], action(target, unit.Potentials[0]));
                        var present = PartitionPoint(0, 1000_0000 + unit.Notes[1], action(target, unit.Potentials[1]));
                        var future = PartitionPoint(0, 1000_0000 + unit.Notes[2], action(target, unit.Potentials[2]));
                        if (past.HasValue || present.HasValue || future.HasValue)
                        {
                            this.dataGridView1.Rows.Add();
                            this.dataGridView1[0, index].Value = name;
                            SetValue(1, index, past);
                            SetValue(2, index, present);
                            SetValue(3, index, future);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("正しい値を入力してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Func<int, bool> TargetPotential(decimal target, decimal scorePotential)
        {
            return v => target <= GetPotential(scorePotential, v);
        }

        private Func<int, bool> TargetBaseStep(decimal target, decimal scorePotential)
        {
            return v => target <= GetStep(scorePotential, v);
        }

        private Func<int, bool> TargetGrievousLady(decimal target, decimal scorePotential)
        {
            return v => target <= GetStep(scorePotential, v) * 102m / 50m;
        }

        private Func<int, bool> TargetAxium(decimal target, decimal scorePotential)
        {
            return v => target <= GetStep(scorePotential, v) * 90m / 50m;
        }

        private Func<int, bool> TargetFracture(decimal target, decimal scorePotential)
        {
            return v => target <= GetStep(scorePotential, v) * 99m / 50m;
        }

        private void SetValue(int column, int row, int? score)
        {
            if (score is int point)
            {
                if (point < 900_0000)
                {
                    this.dataGridView1[column, row].Style.BackColor = Color.GreenYellow;
                }
                else if (point < 950_0000)
                {
                    this.dataGridView1[column, row].Style.BackColor = Color.Aqua;
                }
                else if (point < 980_0000)
                {
                    this.dataGridView1[column, row].Style.BackColor = Color.Blue;
                    this.dataGridView1[column, row].Style.ForeColor = Color.White;
                }
                else if (point < 995_0000)
                {
                    this.dataGridView1[column, row].Style.BackColor = Color.Yellow;
                }
                else
                {
                    this.dataGridView1[column, row].Style.BackColor = Color.OrangeRed;
                }
                this.dataGridView1[column, row].Value = point;
            }
            else
            {
                this.dataGridView1[column, row].Style.BackColor = Color.Red;
                this.dataGridView1[column, row].Style.ForeColor = Color.White;
                this.dataGridView1[column, row].Value = "不可能";
            }
        }
    }
}
