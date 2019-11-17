namespace ScoreManager
{
    partial class ClearLineForm
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
            this.SongName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ClearType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FarCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.推定最低スコア = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SongName
            // 
            this.SongName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SongName.FormattingEnabled = true;
            this.SongName.Location = new System.Drawing.Point(12, 12);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(584, 41);
            this.SongName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(562, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // difficulty
            // 
            this.difficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.difficulty.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Items.AddRange(new object[] {
            "Past",
            "Present",
            "Future"});
            this.difficulty.Location = new System.Drawing.Point(602, 12);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(160, 41);
            this.difficulty.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClearType,
            this.FarCount,
            this.LostCount,
            this.推定最低スコア});
            this.dataGridView.Location = new System.Drawing.Point(12, 83);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(750, 568);
            this.dataGridView.TabIndex = 3;
            // 
            // ClearType
            // 
            this.ClearType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClearType.HeaderText = "クリア区分";
            this.ClearType.MinimumWidth = 10;
            this.ClearType.Name = "ClearType";
            this.ClearType.ReadOnly = true;
            this.ClearType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FarCount
            // 
            this.FarCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FarCount.HeaderText = "Far数";
            this.FarCount.MinimumWidth = 10;
            this.FarCount.Name = "FarCount";
            this.FarCount.ReadOnly = true;
            this.FarCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FarCount.Width = 120;
            // 
            // LostCount
            // 
            this.LostCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LostCount.HeaderText = "Lost数";
            this.LostCount.MinimumWidth = 10;
            this.LostCount.Name = "LostCount";
            this.LostCount.ReadOnly = true;
            this.LostCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LostCount.Width = 120;
            // 
            // 推定最低スコア
            // 
            this.推定最低スコア.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.推定最低スコア.HeaderText = "Score";
            this.推定最低スコア.MinimumWidth = 10;
            this.推定最低スコア.Name = "推定最低スコア";
            this.推定最低スコア.ReadOnly = true;
            this.推定最低スコア.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.推定最低スコア.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "※途中で0%や100%にならないことを想定した値なので参考程度と考えてください";
            // 
            // ClearLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SongName);
            this.Name = "ClearLineForm";
            this.Text = "ClearLineForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SongName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClearType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FarCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn 推定最低スコア;
        private System.Windows.Forms.Label label1;
    }
}