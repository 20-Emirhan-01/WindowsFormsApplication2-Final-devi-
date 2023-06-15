using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm2.frm1 = this;
            frm3.frm1 = this;
        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=vt1.accdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();

        public void combo()
        {
            comboBox8.Items.Clear();
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from bos";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox8.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
          
        }
        public void combo2()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from dolu";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                frm3.comboBox1.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
           

        }
        public void listele()
        {
            
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From musbilg", bag);
            adtr.Fill(dtst, "musbilg");
            frm3.dataView1.Table = dtst.Tables[0];
            frm3.dataGrid1.DataSource = frm3.dataView1;
            adtr.Dispose();
            bag.Close();

        }
        public void sahayaz()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from musbilg";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                switch (oku[6].ToString())
                {
                    case "1":
                        {
                            frm2.button1.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button1.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "2":
                        {
                            frm2.button2.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button2.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "3":
                        {
                            frm2.button3.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button3.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "4":
                        {
                            frm2.button4.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button4.BackColor = System.Drawing.Color.Red;
                            break;
                        }

                    case "5":
                        {
                            frm2.button5.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button5.BackColor = System.Drawing.Color.Red;
                            break;
                        }

                    case "6":
                        {
                            frm2.button6.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button6.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "7":
                        {
                            frm2.button7.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button7.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "8":
                        {
                            frm2.button8.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button8.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "9":
                        {
                            frm2.button9.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button9.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "10":
                        {
                            frm2.button10.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button10.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "11":
                        {
                            frm2.button11.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button11.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "12":
                        {
                            frm2.button12.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button12.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "13":
                        {
                            frm2.button13.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button13.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "14":
                        {
                            frm2.button14.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button14.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "15":
                        {
                            frm2.button15.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button15.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "16":
                        {
                            frm2.button16.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button16.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "17":
                        {
                            frm2.button17.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button17.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "18":
                        {
                            frm2.button18.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button18.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "19":
                        {
                            frm2.button19.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button19.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "20":
                        {
                            frm2.button20.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button20.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "21":
                        {
                            frm2.button21.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button21.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "22":
                        {
                            frm2.button22.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button22.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "23":
                        {
                            frm2.button23.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button23.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "24":
                        {
                            frm2.button24.Text = oku[1].ToString() + " " + oku[2].ToString(); oku[4].ToString();
                            frm2.button24.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "25":
                        {
                            frm2.button25.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button25.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "26":
                        {
                            frm2.button26.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button26.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "27":
                        {
                            frm2.button27.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button27.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "28":
                        {
                            frm2.button28.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button28.BackColor = System.Drawing.Color.Red;
                            break;
                        }

                    case "29":
                        {
                            frm2.button29.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button29.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "30":
                        {
                            frm2.button30.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button30.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "31":
                        {
                            frm2.button31.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button31.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "32":
                        {
                            frm2.button32.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button32.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "33":
                        {
                            frm2.button33.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button33.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "34":
                        {
                            frm2.button34.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button34.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "35":
                        {
                            frm2.button35.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button35.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "36":
                        {
                            frm2.button36.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button36.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "37":
                        {
                            frm2.button37.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button37.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "38":
                        {
                            frm2.button38.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button38.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "39":
                        {
                            frm2.button39.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button39.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "40":
                        {
                            frm2.button40.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button40.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "41":
                        {
                            frm2.button41.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button6.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "42":
                        {
                            frm2.button42.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button42.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "43":
                        {
                            frm2.button43.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button43.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "44":
                        {
                            frm2.button44.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button44.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "45":
                        {
                            frm2.button45.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button45.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "46":
                        {
                            frm2.button46.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button46.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "47":
                        {
                            frm2.button47.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button47.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "48":
                        {
                            frm2.button48.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button48.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "49":
                        {
                            frm2.button49.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button49.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "50":
                        {
                            frm2.button50.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button50.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "51":
                        {
                            frm2.button51.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button51.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "52":
                        {
                            frm2.button52.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button52.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "53":
                        {
                            frm2.button53.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button53.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "54":
                        {
                            frm2.button54.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button54.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "55":
                        {
                            frm2.button55.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button55.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "56":
                        {
                            frm2.button56.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button56.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "57":
                        {
                            frm2.button57.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button57.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "58":
                        {
                            frm2.button58.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button58.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "59":
                        {
                            frm2.button59.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button59.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "60":
                        {
                            frm2.button60.Text = oku[1].ToString() + " " + oku[2].ToString();
                            frm2.button60.BackColor = System.Drawing.Color.Red;
                            break;
                        }


                }
            }
            bag.Close();
            oku.Dispose();

        }
        public void sahasil()
        {

            switch (comboBox8.Text)
            {
                case "1":
                    {
                        frm2.button1.Text = "1";
                        frm2.button1.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "2":
                    {
                        frm2.button2.Text = "2";
                        frm2.button2.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "3":
                    {
                        frm2.button3.Text = "3";
                        frm2.button3.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "4":
                    {
                        frm2.button4.Text = "4";
                        frm2.button4.BackColor = System.Drawing.Color.Lime;
                        break;
                    }

                case "5":
                    {
                        frm2.button5.Text = "5";
                        frm2.button5.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "6":
                    {
                        frm2.button6.Text = "6";
                        frm2.button6.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "7":
                    {
                        frm2.button7.Text = "7";
                        frm2.button7.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "8":
                    {
                        frm2.button8.Text = "8";
                        frm2.button8.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "9":
                    {
                        frm2.button9.Text = "9";
                        frm2.button9.BackColor = System.Drawing.Color.Lime;
                        break;
                    }

                case "10":
                    {
                        frm2.button10.Text = "10";
                        frm2.button10.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "11":
                    {
                        frm2.button11.Text = "11";
                        frm2.button11.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "12":
                    {
                        frm2.button12.Text = "12";
                        frm2.button12.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "13":
                    {
                        frm2.button13.Text = "13";
                        frm2.button13.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "14":
                    {
                        frm2.button14.Text = "14";
                        frm2.button14.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "15":
                    {
                        frm2.button15.Text = "15";
                        frm2.button15.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "16":
                    {
                        frm2.button16.Text = "16";
                        frm2.button16.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "17":
                    {
                        frm2.button17.Text = "17";
                        frm2.button17.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "18":
                    {
                        frm2.button18.Text = "18";
                        frm2.button18.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "19":
                    {
                        frm2.button19.Text = "19";
                        frm2.button19.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "20":
                    {
                        frm2.button20.Text = "20";
                        frm2.button20.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "21":
                    {
                        frm2.button21.Text = "21";
                        frm2.button21.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "22":
                    {
                        frm2.button22.Text = "22";
                        frm2.button22.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "23":
                    {
                        frm2.button23.Text = "23";
                        frm2.button23.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "24":
                    {
                        frm2.button24.Text = "24";
                        frm2.button24.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "25":
                    {
                        frm2.button25.Text = "25";
                        frm2.button25.BackColor = System.Drawing.Color.Lime;
                        break;

                    }
                case "26":
                    {
                        frm2.button26.Text = "26";
                        frm2.button26.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "27":
                    {
                        frm2.button27.Text = "27";
                        frm2.button27.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "28":
                    {
                        frm2.button28.Text = "28";
                        frm2.button28.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "29":
                    {
                        frm2.button29.Text = "29";
                        frm2.button29.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "30":
                    {
                        frm2.button30.Text = "30";
                        frm2.button30.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "31":
                    {
                        frm2.button31.Text = "31";
                        frm2.button31.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "32":
                    {
                        frm2.button32.Text = "32";
                        frm2.button32.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "33":
                    {
                        frm2.button33.Text = "33";
                        frm2.button33.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "34":
                    {
                        frm2.button34.Text = "34";
                        frm2.button34.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "35":
                    {
                        frm2.button35.Text = "35";
                        frm2.button35.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "36":
                    {
                        frm2.button36.Text = "36";
                        frm2.button36.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "37":
                    {
                        frm2.button37.Text = "37";
                        frm2.button37.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "38":
                    {
                        frm2.button38.Text = "38";
                        frm2.button38.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "39":
                    {
                        frm2.button39.Text = "39";
                        frm2.button39.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "40":
                    {
                        frm2.button40.Text = "40";
                        frm2.button40.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "41":
                    {
                        frm2.button41.Text = "41";
                        frm2.button41.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "42":
                    {
                        frm2.button42.Text = "42";
                        frm2.button42.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "43":
                    {
                        frm2.button43.Text = "43";
                        frm2.button43.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "44":
                    {
                        frm2.button44.Text = "44";
                        frm2.button44.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "45":
                    {
                        frm2.button45.Text = "45";
                        frm2.button45.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "46":
                    {
                        frm2.button46.Text = "46";
                        frm2.button46.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "47":
                    {
                        frm2.button47.Text = "47";
                        frm2.button47.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "48":
                    {
                        frm2.button48.Text = "48";
                        frm2.button48.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "49":
                    {
                        frm2.button49.Text = "49";
                        frm2.button49.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "50":
                    {
                        frm2.button50.Text = "50";
                        frm2.button50.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "51":
                    {
                        frm2.button51.Text = "51";
                        frm2.button51.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "52":
                    {
                        frm2.button52.Text = "52";
                        frm2.button52.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "53":
                    {
                        frm2.button53.Text = "53";
                        frm2.button53.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "54":
                    {
                        frm2.button54.Text = "54";
                        frm2.button54.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "55":
                    {
                        frm2.button55.Text = "55";
                        frm2.button55.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "56":
                    {
                        frm2.button56.Text = "56";
                        frm2.button56.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "57":
                    {
                        frm2.button57.Text = "57";
                        frm2.button57.BackColor = System.Drawing.Color.Lime;
                        break;
                    }

                case "58":
                    {
                        frm2.button58.Text = "58";
                        frm2.button58.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "59":
                    {
                        frm2.button59.Text = "59";
                        frm2.button59.BackColor = System.Drawing.Color.Lime;
                        break;
                    }
                case "60":
                    {
                        frm2.button60.Text = "60";
                        frm2.button60.BackColor = System.Drawing.Color.Lime;
                        break;
                    }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox5.Text != "" && comboBox8.Text != "")
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "INSERT INTO musbilg(TcKimlik,Ad,Soyad,CepTel,Saat,Sehir,Koltuk,Nereden,Nereye) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox8.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "') ";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "INSERT INTO dolu(dolukoltuk) VALUES ('" + comboBox8.Text + "') ";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "DELETE from bos WHERE boskoltuk='" + comboBox8.Text + "'";
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                bag.Close();
                comboBox1.Items.Clear();


                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                textBox5.Clear(); textBox6.Clear();
                comboBox8.Text = "";
                combo();

                MessageBox.Show("Kayıt işlemi tamamlandı ! ");
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz !!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            listele();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
