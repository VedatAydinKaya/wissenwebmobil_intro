using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdresDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kisi kisi = new Kisi();  // instance alındı

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                kisi.Ad = "Kamil";
                kisi.Soyad = "hayriye";

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bir hata olustu: {ex.Message} ");
            }

          //  MessageBox.Show($" {kisi.Ad} {kisi.Soyad} ");



        }

      
    }
}
