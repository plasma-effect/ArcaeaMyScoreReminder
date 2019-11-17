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
    public partial class ClearLineForm : Form
    {
        public ClearLineForm(ScoreManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            foreach(var name in manager)
            {
                this.SongName.Items.Add(name);
            }
        }
        ScoreManager manager;

        private void AddGrid(ref int index, int notes, int far, int lost, string text, Color color)
        {
            var point = GetLeastScore(notes, notes - far - lost, far);
            this.dataGridView.Rows.Add(text, far, lost, point);
            this.dataGridView[0, index].Style.BackColor = color;
            SetPointColor(this.dataGridView, 3, index, point);
            ++index;
        }

        private void Check(ref int index, int notes, Func<int, Func<int, bool>> checker, string text, Color color)
        {
            var prev = -1;
            for (var far = Math.Min(notes, 200); 0 <= far; --far)
            {
                if (PartitionPoint(0, notes - far, checker(far)) is int crash)
                {
                    if (crash == 0)
                    {
                        continue;
                    }
                    var lost = crash - 1;
                    if (prev != lost)
                    {
                        AddGrid(ref index, notes, far, lost, text, color);
                        prev = lost;
                    }
                }
                else
                {
                    AddGrid(ref index, notes, far, 0, text, color);
                    prev = 0;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (this.manager[this.SongName.Text] is ScoreManager.Unit unit &&
                0 <= this.difficulty.SelectedIndex &&
                this.difficulty.SelectedIndex < 3)
            {
                this.dataGridView.Rows.Clear();
                var notes = unit.Notes[this.difficulty.SelectedIndex];
                var a = (
                    notes < 400 ? 0.2m * notes + 80 :
                    notes < 550 ? 0.2m * notes + 30 :
                    notes < 1400 ? 0.075m * notes + 100 : 0.8m - 900) / notes;
                Func<int,bool> NormalGauge(int far)
                {
                    return (i) => (notes - far - i) * a + 0.5m * a - 2m * i < 70m;
                };
                Func<int, bool> EasyGauge(int far)
                {
                    return (i) => (notes - far - i) * a + 0.5m * a - 1.2m * i < 70m;
                };
                var index = 0;
                Check(ref index, notes, NormalGauge, "ノーマルゲージ", Color.SkyBlue);
                Check(ref index, notes, EasyGauge, "イージーゲージ", Color.LimeGreen);
            }
        }
    }
}
