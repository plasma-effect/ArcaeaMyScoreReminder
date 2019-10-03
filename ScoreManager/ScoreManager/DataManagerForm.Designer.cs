namespace ScoreManager
{
    partial class DataManagerForm
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
            this.songDataGrid = new System.Windows.Forms.DataGridView();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastPotential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresentLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresentPotential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresentNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FutureLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuturePotential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FutureNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // songDataGrid
            // 
            this.songDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongName,
            this.PastLevel,
            this.PastPotential,
            this.PastNotes,
            this.PresentLevel,
            this.PresentPotential,
            this.PresentNotes,
            this.FutureLevel,
            this.FuturePotential,
            this.FutureNotes});
            this.songDataGrid.Location = new System.Drawing.Point(12, 12);
            this.songDataGrid.Name = "songDataGrid";
            this.songDataGrid.RowHeadersWidth = 82;
            this.songDataGrid.RowTemplate.Height = 33;
            this.songDataGrid.Size = new System.Drawing.Size(1750, 639);
            this.songDataGrid.TabIndex = 0;
            // 
            // SongName
            // 
            this.SongName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SongName.HeaderText = "曲名";
            this.SongName.MinimumWidth = 10;
            this.SongName.Name = "SongName";
            this.SongName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PastLevel
            // 
            this.PastLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PastLevel.HeaderText = "PST レベル";
            this.PastLevel.MinimumWidth = 10;
            this.PastLevel.Name = "PastLevel";
            this.PastLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PastPotential
            // 
            this.PastPotential.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PastPotential.HeaderText = "PST 譜面定数";
            this.PastPotential.MinimumWidth = 10;
            this.PastPotential.Name = "PastPotential";
            this.PastPotential.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PastNotes
            // 
            this.PastNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PastNotes.HeaderText = "PST ノーツ数";
            this.PastNotes.MinimumWidth = 10;
            this.PastNotes.Name = "PastNotes";
            this.PastNotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PresentLevel
            // 
            this.PresentLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PresentLevel.HeaderText = "PRS レベル";
            this.PresentLevel.MinimumWidth = 10;
            this.PresentLevel.Name = "PresentLevel";
            this.PresentLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PresentPotential
            // 
            this.PresentPotential.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PresentPotential.HeaderText = "PRS 譜面定数";
            this.PresentPotential.MinimumWidth = 10;
            this.PresentPotential.Name = "PresentPotential";
            this.PresentPotential.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PresentNotes
            // 
            this.PresentNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PresentNotes.HeaderText = "PRS ノーツ数";
            this.PresentNotes.MinimumWidth = 10;
            this.PresentNotes.Name = "PresentNotes";
            this.PresentNotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FutureLevel
            // 
            this.FutureLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FutureLevel.HeaderText = "FTR レベル";
            this.FutureLevel.MinimumWidth = 10;
            this.FutureLevel.Name = "FutureLevel";
            this.FutureLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FuturePotential
            // 
            this.FuturePotential.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FuturePotential.HeaderText = "FTR 譜面定数";
            this.FuturePotential.MinimumWidth = 10;
            this.FuturePotential.Name = "FuturePotential";
            this.FuturePotential.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FutureNotes
            // 
            this.FutureNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FutureNotes.HeaderText = "FTR ノーツ数";
            this.FutureNotes.MinimumWidth = 10;
            this.FutureNotes.Name = "FutureNotes";
            this.FutureNotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1562, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "完了";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // DataManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.songDataGrid);
            this.Name = "DataManagerForm";
            this.Text = "Song Data Manager";
            ((System.ComponentModel.ISupportInitialize)(this.songDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView songDataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastPotential;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresentLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresentPotential;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresentNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FutureLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuturePotential;
        private System.Windows.Forms.DataGridViewTextBoxColumn FutureNotes;
    }
}