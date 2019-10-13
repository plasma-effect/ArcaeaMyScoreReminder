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

namespace ScoreManager
{
    public partial class RollBackForm : Form
    {
        public RollBackForm(List<ScoreChangeLog> scoreLog,MainForm parent)
        {
            InitializeComponent();
            foreach (var i in Range(1, scoreLog.Count))
            {
                this.logComboBox.Items.Add(scoreLog[scoreLog.Count - i].ToString());
            }
            this.parent = parent;
        }
        MainForm parent;

        private void CompleteClick(object sender, EventArgs e)
        {
            if (this.logComboBox.SelectedIndex != -1)
            {
                if (MessageBox.Show("ロールバック操作は不可逆です、実行しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.parent.Rollback(this.logComboBox.SelectedIndex + 1);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
