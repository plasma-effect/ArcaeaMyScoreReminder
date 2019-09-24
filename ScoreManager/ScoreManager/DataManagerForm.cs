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
    public partial class DataManagerForm : Form
    {
        public MainForm MyMainForm { get; }
        public DataManagerForm(MainForm main, ScoreManager manager)
        {
            InitializeComponent();
            this.MyMainForm = main;
            var index = 0;
            foreach (var name in manager)
            {
                this.songDataGrid[0, index].Value = name;
                foreach (var i in Range(0, 3))
                {
                    this.songDataGrid[3 * i + 1, index].Value = LevelToString(manager[name].Levels[i]);
                    this.songDataGrid[3 * i + 2, index].Value = manager[name].Potentials[i];
                    this.songDataGrid[3 * i + 3, index].Value = manager[name].Notes[i];
                }
                ++index;
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.MyMainForm.ScoreDataSet(this.songDataGrid);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
