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

namespace ScoreManager
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm(ScoreManager manager)
        {
            InitializeComponent();
            foreach (var (name, index) in manager.Indexed())
            {
                var unit = manager[name];
                this.dataGridView1.Rows.Add();
                var past = GetPotential(unit.Potentials[0], unit.Bests[0]);
                var present = GetPotential(unit.Potentials[1], unit.Bests[1]);
                var future = GetPotential(unit.Potentials[2], unit.Bests[2]);
                var maxindex = MaxElemental(past, present, future);
                this.dataGridView1[1 + maxindex, index].Style.BackColor = Color.Yellow;
                this.dataGridView1[0, index].Value = name;
                this.dataGridView1[1, index].Value = past;
                this.dataGridView1[2, index].Value = present;
                this.dataGridView1[3, index].Value = future;
            }
        }
    }
}
