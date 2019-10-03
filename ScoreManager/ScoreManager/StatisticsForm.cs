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
                var pastPotential = GetPotential(unit.Potentials[0], unit.Bests[0]);
                var presentPotential = GetPotential(unit.Potentials[1], unit.Bests[1]);
                var futurePotential = GetPotential(unit.Potentials[2], unit.Bests[2]);
                var maxindex = MaxElemental(pastPotential, presentPotential, futurePotential);
                this.dataGridView1.Rows.Add(name,
                    unit.Bests[0], pastPotential, 2 * unit.Notes[0] - FarCount(unit.Bests[0], unit.Notes[0]),
                    unit.Bests[1], presentPotential, 2 * unit.Notes[1] - FarCount(unit.Bests[1], unit.Notes[1]),
                    unit.Bests[2], futurePotential, 2 * unit.Notes[2] - FarCount(unit.Bests[2], unit.Notes[2]));
                this.dataGridView1[2 + 3 * maxindex, index].Style.BackColor = Color.Yellow;
                SetPointColor(this.dataGridView1, 1, index, unit.Bests[0]);
                SetPointColor(this.dataGridView1, 4, index, unit.Bests[1]);
                SetPointColor(this.dataGridView1, 7, index, unit.Bests[2]);
            }
        }
    }
}
