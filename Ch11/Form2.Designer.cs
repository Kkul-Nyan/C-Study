namespace Ch11
{
    partial class Form2
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
            this.f2title1 = new System.Windows.Forms.Label();
            this.subtitle1 = new System.Windows.Forms.Label();
            this.content1 = new System.Windows.Forms.Label();
            this.cbbt1 = new System.Windows.Forms.Button();
            this.result1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.result2 = new System.Windows.Forms.Label();
            this.cbbt2 = new System.Windows.Forms.Button();
            this.content2 = new System.Windows.Forms.Label();
            this.subtitle2 = new System.Windows.Forms.Label();
            this.lstcountry = new System.Windows.Forms.ListBox();
            this.lstresult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvmember = new System.Windows.Forms.DataGridView();
            this.savebutten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmember)).BeginInit();
            this.SuspendLayout();
            // 
            // f2title1
            // 
            this.f2title1.AutoSize = true;
            this.f2title1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.f2title1.Location = new System.Drawing.Point(12, 9);
            this.f2title1.Name = "f2title1";
            this.f2title1.Size = new System.Drawing.Size(230, 21);
            this.f2title1.TabIndex = 0;
            this.f2title1.Text = "데이터를 공급해주는 컨트롤러";
            // 
            // subtitle1
            // 
            this.subtitle1.AutoSize = true;
            this.subtitle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subtitle1.Location = new System.Drawing.Point(12, 40);
            this.subtitle1.Name = "subtitle1";
            this.subtitle1.Size = new System.Drawing.Size(93, 15);
            this.subtitle1.TabIndex = 1;
            this.subtitle1.Text = "ComboBox연습";
            // 
            // content1
            // 
            this.content1.AutoSize = true;
            this.content1.Location = new System.Drawing.Point(12, 69);
            this.content1.Name = "content1";
            this.content1.Size = new System.Drawing.Size(31, 15);
            this.content1.TabIndex = 2;
            this.content1.Text = "직급";
            // 
            // cbbt1
            // 
            this.cbbt1.Location = new System.Drawing.Point(184, 65);
            this.cbbt1.Name = "cbbt1";
            this.cbbt1.Size = new System.Drawing.Size(75, 23);
            this.cbbt1.TabIndex = 4;
            this.cbbt1.Text = "확인";
            this.cbbt1.UseVisualStyleBackColor = true;
            this.cbbt1.Click += new System.EventHandler(this.cbbt1_Click);
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Location = new System.Drawing.Point(265, 69);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(38, 15);
            this.result1.TabIndex = 5;
            this.result1.Text = "결과 :";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(57, 66);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 23);
            this.cb1.TabIndex = 6;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(57, 104);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(121, 23);
            this.cb2.TabIndex = 10;
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Location = new System.Drawing.Point(265, 107);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(38, 15);
            this.result2.TabIndex = 9;
            this.result2.Text = "결과 :";
            // 
            // cbbt2
            // 
            this.cbbt2.Location = new System.Drawing.Point(184, 103);
            this.cbbt2.Name = "cbbt2";
            this.cbbt2.Size = new System.Drawing.Size(75, 23);
            this.cbbt2.TabIndex = 8;
            this.cbbt2.Text = "확인";
            this.cbbt2.UseVisualStyleBackColor = true;
            this.cbbt2.Click += new System.EventHandler(this.cbbt2_Click);
            // 
            // content2
            // 
            this.content2.AutoSize = true;
            this.content2.Location = new System.Drawing.Point(12, 107);
            this.content2.Name = "content2";
            this.content2.Size = new System.Drawing.Size(31, 15);
            this.content2.TabIndex = 7;
            this.content2.Text = "취미";
            // 
            // subtitle2
            // 
            this.subtitle2.AutoSize = true;
            this.subtitle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subtitle2.Location = new System.Drawing.Point(12, 157);
            this.subtitle2.Name = "subtitle2";
            this.subtitle2.Size = new System.Drawing.Size(72, 15);
            this.subtitle2.TabIndex = 11;
            this.subtitle2.Text = "ListBox연습";
            // 
            // lstcountry
            // 
            this.lstcountry.FormattingEnabled = true;
            this.lstcountry.ItemHeight = 15;
            this.lstcountry.Location = new System.Drawing.Point(12, 192);
            this.lstcountry.Name = "lstcountry";
            this.lstcountry.Size = new System.Drawing.Size(166, 109);
            this.lstcountry.TabIndex = 12;
            this.lstcountry.SelectedIndexChanged += new System.EventHandler(this.lstcountry_SelectedIndexChanged);
            // 
            // lstresult
            // 
            this.lstresult.AutoSize = true;
            this.lstresult.Location = new System.Drawing.Point(184, 286);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(38, 15);
            this.lstresult.TabIndex = 13;
            this.lstresult.Text = "결과 :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ch11.Properties.Resources._03;
            this.pictureBox1.Location = new System.Drawing.Point(286, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "DataGridView연습";
            // 
            // dgvmember
            // 
            this.dgvmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmember.Location = new System.Drawing.Point(19, 390);
            this.dgvmember.Name = "dgvmember";
            this.dgvmember.RowTemplate.Height = 25;
            this.dgvmember.Size = new System.Drawing.Size(430, 150);
            this.dgvmember.TabIndex = 16;
            this.dgvmember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // savebutten
            // 
            this.savebutten.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savebutten.Location = new System.Drawing.Point(19, 559);
            this.savebutten.Name = "savebutten";
            this.savebutten.Size = new System.Drawing.Size(430, 59);
            this.savebutten.TabIndex = 17;
            this.savebutten.Text = "SAVE";
            this.savebutten.UseVisualStyleBackColor = true;
            this.savebutten.Click += new System.EventHandler(this.savebutten_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.savebutten);
            this.Controls.Add(this.dgvmember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstresult);
            this.Controls.Add(this.lstcountry);
            this.Controls.Add(this.subtitle2);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.cbbt2);
            this.Controls.Add(this.content2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.cbbt1);
            this.Controls.Add(this.content1);
            this.Controls.Add(this.subtitle1);
            this.Controls.Add(this.f2title1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label f2title1;
        private Label subtitle1;
        private Label content1;
        private Button cbbt1;
        private Label result1;
        private ComboBox cb1;
        private ComboBox cb2;
        private Label result2;
        private Button cbbt2;
        private Label content2;
        private Label subtitle2;
        private ListBox lstcountry;
        private Label lstresult;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvmember;
        private Button savebutten;
    }
}