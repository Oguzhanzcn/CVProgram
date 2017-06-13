namespace Cv_Programı
{
    partial class CvOlustur
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
            this.tckNo = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.dogumTarih = new System.Windows.Forms.Label();
            this.tlfnNo = new System.Windows.Forms.Label();
            this.calismaDurum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AskerTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EhliyetTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MedeniTB = new System.Windows.Forms.TextBox();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.BasvuruTB = new System.Windows.Forms.TextBox();
            this.DogumYerTB = new System.Windows.Forms.TextBox();
            this.uniTB = new System.Windows.Forms.TextBox();
            this.liseTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uniBolumTB = new System.Windows.Forms.TextBox();
            this.uniNotTB = new System.Windows.Forms.TextBox();
            this.liseNotTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dilTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tckNo
            // 
            this.tckNo.AutoSize = true;
            this.tckNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tckNo.Location = new System.Drawing.Point(34, 44);
            this.tckNo.Name = "tckNo";
            this.tckNo.Size = new System.Drawing.Size(133, 19);
            this.tckNo.TabIndex = 0;
            this.tckNo.Text = "TC Kimlik Numarası";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.ad.Location = new System.Drawing.Point(34, 109);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(27, 19);
            this.ad.TabIndex = 1;
            this.ad.Text = "Ad";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.soyad.Location = new System.Drawing.Point(34, 172);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(50, 19);
            this.soyad.TabIndex = 2;
            this.soyad.Text = "Soyad";
            // 
            // dogumTarih
            // 
            this.dogumTarih.AutoSize = true;
            this.dogumTarih.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogumTarih.Location = new System.Drawing.Point(34, 235);
            this.dogumTarih.Name = "dogumTarih";
            this.dogumTarih.Size = new System.Drawing.Size(93, 19);
            this.dogumTarih.TabIndex = 3;
            this.dogumTarih.Text = "Doğum Tarihi";
            // 
            // tlfnNo
            // 
            this.tlfnNo.AutoSize = true;
            this.tlfnNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.tlfnNo.Location = new System.Drawing.Point(34, 298);
            this.tlfnNo.Name = "tlfnNo";
            this.tlfnNo.Size = new System.Drawing.Size(121, 19);
            this.tlfnNo.TabIndex = 4;
            this.tlfnNo.Text = "Telefon Numarası";
            // 
            // calismaDurum
            // 
            this.calismaDurum.AutoSize = true;
            this.calismaDurum.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.calismaDurum.Location = new System.Drawing.Point(34, 361);
            this.calismaDurum.Name = "calismaDurum";
            this.calismaDurum.Size = new System.Drawing.Size(132, 19);
            this.calismaDurum.TabIndex = 5;
            this.calismaDurum.Text = "Çalışıyor musunuz ?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 43);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 108);
            this.textBox3.MaxLength = 28;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(173, 171);
            this.textBox4.MaxLength = 28;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EVET",
            "HAYIR"});
            this.comboBox1.Location = new System.Drawing.Point(172, 359);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(360, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(533, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 42);
            this.button3.TabIndex = 18;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(173, 296);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(191, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(393, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Başvurulan Alan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(393, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Doğum Yeri/Uyruğu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(393, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Askerlik Durumu";
            // 
            // AskerTB
            // 
            this.AskerTB.Location = new System.Drawing.Point(530, 106);
            this.AskerTB.MaxLength = 20;
            this.AskerTB.Name = "AskerTB";
            this.AskerTB.Size = new System.Drawing.Size(148, 20);
            this.AskerTB.TabIndex = 6;
            this.AskerTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(393, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ehliyet(Varsa)";
            // 
            // EhliyetTB
            // 
            this.EhliyetTB.Location = new System.Drawing.Point(530, 173);
            this.EhliyetTB.MaxLength = 10;
            this.EhliyetTB.Name = "EhliyetTB";
            this.EhliyetTB.Size = new System.Drawing.Size(148, 20);
            this.EhliyetTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(393, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "E-Mail Adresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(393, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Medeni Durum";
            // 
            // MedeniTB
            // 
            this.MedeniTB.Location = new System.Drawing.Point(530, 301);
            this.MedeniTB.MaxLength = 10;
            this.MedeniTB.Name = "MedeniTB";
            this.MedeniTB.Size = new System.Drawing.Size(148, 20);
            this.MedeniTB.TabIndex = 9;
            this.MedeniTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(530, 234);
            this.MailTB.MaxLength = 30;
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(148, 20);
            this.MailTB.TabIndex = 8;
            // 
            // BasvuruTB
            // 
            this.BasvuruTB.Location = new System.Drawing.Point(530, 359);
            this.BasvuruTB.MaxLength = 70;
            this.BasvuruTB.Name = "BasvuruTB";
            this.BasvuruTB.Size = new System.Drawing.Size(148, 20);
            this.BasvuruTB.TabIndex = 10;
            // 
            // DogumYerTB
            // 
            this.DogumYerTB.Location = new System.Drawing.Point(530, 45);
            this.DogumYerTB.MaxLength = 50;
            this.DogumYerTB.Name = "DogumYerTB";
            this.DogumYerTB.Size = new System.Drawing.Size(148, 20);
            this.DogumYerTB.TabIndex = 5;
            // 
            // uniTB
            // 
            this.uniTB.Location = new System.Drawing.Point(875, 108);
            this.uniTB.MaxLength = 28;
            this.uniTB.Name = "uniTB";
            this.uniTB.Size = new System.Drawing.Size(191, 20);
            this.uniTB.TabIndex = 12;
            // 
            // liseTB
            // 
            this.liseTB.Location = new System.Drawing.Point(875, 45);
            this.liseTB.MaxLength = 28;
            this.liseTB.Name = "liseTB";
            this.liseTB.Size = new System.Drawing.Size(191, 20);
            this.liseTB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(723, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 64;
            this.label7.Text = "Üniversite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(723, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "Lise";
            // 
            // uniBolumTB
            // 
            this.uniBolumTB.Location = new System.Drawing.Point(875, 298);
            this.uniBolumTB.MaxLength = 28;
            this.uniBolumTB.Name = "uniBolumTB";
            this.uniBolumTB.Size = new System.Drawing.Size(191, 20);
            this.uniBolumTB.TabIndex = 15;
            // 
            // uniNotTB
            // 
            this.uniNotTB.Location = new System.Drawing.Point(875, 234);
            this.uniNotTB.MaxLength = 28;
            this.uniNotTB.Name = "uniNotTB";
            this.uniNotTB.Size = new System.Drawing.Size(191, 20);
            this.uniNotTB.TabIndex = 14;
            // 
            // liseNotTB
            // 
            this.liseNotTB.Location = new System.Drawing.Point(875, 169);
            this.liseNotTB.MaxLength = 11;
            this.liseNotTB.Name = "liseNotTB";
            this.liseNotTB.Size = new System.Drawing.Size(191, 20);
            this.liseNotTB.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(723, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 70;
            this.label10.Text = "Üniversite Bölüm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(723, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 19);
            this.label11.TabIndex = 69;
            this.label11.Text = "Üniversite Not Ort.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(723, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 68;
            this.label12.Text = "Lise Not Ort.";
            // 
            // dilTB
            // 
            this.dilTB.Location = new System.Drawing.Point(875, 357);
            this.dilTB.MaxLength = 28;
            this.dilTB.Name = "dilTB";
            this.dilTB.Size = new System.Drawing.Size(191, 20);
            this.dilTB.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(723, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 57);
            this.label9.TabIndex = 74;
            this.label9.Text = "Yabancı Diller \r\nve \r\nDüzeyi";
            // 
            // CvOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 462);
            this.Controls.Add(this.dilTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uniBolumTB);
            this.Controls.Add(this.uniNotTB);
            this.Controls.Add(this.liseNotTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.uniTB);
            this.Controls.Add(this.liseTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DogumYerTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BasvuruTB);
            this.Controls.Add(this.MailTB);
            this.Controls.Add(this.MedeniTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EhliyetTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AskerTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calismaDurum);
            this.Controls.Add(this.tlfnNo);
            this.Controls.Add(this.dogumTarih);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.tckNo);
            this.Name = "CvOlustur";
            this.Text = "Cv Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tckNo;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label dogumTarih;
        private System.Windows.Forms.Label tlfnNo;
        private System.Windows.Forms.Label calismaDurum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AskerTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EhliyetTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MedeniTB;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.TextBox BasvuruTB;
        private System.Windows.Forms.TextBox DogumYerTB;
        private System.Windows.Forms.TextBox uniTB;
        private System.Windows.Forms.TextBox liseTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uniBolumTB;
        private System.Windows.Forms.TextBox uniNotTB;
        private System.Windows.Forms.TextBox liseNotTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dilTB;
        private System.Windows.Forms.Label label9;
    }
}