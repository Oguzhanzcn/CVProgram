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
    public partial class KullaniciGiris : Form
    {
        Form1 anaform = new Form1();
        
        
        public string tckno;
        string telNo;
        public KullaniciGiris()
        {
            InitializeComponent();
        }
       
        private void admingirisbackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            anaform.Show();
        }
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;userid=root;database=CvOlusturma");
        private void admingirisconfirmbutton_Click(object sender, EventArgs e)
        {
            if (adminkadiTB.Text == "" || maskedTextBox1.Text == "")//boş alan kontrolü
            {
            MessageBox.Show("Boş alan bırakmayınız","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
             else
                 try{
            mysqlbaglan.Open();
            MySqlCommand comm = mysqlbaglan.CreateCommand();
            comm.CommandText = "SELECT tckno,telNo from cvbilgileri";
            MySqlDataReader reader = comm.ExecuteReader();
                while(reader.Read()){
                    tckno = reader["tckno"].ToString();
                    telNo = reader["telNo"].ToString();
                    if ((adminkadiTB.Text == tckno) && (maskedTextBox1.Text == telNo))
                    {
                        anaform.tckno = tckno;
                        CvGoruntule.deneme = tckno;
                        anaform.kullaniciTur("kayitli");
                        MessageBox.Show("Başarılı Giriş", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        anaform.Show();
                        break;
                       // reader.Dispose();
                        //goto escape;
                        }
                }
                reader.Dispose();
// escape:               
                if ((adminkadiTB.Text != tckno) || (maskedTextBox1.Text != telNo))
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    adminkadiTB.Clear();
                    maskedTextBox1.Clear();
                }
                
                mysqlbaglan.Close();
                 }
             catch(Exception err)
            {
            MessageBox.Show("Hata! "+ err.Message,"Hata Oluştu!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            mysqlbaglan.Close();
            mysqlbaglan.Dispose();
            }
        
        
    }

        private void adminkadiTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayı giriş kontrolü

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayı giriş kontrolü

        }


        
    }
}
