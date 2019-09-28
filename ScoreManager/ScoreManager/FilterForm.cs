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
    public partial class FilterForm : Form
    {
        public FilterForm(MainForm form)
        {
            InitializeComponent();
            this.potentialUpperOrLower.SelectedIndex = 0;
            this.scoreUpperOrLower.SelectedIndex = 0;
            this.levelFilters = new CheckBox[11];
            this.levelFilters[0] = this.levelFilter0;
            this.levelFilters[1] = this.levelFilter1;
            this.levelFilters[2] = this.levelFilter2;
            this.levelFilters[3] = this.levelFilter3;
            this.levelFilters[4] = this.levelFilter4;
            this.levelFilters[5] = this.levelFilter5;
            this.levelFilters[6] = this.levelFilter6;
            this.levelFilters[7] = this.levelFilter7;
            this.levelFilters[8] = this.levelFilter8;
            this.levelFilters[9] = this.levelFilter9;
            this.levelFilters[10] = this.levelFilter10;

            this.difficultyFilters = new CheckBox[3];
            this.difficultyFilters[0] = this.difficultyFilter0;
            this.difficultyFilters[1] = this.difficultyFilter1;
            this.difficultyFilters[2] = this.difficultyFilter2;

            this.myParent = form;
        }

        CheckBox[] levelFilters;
        CheckBox[] difficultyFilters;
        MainForm myParent;

        private void FilterReset(object sender, EventArgs e)
        {
            foreach(var filter in this.levelFilters)
            {
                filter.Checked = true;
            }
            foreach(var filter in this.difficultyFilters)
            {
                filter.Checked = true;
            }
            this.potentialFilter.Text = "";
            this.potentialUpperOrLower.SelectedIndex = 0;
            this.scoreFilter.Text = "";
            this.scoreUpperOrLower.SelectedIndex = 0;
        }

        private void Complete(object sender, EventArgs e)
        {
            this.myParent.SetFilter(
                new Filter(this.levelFilters, this.difficultyFilters,
                this.potentialFilter, this.potentialUpperOrLower,
                this.scoreFilter, this.scoreUpperOrLower));
            this.DialogResult = DialogResult.OK;
        }
    }

    public class Filter
    {
        public bool[] LevelFilters { get; }
        public bool[] DifficultyFilters { get; }

        public enum Comparison
        {
            more,
            moreEqual,
            equal,
            lessEqual,
            less
        }

        public decimal? PotentialFilter { get; }
        public Comparison PotentialFlag { get; }
        public int? ScoreFilter { get; }
        public Comparison ScoreFlag { get; }

        public Filter(CheckBox[] levelFilters, CheckBox[] difficultyFilters, TextBox potential, ComboBox potentialFlag, TextBox score, ComboBox scoreFlag)
        {
            this.LevelFilters = new bool[11];
            this.DifficultyFilters = new bool[3];
            this.PotentialFlag = default;
            this.ScoreFlag = default;
            foreach (var i in Range(0, 11))
            {
                this.LevelFilters[i] = levelFilters[i].Checked;
            }
            foreach (var i in Range(0, 3))
            {
                this.DifficultyFilters[i] = difficultyFilters[i].Checked;
            }
            if (decimal.TryParse(potential.Text, out var p))
            {
                this.PotentialFilter = p;
                this.PotentialFlag = (Comparison)potentialFlag.SelectedIndex;
            }
            if (int.TryParse(score.Text, out var s))
            {
                this.ScoreFilter = s;
                this.ScoreFlag = (Comparison)scoreFlag.SelectedIndex;
            }
        }
    }

}
