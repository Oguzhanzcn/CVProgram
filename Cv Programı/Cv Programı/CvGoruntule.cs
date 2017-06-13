using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace Cv_Programı
{
    public partial class CvGoruntule : Form
    {
       
        Form1 anaform = new Form1();//form1 den nesne oluştu
        public CvGoruntule(Form1 anaf)//cvgoruntule constructorını form1 deki cvdialoga atadık
        {
            InitializeComponent();
            anaform = anaf;
        }

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;userid=root;database=CvOlusturma");
        private void geriBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public static string deneme;
        private void CvGoruntule_Load(object sender, EventArgs e)
        {
        
            goruntule(deneme);
        }

        private void guncelBtn_Click(object sender, EventArgs e)
        {
            try
            {



                string Query = "update cvbilgileri set tckno='" + textBox1.Text + "',ad='" + textBox2.Text + "',soyad='" + textBox3.Text +
                    "',yas='" + textBox4.Text + "',telNo='" + textBox6.Text + "',calismaDurumu='" + comboBox1.Text + "',dogumYeriUyrugu='" + DogumYerTB.Text + "',Askerlikdurum='" + AskerTB.Text + "',Ehliyet='" + EhliyetTB.Text + "',email='" + MailTB.Text +
                    "',medeniDurum='" + MedeniTB.Text + "',basvurulanAlan='" + BasvuruTB.Text + "',lise='" + liseTB.Text + "',universite='" + uniTB.Text + "',uniNot='" + uniNotTB.Text + "',liseNot='" + liseNotTB.Text + "',uniBolum='" + uniBolumTB.Text + "',yabanciDil='" + dilTB.Text + "';";

                //Veritabanı baglantısı ve degerleri güncelleme
                MySqlCommand MyCommand2 = new MySqlCommand(Query, mysqlbaglan);
                MySqlDataReader MyReader2;
                mysqlbaglan.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Başarıyla Güncellendi!", "Başarılı!");
                while (MyReader2.Read())
                {
                }
                AskerTB.Text = "";
                EhliyetTB.Text = "";
                MedeniTB.Text = "";
                BasvuruTB.Text = "";
                DogumYerTB.Text = "";
                MailTB.Text = "";
                BasvuruTB.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                liseTB.Text = "";
                uniTB.Text = "";
                uniNotTB.Text = "";
                liseNotTB.Text = "";
                uniBolumTB.Text = "";
                dilTB.Text = "";
                mysqlbaglan.Close();//Connection closed here  
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mysqlbaglan.Close();
                mysqlbaglan.Dispose();
            }
        }
        public void goruntule(string x)//Kullanıcı girisindeki tcye göre veri ceken fonk.
        //
        {
            try
            {
                mysqlbaglan.Open();
                MySqlCommand comm = mysqlbaglan.CreateCommand();
                
                comm.CommandText = ("SELECT * from cvbilgileri where tckno='" + x + "'");
                MySqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())//okurken verileri textbox lara atıyor.
                    {

                        textBox1.Text = reader["tckno"].ToString();
                        textBox2.Text = reader["ad"].ToString();
                        textBox3.Text = reader["soyad"].ToString();
                        textBox4.Text = reader["yas"].ToString();
                        textBox6.Text = reader["telNo"].ToString();
                        comboBox1.Text = reader["calismaDurumu"].ToString();
                        DogumYerTB.Text = reader["dogumYeriUyrugu"].ToString();
                        AskerTB.Text = reader["Askerlikdurum"].ToString();
                        EhliyetTB.Text = reader["Ehliyet"].ToString();
                        MailTB.Text = reader["email"].ToString();
                        MedeniTB.Text = reader["medeniDurum"].ToString();
                        BasvuruTB.Text = reader["basvurulanAlan"].ToString();
                        liseTB.Text = reader["lise"].ToString();
                        uniTB.Text = reader["universite"].ToString();
                        uniNotTB.Text = reader["uniNot"].ToString();
                        liseNotTB.Text = reader["liseNot"].ToString();
                        uniBolumTB.Text = reader["uniBolum"].ToString();
                        dilTB.Text = reader["yabanciDil"].ToString();
                    }
                
                
                mysqlbaglan.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mysqlbaglan.Close();
                mysqlbaglan.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mysqlbaglan.Open();
                MySqlCommand comm = mysqlbaglan.CreateCommand();
                comm.CommandText = ("Delete from cvbilgileri where tckno='" + deneme + "'");//girilen TC ye göre silme işlemi
                if (comm.ExecuteNonQuery() == 1)
                        {
                            
                            MessageBox.Show("Silindi… Ekran Kapatılıyor..");
                            anaform.kullaniciTur("misafir");
                            this.Close();
                            
                            
                            
                            
                        }
                        else
                        {   
                            MessageBox.Show("Hata.. Kullanici Silinemedi..");
                        }


                mysqlbaglan.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mysqlbaglan.Close();
                mysqlbaglan.Dispose();
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yzdrBtn_Click(object sender, EventArgs e)//yazdırma butonu
        {
            ppdDialog.ShowDialog();
        }
        Font baslik = new Font("Verdana", 12, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void pdYazici_PrintPage(object sender, PrintPageEventArgs e)//yazdırma oluşturucu
        {
            if (textBox2.Text != "") { 
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(textBox2.Text + " Kişisinin CV'si", baslik, sb, 300, 150);
            e.Graphics.DrawString("Kişisel Bilgiler", baslik, sb, 70, 250);
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", baslik, sb, 70, 270);
            e.Graphics.DrawString("TC Kimlik No : " + textBox1.Text,baslik,sb,70,300);
            e.Graphics.DrawString("AD : " + textBox2.Text, baslik, sb, 70, 330);
            e.Graphics.DrawString("SOYAD : " + textBox3.Text, baslik, sb, 70, 360);
            e.Graphics.DrawString("Yaş : " + textBox4.Text, baslik, sb, 70, 390);
            e.Graphics.DrawString("Doğum Yeri ve Uyruğu : "+ DogumYerTB.Text, baslik, sb, 70, 420);
            e.Graphics.DrawString("Telefon Numarası : " + textBox6.Text, baslik, sb, 70, 450);
            e.Graphics.DrawString("Email : "+MailTB.Text,baslik,sb,70,480);
            e.Graphics.DrawString("Askerlik Durumu : "+AskerTB.Text,baslik,sb,70,510);
            e.Graphics.DrawString("Ehliyet(Varsa) : "+EhliyetTB.Text,baslik,sb,70,540);
            e.Graphics.DrawString("Medeni Durum : "+MedeniTB.Text,baslik,sb,70,570);
            e.Graphics.DrawString("Basvurulan Alan(lar) : "+BasvuruTB.Text,baslik,sb,70,600);
            e.Graphics.DrawString("Çalışıyor mu? : " + comboBox1.Text, baslik, sb, 70, 630);
            e.Graphics.DrawString("Öğrenim Bilgileri", baslik, sb, 70, 700);
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", baslik, sb, 70, 720);
            e.Graphics.DrawString("Lise : " + liseTB.Text, baslik, sb, 70, 750);
            e.Graphics.DrawString("Lise Not Ortalaması : " + liseNotTB.Text, baslik, sb, 70, 780);
            e.Graphics.DrawString("Üniversite : " + uniTB.Text, baslik, sb, 70, 810);
            e.Graphics.DrawString("Üniversite Not Ortalaması : " + uniNotTB.Text, baslik, sb, 70, 840);
            e.Graphics.DrawString("Üniversite Bölüm : " + uniBolumTB.Text, baslik, sb, 70, 870);
            e.Graphics.DrawString("Yabancı Diller ve Seviyeler : " +dilTB.Text, baslik, sb, 70, 900);

            e.Graphics.DrawString("FOTOĞRAF", baslik, sb, 700, 100);
            }
            else
            {
                MessageBox.Show("Yazdıralacak değerler bulunmamakta!", "Hata!");
                this.Close();
            }
            
        }

    }

}