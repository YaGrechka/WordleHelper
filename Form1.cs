using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordleHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Language.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 1)
                richTextBox2.Focus();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Length == 1)
                richTextBox3.Focus();
            if (richTextBox2.Text.Length == 0)
                richTextBox1.Focus();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox3.Text.Length == 1)
                richTextBox4.Focus();
            if (richTextBox3.Text.Length == 0)
                richTextBox2.Focus();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox4.Text.Length == 1)
                richTextBox5.Focus();
            if (richTextBox4.Text.Length == 0)
                richTextBox3.Focus();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox5.Text.Length == 0)
                richTextBox4.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word word = new Word();
            word.SetChar(1, richTextBox1.Text, comboBox1.SelectedIndex);
            word.SetChar(2, richTextBox2.Text, comboBox2.SelectedIndex);
            word.SetChar(3, richTextBox3.Text, comboBox3.SelectedIndex);
            word.SetChar(4, richTextBox4.Text, comboBox4.SelectedIndex);
            word.SetChar(5, richTextBox5.Text, comboBox5.SelectedIndex);
            
            listBox1.Items.Add(word.FullWord());
        }
    }
}
