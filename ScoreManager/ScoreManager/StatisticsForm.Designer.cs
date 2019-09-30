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
            this.Past = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Present = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Future = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Past,
            this.Present,
            this.Future});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(950, 705);
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
            // Past
            // 
            this.Past.HeaderText = "Past";
            this.Past.MinimumWidth = 10;
            this.Past.Name = "Past";
            this.Past.ReadOnly = true;
            this.Past.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Past.Width = 120;
            // 
            // Present
            // 
            this.Present.HeaderText = "Present";
            this.Present.MinimumWidth = 10;
            this.Present.Name = "Present";
            this.Present.ReadOnly = true;
            this.Present.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Present.Width = 120;
            // 
            // Future
            // 
            this.Future.HeaderText = "Future";
            this.Future.MinimumWidth = 10;
            this.Future.Name = "Future";
            this.Future.ReadOnly = true;
            this.Future.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Future.Width = 120;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Song;
        private System.Windows.Forms.DataGridViewTextBoxColumn Past;
        private System.Windows.Forms.DataGridViewTextBoxColumn Present;
        private System.Windows.Forms.DataGridViewTextBoxColumn Future;
    }
}