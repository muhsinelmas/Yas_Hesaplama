using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaş_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int a = 1; a <= 12; a++)
            {
                comboBox2.Items.Add(a);
            }
            for (int b = DateTime.Now.Year; b >= 1900; b--)
            {
                comboBox3.Items.Add(b);
            }

            label5.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gün, ay, yıl;
            gün = DateTime.Now.Day;
            ay = DateTime.Now.Month;
            yıl = DateTime.Now.Year;
            try
            {
                if (DateTime.Now.Day < int.Parse(comboBox1.Text) && DateTime.Now.Month > int.Parse(comboBox2.Text))
                {
                    ay = ay - 1;
                    gün = gün + 30;
                    gün = gün - int.Parse(comboBox1.Text);
                    ay = ay - int.Parse(comboBox2.Text);
                    yıl = yıl - int.Parse(comboBox3.Text);
                    label4.Text = yıl.ToString() + " Yaşında " + ay.ToString() + " Aylık " + gün.ToString() + " Günlüksünüz";
                }
                if (DateTime.Now.Day < int.Parse(comboBox1.Text) && DateTime.Now.Month < int.Parse(comboBox2.Text))
                {
                    yıl = yıl - 1;
                    ay = ay + 12;
                    ay = ay - 1;
                    gün = gün + 30;
                    yıl = yıl - int.Parse(comboBox3.Text);
                    ay = ay - int.Parse(comboBox2.Text);
                    gün = gün - int.Parse(comboBox1.Text);
                    label4.Text = yıl.ToString() + " Yaşında " + ay.ToString() + " Aylık " + gün.ToString() + " Günlüksünüz";
                }
                else if (DateTime.Now.Month < int.Parse(comboBox2.Text))
                {
                    yıl = yıl - 1;
                    ay = ay + 12;
                    gün = gün - int.Parse(comboBox1.Text);
                    ay = ay - int.Parse(comboBox2.Text);
                    yıl = yıl - int.Parse(comboBox3.Text);
                    label4.Text = yıl.ToString() + " Yaşında " + ay.ToString() + " Aylık " + gün.ToString() + " Günlüksünüz";
                }
                else if (DateTime.Now.Day > int.Parse(comboBox1.Text) && DateTime.Now.Month > int.Parse(comboBox2.Text))
                {
                    gün = gün - int.Parse(comboBox1.Text);
                    ay = ay - int.Parse(comboBox2.Text);
                    yıl = yıl - int.Parse(comboBox3.Text);
                    label4.Text = yıl.ToString() + " Yaşında " + ay.ToString() + " Aylık " + gün.ToString() + " Günlüksünüz";
                }
                else if (DateTime.Now.Month < int.Parse(comboBox2.Text) && DateTime.Now.Day > int.Parse(comboBox1.Text))
                {
                    yıl = yıl - 1;
                    ay = ay + 12;
                    gün = gün - int.Parse(comboBox1.Text);
                    ay = ay - int.Parse(comboBox2.Text);
                    yıl = yıl - int.Parse(comboBox3.Text);
                    label4.Text = yıl.ToString() + " Yaşında " + ay.ToString() + " Aylık " + gün.ToString() + " Günlüksünüz";
                }
                else if (DateTime.Now.Day == int.Parse(comboBox1.Text) && DateTime.Now.Month == int.Parse(comboBox2.Text))
                {
                    gün = gün - int.Parse(comboBox1.Text);
                    ay = ay - int.Parse(comboBox2.Text);
                    yıl = yıl - int.Parse(comboBox3.Text);
                    label4.Text = "Tam " + yıl.ToString() + " Yaşındasınız";
                }
                else if (DateTime.Now.Day == int.Parse(comboBox1.Text) && DateTime.Now.Month < int.Parse(comboBox2.Text))
                {
                    yıl = yıl - 1;
                    ay = ay + 12;
                    gün = gün - int.Parse(comboBox1.Text);
                    ay = ay - int.Parse(comboBox2.Text);
                    yıl = yıl - int.Parse(comboBox3.Text);
                    label4.Text = yıl.ToString() + " Yaşında " + ay.ToString() + " Aylık " + gün.ToString() + " Günlüksünüz";
                }
                else if(DateTime.Now.Day == int.Parse(comboBox1.Text) && DateTime.Now.Month > int.Parse(comboBox2.Text))
                {
                    gün = gün - int.Parse(comboBox1.Text);
                    ay = ay - int.Parse(comboBox2.Text);
                    yıl = yıl - int.Parse(comboBox3.Text);
                    label4.Text = yıl.ToString() + " Yaşında " + ay.ToString() + " Aylık " + gün.ToString() + " Günlüksünüz";
                }
                else if (DateTime.Now.Month == int.Parse(comboBox2.Text) && DateTime.Now.Day < int.Parse(comboBox1.Text))
                {
                    yıl = yıl - 1;
                    ay = ay + 12;
                    ay = ay - 1;
                    gün = gün + 30;
                    gün = gün - int.Parse(comboBox1.Text);
                    ay = ay - int.Parse(comboBox2.Text);
                    yıl = yıl - int.Parse(comboBox3.Text);
                    label4.Text = yıl.ToString() + " Yaşında " + ay.ToString() + " Aylık " + gün.ToString() + " Günlüksünüz";
                }
                else if (DateTime.Now.Month == int.Parse(comboBox2.Text) && DateTime.Now.Day > int.Parse(comboBox1.Text))
                {
                    gün = gün - int.Parse(comboBox1.Text);
                    ay = ay - int.Parse(comboBox2.Text);
                    yıl = yıl - int.Parse(comboBox3.Text);
                    label4.Text = yıl.ToString() + " Yaşında " + ay.ToString() + " Aylık " + gün.ToString() + " Günlüksünüz";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Doğum Tarihinizi Düzgün Giriniz!!!", "Uyarı");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text != "2015")
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    comboBox1.Items.Add(i);
                }
                for (int a = 1; a <= 12; a++)
                {
                    comboBox2.Items.Add(a);
                }
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                for (int i = 1; i < DateTime.Now.Day; i++)
                {
                    comboBox1.Items.Add(i);
                }
                for (int a = 1; a <= DateTime.Now.Month; a++)
                {
                    comboBox2.Items.Add(a);
                }
            }

        }
    }
}
