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
            foreach (var (name, index) in manager.Indexed())
            {
                this.dataGridView1.Rows.Add(name, 0, 0, 0);
            }
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
            if (decimal.TryParse(this.targetValue.Text, out var target))
            {
                foreach (var (name, index) in this.manager.Indexed())
                {
                    if (this.manager[name] is ScoreManager.Unit unit)
                    {
                        var past = (int?)(1000_0000L * PartitionPoint(0, unit.Notes[0], action(target, unit.Potentials[0], unit.Notes[0])) / unit.Notes[0]);
                        var present = (int?)(1000_0000L * PartitionPoint(0, unit.Notes[1], action(target, unit.Potentials[1], unit.Notes[1])) / unit.Notes[1]);
                        var future = (int?)(1000_0000L * PartitionPoint(0, unit.Notes[2], action(target, unit.Potentials[2], unit.Notes[2])) / unit.Notes[2]);
                        this.dataGridView1[0, index].Value = name;
                        SetValue(1, index, past);
                        SetValue(2, index, present);
                        SetValue(3, index, future);
                    }
                }
            }
            else
            {
                MessageBox.Show("正しい値を入力してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void SetValue(int column, int row, int? score)
        {
            if (score is int point)
            {
                SetPointColor(this.dataGridView1, column, row, point);
                this.dataGridView1[column, row].Value = point;
            }
            else
            {
                this.dataGridView1[column, row].Style.BackColor = Color.Black;
                this.dataGridView1[column, row].Style.ForeColor = Color.White;
                this.dataGridView1[column, row].Value = "不可能";
            }
        }
    }
}
