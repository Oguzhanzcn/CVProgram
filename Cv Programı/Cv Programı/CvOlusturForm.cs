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


namespace Cv_Programı
{
    public partial class CvOlustur : Form
    {
        public CvOlustur()
        {
            InitializeComponent();
        }
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;userid=root;database=CvOlusturma");

        //MySql.Data.MySqlClient.MySqlConnection vbConn;
        //string myConnectionString;
        //MySqlConnection vbConn;
        //MySqlCommand vbCommand; 

       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && maskedTextBox1.Text != "" )
                {
                    mysqlbaglan.Open();
                    MySqlCommand comm = mysqlbaglan.CreateCommand();
                    //string tarih = dateTimePicker1.Value.Date.ToString("yyyy");
                    //TimeSpan age = DateTime.Now - dateTimePicker1.Value;
               
                    int years = DateTime.Now.Year - dateTimePicker1.Value.Year;// zamanı takvimden alıp yaşa dönüştürmek için kullanıldı.
                    if (dateTimePicker1.Value > DateTime.Now)
                    {
                        MessageBox.Show("Lütfen geçerli bir tarih giriniz!",
                            "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        AskerTB.Text = "";
                        EhliyetTB.Text = "";
                        MedeniTB.Text = "";
                        BasvuruTB.Text = "";
                        DogumYerTB.Text = "";
                        MailTB.Text = "";
                        liseTB.Text = "";
                        uniTB.Text = "";
                        uniNotTB.Text = "";
                        liseNotTB.Text = "";
                        uniBolumTB.Text = "";
                        dilTB.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        maskedTextBox1.Text = "";
                        BasvuruTB.Text = "";
                        comboBox1.SelectedItem = -1;
                    }
                    else
                    {
                        comm.CommandText = "INSERT INTO cvbilgileri(tckno, ad, soyad, telNo, calismaDurumu, yas,dogumYeriUyrugu,AskerlikDurum,Ehliyet,email,medeniDurum,basvurulanAlan,lise,universite,uniNot,liseNot,uniBolum,yabanciDil) VALUES(@tckno, @ad, @soyad, @telNo, @calismaDurumu, @yas,@dogumYeriUyrugu,@Askerlikdurum,@Ehliyet,@email,@medeniDurum,@basvurulanAlan,@lise,@universite,@uniNot,@liseNot,@uniBolum,@yabanciDil)";
                        comm.Parameters.Add("@tckno", textBox1.Text);
                        comm.Parameters.Add("@ad", textBox3.Text);
                        comm.Parameters.Add("@soyad", textBox4.Text);
                        comm.Parameters.Add("@telNo", maskedTextBox1.Text);
                        comm.Parameters.Add("@calismaDurumu", comboBox1.Text);
                        comm.Parameters.Add("@yas", years);
                        comm.Parameters.Add("@dogumYeriUyrugu", DogumYerTB.Text);
                        comm.Parameters.Add("@Askerlikdurum", AskerTB.Text);
                        comm.Parameters.Add("@Ehliyet", EhliyetTB.Text);
                        comm.Parameters.Add("@email", MailTB.Text);
                        comm.Parameters.Add("@medeniDurum", MedeniTB.Text);
                        comm.Parameters.Add("@basvurulanAlan", BasvuruTB.Text);
                        comm.Parameters.Add("@lise", liseTB.Text);
                        comm.Parameters.Add("@universite", uniTB.Text);
                        comm.Parameters.Add("@uniNot", uniNotTB.Text);
                        comm.Parameters.Add("@liseNot", liseNotTB.Text);
                        comm.Parameters.Add("@uniBolum", uniBolumTB.Text);
                        comm.Parameters.Add("@yabanciDil", dilTB.Text);
                        comm.ExecuteNonQuery();
                        mysqlbaglan.Close();
                        mysqlbaglan.Dispose();
                        MessageBox.Show("Başarıyla eklendi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        liseTB.Text = "";
                        uniTB.Text = "";
                        uniNotTB.Text = "";
                        liseNotTB.Text = "";
                        uniBolumTB.Text = "";
                        dilTB.Text = "";
                        AskerTB.Text = "";
                        EhliyetTB.Text = "";
                        MedeniTB.Text = "";
                        BasvuruTB.Text = "";
                        DogumYerTB.Text = "";
                        MailTB.Text = "";
                        BasvuruTB.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        maskedTextBox1.Text = "";
                        comboBox1.SelectedItem = -1;
                    }

                }
                else
                {
                    MessageBox.Show("Boş alan bırakmayınız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//boş alan varsa kontrol et
                }
           }
            catch(Exception err)
            {
            MessageBox.Show("Hata! "+ err.Message,"Hata Oluştu!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            mysqlbaglan.Close();
            mysqlbaglan.Dispose();
            }
            }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayı giriş kontrolü
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (Convert.ToDouble(textBox1.Text) <= 10000000000)//Tckimlik numarası 11 rakamdan azlık kontrolu
                 {
                MessageBox.Show("Lütfen geçerli bir TC kimlik no giriniz!", "Hata!");
                textBox1.Clear();
                 }
                else//normalse her şey veritabanında olup olmadıgını kontrol ediyor tcnin. Varsa siliyor leave eventinda.
                {
                    string kontrol;
                    try
                    {
                        mysqlbaglan.Open();
                        MySqlCommand comm = mysqlbaglan.CreateCommand();

                comm.CommandText = ("SELECT tckno from cvbilgileri");
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {

                    kontrol = reader["tckno"].ToString();
                    if (kontrol == textBox1.Text)
                    {
                        MessageBox.Show("Aynı TC no ile cv oluşturulamaz!", "Hata!");
                        textBox1.Clear();
                    }
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
           } 
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//sadece harf giriş kontrolü
                 && !char.IsSeparator(e.KeyChar);
        }

 

       
        }
    }
