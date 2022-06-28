namespace Personal_Project_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnword = new System.Windows.Forms.Button();
            this.btnstring = new System.Windows.Forms.Button();
            this.btnpage = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.btngame = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnword
            // 
            this.btnword.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnword.Location = new System.Drawing.Point(62, 96);
            this.btnword.Name = "btnword";
            this.btnword.Size = new System.Drawing.Size(278, 90);
            this.btnword.TabIndex = 0;
            this.btnword.Text = "단어 연습";
            this.btnword.UseVisualStyleBackColor = true;
            this.btnword.Click += new System.EventHandler(this.btnword_Click);
            // 
            // btnstring
            // 
            this.btnstring.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnstring.Location = new System.Drawing.Point(62, 192);
            this.btnstring.Name = "btnstring";
            this.btnstring.Size = new System.Drawing.Size(278, 90);
            this.btnstring.TabIndex = 1;
            this.btnstring.Text = "단문 연습";
            this.btnstring.UseVisualStyleBackColor = true;
            this.btnstring.Click += new System.EventHandler(this.btnstring_Click);
            // 
            // btnpage
            // 
            this.btnpage.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpage.Location = new System.Drawing.Point(62, 288);
            this.btnpage.Name = "btnpage";
            this.btnpage.Size = new System.Drawing.Size(278, 90);
            this.btnpage.TabIndex = 2;
            this.btnpage.Text = "장문 연습";
            this.btnpage.UseVisualStyleBackColor = true;
            this.btnpage.Click += new System.EventHandler(this.btnpage_Click);
            // 
            // Finish
            // 
            this.Finish.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Finish.Location = new System.Drawing.Point(62, 480);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(278, 90);
            this.Finish.TabIndex = 3;
            this.Finish.Text = "종     료";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // btngame
            // 
            this.btngame.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btngame.Location = new System.Drawing.Point(62, 384);
            this.btngame.Name = "btngame";
            this.btngame.Size = new System.Drawing.Size(278, 90);
            this.btngame.TabIndex = 4;
            this.btngame.Text = "게     임";
            this.btngame.UseVisualStyleBackColor = true;
            this.btngame.Click += new System.EventHandler(this.btngame_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.Location = new System.Drawing.Point(212, 576);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(75, 23);
            this.btnadmin.TabIndex = 7;
            this.btnadmin.Text = "button1";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Visible = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "made 2022/06/23";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 86);
            this.label2.TabIndex = 9;
            this.label2.Text = "타자연습기";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 604);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btngame);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.btnpage);
            this.Controls.Add(this.btnstring);
            this.Controls.Add(this.btnword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnword;
        private Button btnstring;
        private Button btnpage;
        private Button Finish;
        private Button btngame;
        private Button btnadmin;
        private Label label1;
        private Label label2;
    }
}