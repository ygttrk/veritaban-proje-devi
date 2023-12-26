
namespace forms_turk
{
    partial class FormHome
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
            btnCityAdd = new Button();
            btnUrunTuru = new Button();
            HeadLine = new Label();
            btnEmployeeAdd = new Button();
            btnCustomerAdd = new Button();
            btnCountyAdd = new Button();
            btnNeigherborHoodAdd = new Button();
            LabelAdd = new Label();
            LabelList = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 93);
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
            listBox1.Location = new Point(27, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(193, 84);
            listBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(49, 343);
            button2.Name = "button2";
            button2.Size = new Size(180, 32);
            button2.TabIndex = 2;
            button2.Text = "Alışveriş Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(49, 441);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(180, 32);
            btnUrunEkle.TabIndex = 3;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            // 
            // btnCityAdd
            // 
            btnCityAdd.Location = new Point(49, 294);
            btnCityAdd.Name = "btnCityAdd";
            btnCityAdd.Size = new Size(180, 32);
            btnCityAdd.TabIndex = 4;
            btnCityAdd.Text = "Şehir Ekle";
            btnCityAdd.UseVisualStyleBackColor = true;
            // 
            // btnUrunTuru
            // 
            btnUrunTuru.Location = new Point(49, 493);
            btnUrunTuru.Name = "btnUrunTuru";
            btnUrunTuru.Size = new Size(180, 32);
            btnUrunTuru.TabIndex = 6;
            btnUrunTuru.Text = "Ürün Türü Ekle";
            btnUrunTuru.UseVisualStyleBackColor = true;
            // 
            // HeadLine
            // 
            HeadLine.AutoSize = true;
            HeadLine.Font = new Font("Impact", 30F);
            HeadLine.Location = new Point(283, 9);
            HeadLine.Name = "HeadLine";
            HeadLine.Size = new Size(389, 63);
            HeadLine.TabIndex = 7;
            HeadLine.Text = "Türk Konveksiyon";
            HeadLine.Click += label1_Click;
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.Location = new Point(49, 392);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Size = new Size(180, 32);
            btnEmployeeAdd.TabIndex = 8;
            btnEmployeeAdd.Text = "Personel Ekle";
            btnEmployeeAdd.UseVisualStyleBackColor = true;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Location = new Point(49, 545);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(180, 32);
            btnCustomerAdd.TabIndex = 9;
            btnCustomerAdd.Text = "Müşteri Ekle";
            btnCustomerAdd.UseVisualStyleBackColor = true;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // btnCountyAdd
            // 
            btnCountyAdd.Location = new Point(49, 246);
            btnCountyAdd.Name = "btnCountyAdd";
            btnCountyAdd.Size = new Size(180, 32);
            btnCountyAdd.TabIndex = 10;
            btnCountyAdd.Text = "İlçe Ekle";
            btnCountyAdd.UseVisualStyleBackColor = true;
            // 
            // btnNeigherborHoodAdd
            // 
            btnNeigherborHoodAdd.Location = new Point(49, 197);
            btnNeigherborHoodAdd.Name = "btnNeigherborHoodAdd";
            btnNeigherborHoodAdd.Size = new Size(180, 32);
            btnNeigherborHoodAdd.TabIndex = 11;
            btnNeigherborHoodAdd.Text = "Mahalle Ekle";
            btnNeigherborHoodAdd.UseVisualStyleBackColor = true;
            // 
            // LabelAdd
            // 
            LabelAdd.AutoSize = true;
            LabelAdd.Font = new Font("Impact", 20F);
            LabelAdd.Location = new Point(49, 140);
            LabelAdd.Name = "LabelAdd";
            LabelAdd.Size = new Size(117, 42);
            LabelAdd.TabIndex = 12;
            LabelAdd.Text = "Ekleme";
            LabelAdd.Click += label1_Click_1;
            // 
            // LabelList
            // 
            LabelList.AutoSize = true;
            LabelList.Font = new Font("Impact", 20F);
            LabelList.Location = new Point(381, 140);
            LabelList.Name = "LabelList";
            LabelList.Size = new Size(152, 42);
            LabelList.TabIndex = 13;
            LabelList.Text = "Listeleme";
            LabelList.Click += label1_Click_2;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(546, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(693, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F);
            label1.Location = new Point(42, 49);
            label1.Name = "label1";
            label1.Size = new Size(152, 42);
            label1.TabIndex = 16;
            label1.Text = "Listeleme";
            // 
            // button4
            // 
            button4.Location = new Point(573, 383);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 17;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 671);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(LabelList);
            Controls.Add(LabelAdd);
            Controls.Add(btnNeigherborHoodAdd);
            Controls.Add(btnCountyAdd);
            Controls.Add(btnCustomerAdd);
            Controls.Add(btnEmployeeAdd);
            Controls.Add(HeadLine);
            Controls.Add(btnUrunTuru);
            Controls.Add(btnCityAdd);
            Controls.Add(btnUrunEkle);
            Controls.Add(button2);
            Name = "FormHome";
            Text = "Türk Konveksiyon";
            Load += FormHome_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // Eksik kodu ekleyin veya gerekirse mevcut kodu kontrol edin
           
        }
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

      


        private void label1_Click_2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button btnUrunEkle;
        private Button btnCityAdd;
        private TextBox textBox1;
        private Button btnUrunTuru;
        private Label HeadLine;
        private Button btnEmployeeAdd;
        private Button btnCustomerAdd;
        private Button btnCountyAdd;
        private Button btnNeigherborHoodAdd;
        private Label LabelAdd;
        private Label LabelList;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
       
        private Button button4;
    }
}
