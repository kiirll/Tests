namespace ATest
{
    partial class CheckTest
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
            this.openTest = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nameTest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numberQ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textQuestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openTest
            // 
            this.openTest.Location = new System.Drawing.Point(12, 12);
            this.openTest.Name = "openTest";
            this.openTest.Size = new System.Drawing.Size(123, 33);
            this.openTest.TabIndex = 0;
            this.openTest.Text = "Открыть  тест";
            this.openTest.UseVisualStyleBackColor = true;
            this.openTest.Click += new System.EventHandler(this.openTest_Click);
            // 
            // nameTest
            // 
            this.nameTest.AutoSize = true;
            this.nameTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.86F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTest.Location = new System.Drawing.Point(154, 13);
            this.nameTest.Name = "nameTest";
            this.nameTest.Size = new System.Drawing.Size(0, 25);
            this.nameTest.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.button1.Location = new System.Drawing.Point(429, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Следующий вопрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberQ
            // 
            this.numberQ.AutoSize = true;
            this.numberQ.Location = new System.Drawing.Point(113, 72);
            this.numberQ.Name = "numberQ";
            this.numberQ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numberQ.Size = new System.Drawing.Size(0, 13);
            this.numberQ.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер вопроса";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(116, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 132);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Вопрос";
            // 
            // textQuestion
            // 
            this.textQuestion.AutoSize = true;
            this.textQuestion.Location = new System.Drawing.Point(82, 104);
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.Size = new System.Drawing.Size(0, 13);
            this.textQuestion.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(16, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 132);
            this.panel1.TabIndex = 14;
            // 
            // CheckTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(606, 380);
            this.Controls.Add(this.textQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numberQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTest);
            this.Controls.Add(this.openTest);
            this.Name = "CheckTest";
            this.Text = "CheckTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openTest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label nameTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label numberQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textQuestion;
        private System.Windows.Forms.Panel panel1;
    }
}