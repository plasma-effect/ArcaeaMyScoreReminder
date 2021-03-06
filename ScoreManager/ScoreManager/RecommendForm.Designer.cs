﻿namespace ScoreManager
{
    partial class RecommendForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.scoreRestrict = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rankRestrict = new System.Windows.Forms.ComboBox();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyBest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NowFarCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1112, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "適用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // scoreRestrict
            // 
            this.scoreRestrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreRestrict.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.scoreRestrict.FormattingEnabled = true;
            this.scoreRestrict.Items.AddRange(new object[] {
            "9800000未満",
            "9950000未満",
            "PURE MEMORYを除く",
            "無制限"});
            this.scoreRestrict.Location = new System.Drawing.Point(763, 59);
            this.scoreRestrict.Name = "scoreRestrict";
            this.scoreRestrict.Size = new System.Drawing.Size(343, 41);
            this.scoreRestrict.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongName,
            this.Difficulty,
            this.Level,
            this.Potential,
            this.MyBest,
            this.TargetScore,
            this.NowFarCount,
            this.TargetCount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 711);
            this.dataGridView1.TabIndex = 2;
            // 
            // rankRestrict
            // 
            this.rankRestrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rankRestrict.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rankRestrict.FormattingEnabled = true;
            this.rankRestrict.Items.AddRange(new object[] {
            "1位",
            "2位",
            "3位",
            "4位",
            "5位",
            "6位",
            "7位",
            "8位",
            "9位",
            "10位",
            "11位",
            "12位",
            "13位",
            "14位",
            "15位",
            "16位",
            "17位",
            "18位",
            "19位",
            "20位",
            "21位",
            "22位",
            "23位",
            "24位",
            "25位",
            "26位",
            "27位",
            "28位",
            "29位",
            "30位"});
            this.rankRestrict.Location = new System.Drawing.Point(763, 12);
            this.rankRestrict.Name = "rankRestrict";
            this.rankRestrict.Size = new System.Drawing.Size(343, 41);
            this.rankRestrict.TabIndex = 3;
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
            // Difficulty
            // 
            this.Difficulty.HeaderText = "難易度";
            this.Difficulty.MinimumWidth = 10;
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.ReadOnly = true;
            this.Difficulty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Difficulty.Width = 120;
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.MinimumWidth = 10;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Level.Width = 120;
            // 
            // Potential
            // 
            this.Potential.HeaderText = "譜面定数";
            this.Potential.MinimumWidth = 10;
            this.Potential.Name = "Potential";
            this.Potential.ReadOnly = true;
            this.Potential.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Potential.Width = 120;
            // 
            // MyBest
            // 
            this.MyBest.HeaderText = "自己ベスト";
            this.MyBest.MinimumWidth = 10;
            this.MyBest.Name = "MyBest";
            this.MyBest.ReadOnly = true;
            this.MyBest.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MyBest.Width = 120;
            // 
            // TargetScore
            // 
            this.TargetScore.HeaderText = "目標スコア";
            this.TargetScore.MinimumWidth = 10;
            this.TargetScore.Name = "TargetScore";
            this.TargetScore.ReadOnly = true;
            this.TargetScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TargetScore.Width = 120;
            // 
            // NowFarCount
            // 
            this.NowFarCount.HeaderText = "現在Far数";
            this.NowFarCount.MinimumWidth = 10;
            this.NowFarCount.Name = "NowFarCount";
            this.NowFarCount.ReadOnly = true;
            this.NowFarCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NowFarCount.Width = 120;
            // 
            // TargetCount
            // 
            this.TargetCount.HeaderText = "目標Far数";
            this.TargetCount.MinimumWidth = 10;
            this.TargetCount.Name = "TargetCount";
            this.TargetCount.ReadOnly = true;
            this.TargetCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TargetCount.Width = 120;
            // 
            // RecommendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 829);
            this.Controls.Add(this.rankRestrict);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.scoreRestrict);
            this.Controls.Add(this.button1);
            this.Name = "RecommendForm";
            this.Text = "RecommendForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox scoreRestrict;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox rankRestrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potential;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyBest;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn NowFarCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetCount;
    }
}