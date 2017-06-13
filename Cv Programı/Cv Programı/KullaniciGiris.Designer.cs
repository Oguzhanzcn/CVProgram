namespace Cv_Programı
{
    partial class KullaniciGiris
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
            this.Label1 = new System.Windows.Forms.Label();
            this.adminkadiTB = new System.Windows.Forms.TextBox();
            this.adminkadilabel = new System.Windows.Forms.Label();
            this.admingirisconfirmbutton = new System.Windows.Forms.Button();
            this.admingirisbackbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Gold;
            this.Label1.Location = new System.Drawing.Point(11, 78);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 17);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Şifre:";
            // 
            // adminkadiTB
            // 
            this.adminkadiTB.Location = new System.Drawing.Point(11, 48);
            this.adminkadiTB.Margin = new System.Windows.Forms.Padding(2);
            this.adminkadiTB.MaxLength = 11;
            this.adminkadiTB.Name = "adminkadiTB";
            this.adminkadiTB.Size = new System.Drawing.Size(240, 20);
            this.adminkadiTB.TabIndex = 1;
            this.adminkadiTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminkadiTB_KeyPress);
            // 
            // adminkadilabel
            // 
            this.adminkadilabel.AutoSize = true;
            this.adminkadilabel.BackColor = System.Drawing.Color.Transparent;
            this.adminkadilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminkadilabel.ForeColor = System.Drawing.Color.Gold;
            this.adminkadilabel.Location = new System.Drawing.Point(11, 22);
            this.adminkadilabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminkadilabel.Name = "adminkadilabel";
            this.adminkadilabel.Size = new System.Drawing.Size(102, 17);
            this.adminkadilabel.TabIndex = 14;
            this.adminkadilabel.Text = "Kullanıcı Adı:";
            // 
            // admingirisconfirmbutton
            // 
            this.admingirisconfirmbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.admingirisconfirmbutton.FlatAppearance.BorderSize = 3;
            this.admingirisconfirmbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admingirisconfirmbutton.Location = new System.Drawing.Point(11, 135);
            this.admingirisconfirmbutton.Margin = new System.Windows.Forms.Padding(2);
            this.admingirisconfirmbutton.Name = "admingirisconfirmbutton";
            this.admingirisconfirmbutton.Size = new System.Drawing.Size(104, 28);
            this.admingirisconfirmbutton.TabIndex = 3;
            this.admingirisconfirmbutton.Text = "Giriş";
            this.admingirisconfirmbutton.UseVisualStyleBackColor = true;
            this.admingirisconfirmbutton.Click += new System.EventHandler(this.admingirisconfirmbutton_Click);
            // 
            // admingirisbackbutton
            // 
            this.admingirisbackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admingirisbackbutton.Location = new System.Drawing.Point(137, 135);
            this.admingirisbackbutton.Margin = new System.Windows.Forms.Padding(2);
            this.admingirisbackbutton.Name = "admingirisbackbutton";
            this.admingirisbackbutton.Size = new System.Drawing.Size(116, 28);
            this.admingirisbackbutton.TabIndex = 4;
            this.admingirisbackbutton.Text = "Kapat";
            this.admingirisbackbutton.UseVisualStyleBackColor = true;
            this.admingirisbackbutton.Click += new System.EventHandler(this.admingirisbackbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(-2, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 60);
            this.label3.TabIndex = 16;
            this.label3.Text = "Not: Kullanıcı adı ve şifreniz \r\nTC kimlik numarınız ve telefonunuzdan olışmaktad" +
    "ır. \r\nTC kimlik numarası kullanıcı adı \r\nşifre ise telefon numaranızdır.";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(11, 98);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(239, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.adminkadiTB);
            this.Controls.Add(this.adminkadilabel);
            this.Controls.Add(this.admingirisconfirmbutton);
            this.Controls.Add(this.admingirisbackbutton);
            this.Name = "KullaniciGiris";
            this.Text = "KullaniciGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox adminkadiTB;
        internal System.Windows.Forms.Label adminkadilabel;
        internal System.Windows.Forms.Button admingirisconfirmbutton;
        internal System.Windows.Forms.Button admingirisbackbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}