namespace ScoreManager
{
    partial class EditScoreForm
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
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Past = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Present = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Future = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            this.SongName,
            this.Past,
            this.Present,
            this.Future});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(850, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // SongName
            // 
            this.SongName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SongName.HeaderText = "曲名";
            this.SongName.MinimumWidth = 10;
            this.SongName.Name = "SongName";
            this.SongName.ReadOnly = true;
            this.SongName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Past
            // 
            this.Past.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Past.HeaderText = "Past";
            this.Past.MinimumWidth = 10;
            this.Past.Name = "Past";
            this.Past.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Past.Width = 150;
            // 
            // Present
            // 
            this.Present.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Present.HeaderText = "Present";
            this.Present.MinimumWidth = 10;
            this.Present.Name = "Present";
            this.Present.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Present.Width = 150;
            // 
            // Future
            // 
            this.Future.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Future.HeaderText = "Future";
            this.Future.MinimumWidth = 10;
            this.Future.Name = "Future";
            this.Future.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Future.Width = 150;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(712, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "完了";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // EditScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditScoreForm";
            this.Text = "EditScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Past;
        private System.Windows.Forms.DataGridViewTextBoxColumn Present;
        private System.Windows.Forms.DataGridViewTextBoxColumn Future;
        private System.Windows.Forms.Button button1;
    }
}