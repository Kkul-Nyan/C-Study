namespace Personal_Project_1
{
    partial class game
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnWordinvaders = new System.Windows.Forms.Button();
            this.btnRain = new System.Windows.Forms.Button();
            this.btnBreakBlocks = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "선      택";
            // 
            // btnWordinvaders
            // 
            this.btnWordinvaders.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWordinvaders.Location = new System.Drawing.Point(52, 126);
            this.btnWordinvaders.Name = "btnWordinvaders";
            this.btnWordinvaders.Size = new System.Drawing.Size(300, 60);
            this.btnWordinvaders.TabIndex = 1;
            this.btnWordinvaders.Text = "워드인베이더";
            this.btnWordinvaders.UseVisualStyleBackColor = true;
            this.btnWordinvaders.Click += new System.EventHandler(this.btnWordinvaders_Click);
            // 
            // btnRain
            // 
            this.btnRain.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRain.Location = new System.Drawing.Point(52, 224);
            this.btnRain.Name = "btnRain";
            this.btnRain.Size = new System.Drawing.Size(300, 60);
            this.btnRain.TabIndex = 2;
            this.btnRain.Text = "소나기";
            this.btnRain.UseVisualStyleBackColor = true;
            this.btnRain.Click += new System.EventHandler(this.btnRain_Click);
            // 
            // btnBreakBlocks
            // 
            this.btnBreakBlocks.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBreakBlocks.Location = new System.Drawing.Point(52, 323);
            this.btnBreakBlocks.Name = "btnBreakBlocks";
            this.btnBreakBlocks.Size = new System.Drawing.Size(300, 60);
            this.btnBreakBlocks.TabIndex = 3;
            this.btnBreakBlocks.Text = "땅따먹기";
            this.btnBreakBlocks.UseVisualStyleBackColor = true;
            this.btnBreakBlocks.Click += new System.EventHandler(this.btnBreakBlocks_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRanking.Location = new System.Drawing.Point(52, 421);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(300, 60);
            this.btnRanking.TabIndex = 4;
            this.btnRanking.Text = "랭     킹";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinish.Location = new System.Drawing.Point(52, 514);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(300, 60);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "종     료";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(409, 601);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnBreakBlocks);
            this.Controls.Add(this.btnRain);
            this.Controls.Add(this.btnWordinvaders);
            this.Controls.Add(this.label1);
            this.Name = "game";
            this.Text = "game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnWordinvaders;
        private Button btnRain;
        private Button btnBreakBlocks;
        private Button btnRanking;
        private Button btnFinish;
    }
}