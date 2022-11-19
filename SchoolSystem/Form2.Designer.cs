
namespace SchoolSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idStudentBox = new System.Windows.Forms.TextBox();
            this.studNameBox = new System.Windows.Forms.TextBox();
            this.studSurnameBox = new System.Windows.Forms.TextBox();
            this.studFamilyBox = new System.Windows.Forms.TextBox();
            this.studEmailBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идентификатор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Презиме";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "e-mail";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Търси";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Запази";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Затвори";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // idStudentBox
            // 
            this.idStudentBox.Location = new System.Drawing.Point(226, 36);
            this.idStudentBox.Name = "idStudentBox";
            this.idStudentBox.Size = new System.Drawing.Size(96, 31);
            this.idStudentBox.TabIndex = 8;
            // 
            // studNameBox
            // 
            this.studNameBox.Location = new System.Drawing.Point(226, 95);
            this.studNameBox.Name = "studNameBox";
            this.studNameBox.Size = new System.Drawing.Size(326, 31);
            this.studNameBox.TabIndex = 8;
            // 
            // studSurnameBox
            // 
            this.studSurnameBox.Location = new System.Drawing.Point(226, 146);
            this.studSurnameBox.Name = "studSurnameBox";
            this.studSurnameBox.Size = new System.Drawing.Size(326, 31);
            this.studSurnameBox.TabIndex = 8;
            // 
            // studFamilyBox
            // 
            this.studFamilyBox.Location = new System.Drawing.Point(226, 193);
            this.studFamilyBox.Name = "studFamilyBox";
            this.studFamilyBox.Size = new System.Drawing.Size(326, 31);
            this.studFamilyBox.TabIndex = 8;
            // 
            // studEmailBox
            // 
            this.studEmailBox.Location = new System.Drawing.Point(226, 252);
            this.studEmailBox.Name = "studEmailBox";
            this.studEmailBox.Size = new System.Drawing.Size(326, 31);
            this.studEmailBox.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.studEmailBox);
            this.Controls.Add(this.studFamilyBox);
            this.Controls.Add(this.studSurnameBox);
            this.Controls.Add(this.studNameBox);
            this.Controls.Add(this.idStudentBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Ученик";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox idStudentBox;
        private System.Windows.Forms.TextBox studNameBox;
        private System.Windows.Forms.TextBox studSurnameBox;
        private System.Windows.Forms.TextBox studFamilyBox;
        private System.Windows.Forms.TextBox studEmailBox;
    }
}