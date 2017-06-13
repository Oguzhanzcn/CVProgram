using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cv_Programı
{
    public partial class Form1 : Form
    {
        

               public bool adminyetki = false;
       public string cnstr = "Server=localhost;userid=root;database=CvOlusturma";
        public Form1()
        {
            InitializeComponent();
            kullaniciTur("misafir");
        }
        
        public string tckno;
   
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)//normal boyuttaysa maximum,max ise normal boyuta geçirir
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)//alta göndermek için
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected override void WndProc(ref Message e)//base.wndproc(ref e); ye kadar olan kısım hareket ettirmek için.
        {
            switch(e.Msg)
            {
                case 0x84:
                    base.WndProc(ref e);
                    if ((int)e.Result == 0x1)
                        e.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref e);
        }

              private void CvOlustur_Click(object sender, EventArgs e)
        {

            CvOlustur dialog2 = new CvOlustur();
            this.Hide();
            dialog2.ShowDialog();
            this.Show();
            
        }

              private void button1_Click(object sender, EventArgs e)
              {
                  CvGoruntule dialog = new CvGoruntule(this);
                  this.Hide();
                  dialog.ShowDialog();
                  this.Show();
              }

              private void button2_Click(object sender, EventArgs e)
              {
                  KullaniciGiris dialog3 = new KullaniciGiris();
                  this.Hide();
                  dialog3.ShowDialog();
                  
                  
              }
             
             public void kullaniciTur(string yetki)//kullanıcı türünü belirleme ve görünecek butonlar vb. ayarı
              {
                  if (yetki == "misafir") {
                      adminyetki = false;
                      CvGoruntule.Visible = false;
                      CvOlustur.Location = new Point(274, 177);
                      label2.Visible = false;
                      label1.Visible = false;
                      kullaniciGiris.Visible = true;
                  }
                  else if (yetki == "kayitli")
                  {
                      adminyetki = true;
                      label2.Visible = true;
                      kullaniciGiris.Visible = false;
                      CvGoruntule.Visible = true;
                      CvOlustur.Location = new Point(142, 177);
                      label2.Text =tckno;
                      label1.Visible = true;
                      //this.Show();
                      
                  }
              }

             private void Form1_Load(object sender, EventArgs e)
             {
                 
             }
             
    }
}
