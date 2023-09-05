using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PersonelGirisButon_Click(object sender, EventArgs e)
        {
            string gelenad = AdGiris.Text;
            string gelensifre=SifreGiris.Text;

            if (gelenad.Equals("222203572") && gelensifre.Equals("4293319"))
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!! ");
            }
        }
    }
}
