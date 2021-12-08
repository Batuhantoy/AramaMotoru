using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AramaMotoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string link;
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString().IndexOf(textBox1.Text) > -1)
                {
                    if (radioButton1.Checked)
                    {
                        MessageBox.Show("Bu  Siteye Google ile Giriş İzniniz Yok");
                        textBox1.ResetText();
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                    }
                    if (radioButton2.Checked)
                    {
                        MessageBox.Show("Bu  Siteye Yandex ile Giriş İzniniz Yok");
                        textBox1.ResetText();
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                    }
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        link = "https://www.google.com/search?q=" + textBox1.Text;
                        webBrowser1.Navigate(link);
                        listBox3.Items.Add(link);
                    }
                    if (radioButton2.Checked)
                    {
                        link = "https://www.yandex.com/search/?text=" + textBox1.Text;
                        webBrowser1.Navigate(link);
                        listBox3.Items.Add(link);
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = "";
            textBox1.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(listBox1.SelectedItem.ToString());
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    if (listBox2.Items[i].ToString().IndexOf(textBox1.Text) > -1)
                    {
                        if (radioButton1.Checked)
                        {
                            MessageBox.Show("Bu  Siteye Google ile Giriş İzniniz Yok");
                            textBox1.ResetText();
                            radioButton1.Checked = false;
                            radioButton2.Checked = false;
                        }
                        if (radioButton2.Checked)
                        {
                            MessageBox.Show("Bu  Siteye Yandex ile Giriş İzniniz Yok");
                            textBox1.ResetText();
                            radioButton1.Checked = false;
                            radioButton2.Checked = false;
                        }
                    }
                    else
                    {
                        if (radioButton1.Checked)
                        {
                            link = "https://www.google.com/search?q=" + textBox1.Text;
                            webBrowser1.Navigate(link);
                            listBox3.Items.Add(link);
                        }
                        if (radioButton2.Checked)
                        {
                            link = "https://www.yandex.com/search/?text=" + textBox1.Text;
                            webBrowser1.Navigate(link);
                            listBox3.Items.Add(link);
                        }
                    }
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox3.Visible == false)
            {
                listBox3.Visible = true;
            }
            else
            {
                listBox3.Visible = false;
            }                    
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(listBox3.SelectedItem.ToString());
            listBox3.Visible = false;
        }
    }
}
