namespace Practica_11
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 80);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 0;
            label1.Text = "f(x)=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(301, 54);
            label2.Name = "label2";
            label2.Size = new Size(27, 32);
            label2.TabIndex = 1;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(281, 118);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 2;
            label3.Text = "1+x²";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(242, 86);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 3;
            label4.Text = "______________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(102, 202);
            label5.Name = "label5";
            label5.Size = new Size(27, 32);
            label5.TabIndex = 4;
            label5.Text = "x";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(242, 202);
            label6.Name = "label6";
            label6.Size = new Size(54, 32);
            label6.TabIndex = 5;
            label6.Text = "f(x)";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(68, 232);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(99, 214);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 30;
            listBox2.Location = new Point(218, 232);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(99, 214);
            listBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(400, 244);
            button1.Name = "button1";
            button1.Size = new Size(141, 44);
            button1.TabIndex = 8;
            button1.Text = "for";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(400, 294);
            button2.Name = "button2";
            button2.Size = new Size(141, 44);
            button2.TabIndex = 9;
            button2.Text = "while";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(400, 344);
            button3.Name = "button3";
            button3.Size = new Size(141, 44);
            button3.TabIndex = 10;
            button3.Text = "do..while";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(400, 394);
            button4.Name = "button4";
            button4.Size = new Size(141, 44);
            button4.TabIndex = 11;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
