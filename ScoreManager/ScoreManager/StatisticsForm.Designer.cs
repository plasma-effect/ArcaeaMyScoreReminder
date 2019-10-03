namespace ScoreManager
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastPotential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastFarCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresentScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresentPotential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresentFarCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FutureScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuturePotential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FutureFarCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Song,
            this.PastScore,
            this.PastPotential,
            this.PastFarCount,
            this.PresentScore,
            this.PresentPotential,
            this.PresentFarCount,
            this.FutureScore,
            this.FuturePotential,
            this.FutureFarCount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1550, 805);
            this.dataGridView1.TabIndex = 0;
            // 
            // Song
            // 
            this.Song.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Song.HeaderText = "曲名";
            this.Song.MinimumWidth = 10;
            this.Song.Name = "Song";
            this.Song.ReadOnly = true;
            this.Song.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PastScore
            // 
            this.PastScore.HeaderText = "PST Score";
            this.PastScore.MinimumWidth = 10;
            this.PastScore.Name = "PastScore";
            this.PastScore.ReadOnly = true;
            this.PastScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PastScore.Width = 120;
            // 
            // PastPotential
            // 
            this.PastPotential.HeaderText = "PST Potential";
            this.PastPotential.MinimumWidth = 10;
            this.PastPotential.Name = "PastPotential";
            this.PastPotential.ReadOnly = true;
            this.PastPotential.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PastPotential.Width = 120;
            // 
            // PastFarCount
            // 
            this.PastFarCount.HeaderText = "PST Count";
            this.PastFarCount.MinimumWidth = 10;
            this.PastFarCount.Name = "PastFarCount";
            this.PastFarCount.ReadOnly = true;
            this.PastFarCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PastFarCount.Width = 120;
            // 
            // PresentScore
            // 
            this.PresentScore.HeaderText = "PRS Score";
            this.PresentScore.MinimumWidth = 10;
            this.PresentScore.Name = "PresentScore";
            this.PresentScore.ReadOnly = true;
            this.PresentScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PresentScore.Width = 120;
            // 
            // PresentPotential
            // 
            this.PresentPotential.HeaderText = "PRS Potential";
            this.PresentPotential.MinimumWidth = 10;
            this.PresentPotential.Name = "PresentPotential";
            this.PresentPotential.ReadOnly = true;
            this.PresentPotential.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PresentPotential.Width = 120;
            // 
            // PresentFarCount
            // 
            this.PresentFarCount.HeaderText = "PRS Count";
            this.PresentFarCount.MinimumWidth = 10;
            this.PresentFarCount.Name = "PresentFarCount";
            this.PresentFarCount.ReadOnly = true;
            this.PresentFarCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PresentFarCount.Width = 120;
            // 
            // FutureScore
            // 
            this.FutureScore.HeaderText = "FTR Score";
            this.FutureScore.MinimumWidth = 10;
            this.FutureScore.Name = "FutureScore";
            this.FutureScore.ReadOnly = true;
            this.FutureScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FutureScore.Width = 120;
            // 
            // FuturePotential
            // 
            this.FuturePotential.HeaderText = "FTR Potential";
            this.FuturePotential.MinimumWidth = 10;
            this.FuturePotential.Name = "FuturePotential";
            this.FuturePotential.ReadOnly = true;
            this.FuturePotential.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FuturePotential.Width = 120;
            // 
            // FutureFarCount
            // 
            this.FutureFarCount.HeaderText = "FTR Count";
            this.FutureFarCount.MinimumWidth = 10;
            this.FutureFarCount.Name = "FutureFarCount";
            this.FutureFarCount.ReadOnly = true;
            this.FutureFarCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FutureFarCount.Width = 120;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 829);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StatisticsForm";
            this.Text = "Data Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Song;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastPotential;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastFarCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresentScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresentPotential;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresentFarCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FutureScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuturePotential;
        private System.Windows.Forms.DataGridViewTextBoxColumn FutureFarCount;
    }
}