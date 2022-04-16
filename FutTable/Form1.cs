using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
           // this.Close();
           
        }

        private void pnlLogin_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            Task.Delay(400).Wait();
            if (Convert.ToString(textBox1.Text) == "Name")
                textBox1.Clear();

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            Task.Delay(500).Wait();
            if (Convert.ToString(textBox1.Text) == "")
                textBox1.Text="Name";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           // textBox1.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
         
            if (Convert.ToString(textBox1.Text) == "Name")
                textBox1.Clear();
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToString(textBox2.Text) == "Password")
                textBox2.Clear();
            if (textBox2.PasswordChar == '\0')
                textBox2.PasswordChar = '*';
           
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            Task.Delay(400).Wait();
            if (Convert.ToString(textBox2.Text) == "Password")
            {
                
                textBox2.PasswordChar = '\0';
                textBox2.Clear();
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            Task.Delay(500).Wait();
            if (Convert.ToString(textBox2.Text) == "")
            {
                textBox2.Text = "Password";
                textBox2.PasswordChar = '\0';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.PasswordChar = '\0';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Name";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult select = new DialogResult();
            select = MessageBox.Show("Do you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (select == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (select == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
