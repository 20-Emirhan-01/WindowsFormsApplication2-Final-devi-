using WindowsFormsApplication1.Model;
using WindowsFormsApplication1.Nhibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form2_Load(object sender, EventArgs e)
        {
           frm1.sahayaz();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            frm1.Show();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lokasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uçakToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void button123_Click(object sender, EventArgs e)
        {
            private void button124_Click(object sender, EventArgs e)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;

                DialogResult result;

                result = MessageBox.Show("Bu işlemi onaylıyormusunuz", "Onay!", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    textBox1.Text = "Onaylandı";
                }
                else if (result == DialogResult.Cancel)
                {
                    textBox1.Text = "İptal edildi";
                }
                else
                {
                    textBox1.Text = "Onaylanmadı";
                }
            }

            private void button123_Click(object sender, EventArgs e)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Formu Kapatmak İstiyormusunuz?", "Onay!", buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    textBox1.Text = "Kapatma İşlem İptal edildi";
                }
            }

          /* private void button123_Click(object sender, EventArgs e)
            {
                //printDialog1.AllowSomePages = true;
                printDialog1.AllowCurrentPage = true;
                printDialog1.Document = printDocument1;
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print(); 
                }
            }
          */
            private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                string text = "Koltuk Bilgileri :";
                System.Drawing.Font printHead = new System.Drawing.Font("Arial", 35, System.Drawing.FontStyle.Bold);

                e.Graphics.DrawString(text, printHead,
                    System.Drawing.Brushes.Black, 10, 10);

                // Draw the content.
                var dersler = new List<Model.Ders>();
                using (var session = NhibernateHelper.OpenSession())
                {
                    dersler = session.Query<Model.Ders>().ToList();
                }

                System.Drawing.Font printFont = new System.Drawing.Font("Arial", 25, System.Drawing.FontStyle.Regular);

                var y = 40;
                foreach (var item in dersler)
                {
                    y += 40;
                    e.Graphics.DrawString(item.Icerik, printFont,
                    System.Drawing.Brushes.DarkBlue, 5, y);
                }

            }
        }
    }
}
