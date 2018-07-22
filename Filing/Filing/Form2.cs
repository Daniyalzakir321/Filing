using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Filing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] a = {".txt",".pdf",".docs"};
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            o.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sce = this.textBox1.Text + "\\" + this.textBox2.Text + this.comboBox1.Text;
            string des = this.textBox3.Text + "\\" + this.textBox2.Text;
            this.textBox2.Text += this.comboBox1.Text;

            if (File.Exists(sce))
            {
                File.Copy(sce, des);
                MessageBox.Show("File Exists & Copied");
            }
            else
            {
                File.Create(sce);
                MessageBox.Show("File Create");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            string sce = this.textBox1.Text + "\\" + this.textBox2.Text + this.comboBox1.Text;
            this.textBox2.Text += this.comboBox1.Text;

            byte[] b = new byte[100];
            char[] ch = new char[100];
            FileStream fs = new FileStream(sce);
            fs.Read(b, 0, 100);
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(b, 0, b.Length, ch, 0);
            this.textBox3.Text += ch;
            fs.Close();
          * */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sce = this.textBox1.Text + "\\" + this.textBox2.Text + this.comboBox1.Text;
            this.textBox2.Text += this.comboBox1.Text;


            StreamReader fs = new StreamReader(sce);
            fs.ReadToEnd();
            fs.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
