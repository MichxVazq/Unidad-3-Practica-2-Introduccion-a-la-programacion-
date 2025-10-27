namespace Practica_10
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 59);
            label1.Name = "label1";
            label1.Size = new Size(182, 50);
            label1.TabIndex = 0;
            label1.Text = "z=x² + x³";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 146);
            label2.Name = "label2";
            label2.Size = new Size(42, 50);
            label2.TabIndex = 1;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(249, 146);
            label3.Name = "label3";
            label3.Size = new Size(57, 50);
            label3.TabIndex = 2;
            label3.Text = "x²";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(528, 146);
            label4.Name = "label4";
            label4.Size = new Size(57, 50);
            label4.TabIndex = 3;
            label4.Text = "x³";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(711, 146);
            label5.Name = "label5";
            label5.Size = new Size(40, 50);
            label5.TabIndex = 4;
            label5.Text = "z";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 255, 192);
            listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(30, 199);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(117, 184);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(255, 255, 192);
            listBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 30;
            listBox2.Location = new Point(211, 199);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(117, 184);
            listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.FromArgb(255, 255, 192);
            listBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 30;
            listBox3.Location = new Point(481, 199);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(117, 184);
            listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.FromArgb(255, 255, 192);
            listBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 30;
            listBox4.Location = new Point(671, 199);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(117, 184);
            listBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(270, 389);
            button1.Name = "button1";
            button1.Size = new Size(296, 56);
            button1.TabIndex = 9;
            button1.Text = "Calcular Valores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Button button1;
    }
}
