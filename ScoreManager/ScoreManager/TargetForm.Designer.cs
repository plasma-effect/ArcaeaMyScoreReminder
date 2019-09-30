namespace ScoreManager
{
    partial class TargetForm
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
            this.targetValue = new System.Windows.Forms.TextBox();
            this.targetType = new System.Windows.Forms.ComboBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(950, 558);
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
            // targetValue
            // 
            this.targetValue.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.targetValue.Location = new System.Drawing.Point(12, 12);
            this.targetValue.Name = "targetValue";
            this.targetValue.Size = new System.Drawing.Size(133, 39);
            this.targetValue.TabIndex = 1;
            // 
            // targetType
            // 
            this.targetType.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.targetType.FormattingEnabled = true;
            this.targetType.Items.AddRange(new object[] {
            "譜面別ポテンシャル",
            "ステップ数(基礎)",
            "ステップ数(GL対立)",
            "ステップ数(Axium対立)",
            "ステップ数(FR光)"});
            this.targetType.Location = new System.Drawing.Point(151, 12);
            this.targetType.Name = "targetType";
            this.targetType.Size = new System.Drawing.Size(350, 41);
            this.targetType.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(507, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "適用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Accept);
            // 
            // TargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.targetType);
            this.Controls.Add(this.targetValue);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TargetForm";
            this.Text = "TargetForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox targetValue;
        private System.Windows.Forms.ComboBox targetType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Past;
        private System.Windows.Forms.DataGridViewTextBoxColumn Present;
        private System.Windows.Forms.DataGridViewTextBoxColumn Future;
    }
}