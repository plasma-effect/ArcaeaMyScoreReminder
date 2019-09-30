using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManager
{
    public partial class EditScoreForm : Form
    {
        public EditScoreForm(MainForm parent, ScoreManager manager)
        {
            InitializeComponent();
            this.MyParent = parent;
            this.dataGridView1.Rows.Add(manager.Count);
            foreach (var (name, index) in manager.Indexed())
            {
                this.dataGridView1[0, index].Value = name;
                foreach (var i in Enumerable.Range(0, 3))
                {
                    this.dataGridView1[1 + i, index].Value = manager[name].Bests[i];
                }
            }
        }
        MainForm MyParent;

        private void ButtonClick(object sender, EventArgs e)
        {
            this.MyParent.PointDataSet(this.dataGridView1);
            this.DialogResult = DialogResult.OK;
        }
    }
}
