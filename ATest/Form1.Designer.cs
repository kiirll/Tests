namespace ATest
{
    partial class Form1
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
            this.createTest = new System.Windows.Forms.Button();
            this.useTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTest
            // 
            this.createTest.BackColor = System.Drawing.Color.LightCoral;
            this.createTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTest.Location = new System.Drawing.Point(55, 116);
            this.createTest.Name = "createTest";
            this.createTest.Size = new System.Drawing.Size(214, 76);
            this.createTest.TabIndex = 0;
            this.createTest.Text = "Создать тест";
            this.createTest.UseVisualStyleBackColor = false;
            this.createTest.Click += new System.EventHandler(this.createTest_Click);
            // 
            // useTest
            // 
            this.useTest.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.useTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useTest.Location = new System.Drawing.Point(319, 116);
            this.useTest.Name = "useTest";
            this.useTest.Size = new System.Drawing.Size(211, 76);
            this.useTest.TabIndex = 1;
            this.useTest.Text = "Пройти тест";
            this.useTest.UseVisualStyleBackColor = false;
            this.useTest.Click += new System.EventHandler(this.useTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 293);
            this.Controls.Add(this.useTest);
            this.Controls.Add(this.createTest);
            this.Name = "Form1";
            this.Text = "Тесты";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createTest;
        private System.Windows.Forms.Button useTest;
    }
}

