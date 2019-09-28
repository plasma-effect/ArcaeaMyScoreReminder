namespace ScoreManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Best = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestPotential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepGL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepAxium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepFracture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.addDataSong = new System.Windows.Forms.ComboBox();
            this.addDataScore = new System.Windows.Forms.TextBox();
            this.addDataDifficulty = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.Rank,
            this.Song,
            this.Difficulty,
            this.Level,
            this.Potential,
            this.Best,
            this.BestPotential,
            this.BestStep,
            this.StepGL,
            this.StepAxium,
            this.StepFracture});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1750, 739);
            this.dataGridView1.TabIndex = 0;
            // 
            // Rank
            // 
            this.Rank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Rank.HeaderText = "順位";
            this.Rank.MinimumWidth = 10;
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Rank.Width = 58;
            // 
            // Song
            // 
            this.Song.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Song.HeaderText = "曲名";
            this.Song.MinimumWidth = 10;
            this.Song.Name = "Song";
            this.Song.ReadOnly = true;
            this.Song.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Song.Width = 58;
            // 
            // Difficulty
            // 
            this.Difficulty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Difficulty.HeaderText = "難易度";
            this.Difficulty.MinimumWidth = 10;
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.ReadOnly = true;
            this.Difficulty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Difficulty.Width = 79;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Level.HeaderText = "レベル";
            this.Level.MinimumWidth = 10;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Level.Width = 67;
            // 
            // Potential
            // 
            this.Potential.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Potential.HeaderText = "譜面定数";
            this.Potential.MinimumWidth = 10;
            this.Potential.Name = "Potential";
            this.Potential.ReadOnly = true;
            this.Potential.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Potential.Width = 79;
            // 
            // Best
            // 
            this.Best.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Best.HeaderText = "自己ベスト";
            this.Best.MinimumWidth = 10;
            this.Best.Name = "Best";
            this.Best.ReadOnly = true;
            this.Best.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Best.Width = 76;
            // 
            // BestPotential
            // 
            this.BestPotential.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BestPotential.HeaderText = "ポテンシャル";
            this.BestPotential.MinimumWidth = 10;
            this.BestPotential.Name = "BestPotential";
            this.BestPotential.ReadOnly = true;
            this.BestPotential.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BestPotential.Width = 83;
            // 
            // BestStep
            // 
            this.BestStep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BestStep.HeaderText = "ステップ数";
            this.BestStep.MinimumWidth = 10;
            this.BestStep.Name = "BestStep";
            this.BestStep.ReadOnly = true;
            this.BestStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BestStep.Width = 76;
            // 
            // StepGL
            // 
            this.StepGL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StepGL.HeaderText = "ステップ数(GL対立)";
            this.StepGL.MinimumWidth = 10;
            this.StepGL.Name = "StepGL";
            this.StepGL.ReadOnly = true;
            this.StepGL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StepGL.Width = 130;
            // 
            // StepAxium
            // 
            this.StepAxium.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StepAxium.HeaderText = "ステップ数(Axium対立)";
            this.StepAxium.MinimumWidth = 10;
            this.StepAxium.Name = "StepAxium";
            this.StepAxium.ReadOnly = true;
            this.StepAxium.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StepAxium.Width = 158;
            // 
            // StepFracture
            // 
            this.StepFracture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StepFracture.HeaderText = "ステップ数(FR光)";
            this.StepFracture.MinimumWidth = 10;
            this.StepFracture.Name = "StepFracture";
            this.StepFracture.ReadOnly = true;
            this.StepFracture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StepFracture.Width = 129;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(12, 757);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "データ編集";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DataManagerClick);
            // 
            // addDataSong
            // 
            this.addDataSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDataSong.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addDataSong.FormattingEnabled = true;
            this.addDataSong.Location = new System.Drawing.Point(1200, 778);
            this.addDataSong.Name = "addDataSong";
            this.addDataSong.Size = new System.Drawing.Size(250, 41);
            this.addDataSong.TabIndex = 2;
            // 
            // addDataScore
            // 
            this.addDataScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDataScore.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addDataScore.Location = new System.Drawing.Point(1612, 778);
            this.addDataScore.Name = "addDataScore";
            this.addDataScore.Size = new System.Drawing.Size(150, 39);
            this.addDataScore.TabIndex = 3;
            this.addDataScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddScore);
            // 
            // addDataDifficulty
            // 
            this.addDataDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDataDifficulty.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addDataDifficulty.FormattingEnabled = true;
            this.addDataDifficulty.Items.AddRange(new object[] {
            "Past",
            "Present",
            "Future"});
            this.addDataDifficulty.Location = new System.Drawing.Point(1456, 778);
            this.addDataDifficulty.Name = "addDataDifficulty";
            this.addDataDifficulty.Size = new System.Drawing.Size(150, 41);
            this.addDataDifficulty.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(218, 757);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "スコア編集";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EditScore);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(424, 757);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "フィルター";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.FilterClick);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.Location = new System.Drawing.Point(630, 757);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 60);
            this.button5.TabIndex = 8;
            this.button5.Text = "目標スコア";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 829);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addDataDifficulty);
            this.Controls.Add(this.addDataScore);
            this.Controls.Add(this.addDataSong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Arcaea Score Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Song;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potential;
        private System.Windows.Forms.DataGridViewTextBoxColumn Best;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestPotential;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepGL;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepAxium;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepFracture;
        private System.Windows.Forms.ComboBox addDataSong;
        private System.Windows.Forms.TextBox addDataScore;
        private System.Windows.Forms.ComboBox addDataDifficulty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}

