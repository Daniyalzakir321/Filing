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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 o = new Form2();
            o.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sce = this.textBox1.Text + "\\" + this.textBox2.Text;
            string des = this.textBox3.Text + "\\" + this.textBox2.Text;
            File.Copy(sce, des);
            MessageBox.Show("File Copied");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sce = this.textBox1.Text + "\\" + this.textBox2.Text;
            string des = this.textBox3.Text + "\\" + this.textBox2.Text;
            File.Move(sce, des);
            MessageBox.Show("File Moved");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sce = this.textBox1.Text + "\\" + this.textBox2.Text;
            File.Exists(sce);
            MessageBox.Show("File Exists");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sce = this.textBox1.Text + "\\" + this.textBox2.Text;
            File.Delete(sce);
            MessageBox.Show("File Delete");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sce = this.textBox1.Text + "\\" + this.textBox2.Text;
            File.Create(sce);
            MessageBox.Show("File Create");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sce = this.textBox1.Text + "\\" + this.textBox2.Text;

            DirectoryInfo di = new DirectoryInfo(sce);
            FileInfo[] fi = di.GetFiles();
            foreach (FileInfo f in fi)
            {

                this.textBox4.Text += "File Name:" + f.Name + Environment.NewLine;
            }
        }
    }
}
