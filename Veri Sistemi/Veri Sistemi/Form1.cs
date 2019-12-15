using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != string.Empty&& textBox3.Text != string.Empty&& maskedTextBox1.Text != string.Empty && numericUpDown1.Text != string.Empty && numericUpDown2.Text != string.Empty && textBox6.Text != string.Empty)
            {
                string[] satır = new string[] { textBox2.Text, textBox3.Text, maskedTextBox1.Text, numericUpDown1.Text, numericUpDown2.Text, textBox6.Text };

                ListViewItem ekle = new ListViewItem(satır);

                listView1.Items.Add(ekle);

            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox6.Text=((numericUpDown1.Value + numericUpDown2.Value) / 2).ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
        }
    }
}
