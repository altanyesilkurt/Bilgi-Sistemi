namespace WindowsFormsApplication1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirmaAdı = new System.Windows.Forms.TextBox();
            this.Çalışan = new System.Windows.Forms.TextBox();
            this.Hekim = new System.Windows.Forms.TextBox();
            this.Ücret = new System.Windows.Forms.TextBox();
            this.Uzman = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Etkinlik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KAYIT TARİHİ :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FİRMA ADI :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TALEP EDİLEN ÜCRET :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÇALIŞAN SAYİSİ :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ATANAN HEKİM SAYİSİ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ATANAN GÜVENLİK UZMANI SAYİSİ :";
            // 
            // FirmaAdı
            // 
            this.FirmaAdı.Location = new System.Drawing.Point(294, 92);
            this.FirmaAdı.Name = "FirmaAdı";
            this.FirmaAdı.Size = new System.Drawing.Size(138, 20);
            this.FirmaAdı.TabIndex = 6;
            // 
            // Çalışan
            // 
            this.Çalışan.Location = new System.Drawing.Point(294, 144);
            this.Çalışan.Name = "Çalışan";
            this.Çalışan.Size = new System.Drawing.Size(138, 20);
            this.Çalışan.TabIndex = 7;
            // 
            // Hekim
            // 
            this.Hekim.Location = new System.Drawing.Point(294, 222);
            this.Hekim.Name = "Hekim";
            this.Hekim.Size = new System.Drawing.Size(138, 20);
            this.Hekim.TabIndex = 8;
            // 
            // Ücret
            // 
            this.Ücret.Location = new System.Drawing.Point(294, 183);
            this.Ücret.Name = "Ücret";
            this.Ücret.Size = new System.Drawing.Size(138, 20);
            this.Ücret.TabIndex = 9;
            // 
            // Uzman
            // 
            this.Uzman.Location = new System.Drawing.Point(294, 255);
            this.Uzman.Name = "Uzman";
            this.Uzman.Size = new System.Drawing.Size(138, 20);
            this.Uzman.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(167, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(778, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 76);
            this.button3.TabIndex = 14;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(930, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 76);
            this.button4.TabIndex = 15;
            this.button4.Text = "ANA SAYFA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(294, 54);
            this.date.MaxDate = new System.DateTime(2017, 5, 16, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(2017, 5, 16, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 16;
            this.date.Value = new System.DateTime(2017, 5, 16, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ADRES:";
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(294, 302);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(476, 20);
            this.Adres.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 49);
            this.button2.TabIndex = 21;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Etkinlik
            // 
            this.Etkinlik.AutoSize = true;
            this.Etkinlik.Location = new System.Drawing.Point(170, 125);
            this.Etkinlik.Name = "Etkinlik";
            this.Etkinlik.Size = new System.Drawing.Size(71, 13);
            this.Etkinlik.TabIndex = 22;
            this.Etkinlik.Text = "ETKİNLİK :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 20);
            this.textBox1.TabIndex = 23;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 592);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Etkinlik);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Uzman);
            this.Controls.Add(this.Ücret);
            this.Controls.Add(this.Hekim);
            this.Controls.Add(this.Çalışan);
            this.Controls.Add(this.FirmaAdı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form3";
            this.Text = "FİRMA KAYDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FirmaAdı;
        private System.Windows.Forms.TextBox Çalışan;
        private System.Windows.Forms.TextBox Hekim;
        private System.Windows.Forms.TextBox Ücret;
        private System.Windows.Forms.TextBox Uzman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Etkinlik;
        private System.Windows.Forms.TextBox textBox1;
    }
}