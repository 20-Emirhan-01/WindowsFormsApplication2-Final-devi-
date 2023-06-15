using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
            frm1.combo2();
            textBox1.DataBindings.Add("Text", frm1.dtst, "musbilg.Tckimlik");
            textBox2.DataBindings.Add("Text", frm1.dtst, "musbilg.Ad");
            textBox3.DataBindings.Add("Text", frm1.dtst, "musbilg.Soyad");
            textBox4.DataBindings.Add("Text", frm1.dtst, "musbilg.Ceptel");
            textBox5.DataBindings.Add("Text", frm1.dtst, "musbilg.Saat");
            textBox6.DataBindings.Add("Text", frm1.dtst, "musbilg.Sehir");
            comboBox1.DataBindings.Add("Text", frm1.dtst, "musbilg.Koltuk");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    frm1.sahasil();
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "DELETE from musbilg WHERE TcKimlik='" + textBox1.Text + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.CommandText = "INSERT INTO bos(boskoltuk) VALUES ('" + comboBox1.Text + "') ";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.CommandText = "DELETE from dolu WHERE dolukoltuk='" + comboBox1.Text + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    comboBox1.Items.Clear();
                    frm1.comboBox8.Items.Clear();
                    comboBox1.Text = "";
                    frm1.combo();
                    frm1.combo2();
                    frm1.dtst.Clear();
                    frm1.listele();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }
    }
}
