﻿namespace forms_turk
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
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            btnUrunEkle = new Button();
            btnPersonelEkel = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(663, 192);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "LİStele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(504, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(193, 84);
            listBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(30, 103);
            button2.Name = "button2";
            button2.Size = new Size(180, 32);
            button2.TabIndex = 2;
            button2.Text = "Alışveriş Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(237, 103);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(115, 32);
            btnUrunEkle.TabIndex = 3;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            // 
            // btnPersonelEkel
            // 
            btnPersonelEkel.Location = new Point(30, 172);
            btnPersonelEkel.Name = "btnPersonelEkel";
            btnPersonelEkel.Size = new Size(180, 32);
            btnPersonelEkel.TabIndex = 4;
            btnPersonelEkel.Text = "Personel Ekle";
            btnPersonelEkel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPersonelEkel);
            Controls.Add(btnUrunEkle);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button btnUrunEkle;
        private Button btnPersonelEkel;
    }
}