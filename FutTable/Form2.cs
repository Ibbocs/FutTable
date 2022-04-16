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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            pnlCurıousSub.Visible = false;
        }

        private void HideCuriousSub() 
        {
            if (pnlCurıousSub.Visible == true)
            {
                pnlCurıousSub.Visible = false;
            }
        }

        private void opnfrm(Form frm)
        {

            panel2.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel2.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        public void ChangeAccounnt() 
        {
            DialogResult sellectCA = new DialogResult();
            Form1 frm1 = new Form1();

            sellectCA = MessageBox.Show("Do you want to change your account?", "Change Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sellectCA == DialogResult.Yes)
            {

                frm1.Show();
                this.Hide();
                
            }
        }
        


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideCuriousSub();
            Form4 frm4 = new Form4();
            opnfrm(frm4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HideCuriousSub();
            Form5 frm5 = new Form5();
            opnfrm(frm5);
        }

        private void pnlCurıousSub_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttnCurıous_Click(object sender, EventArgs e)
        {
            if (pnlCurıousSub.Visible == false)
            {
                pnlCurıousSub.Visible = true;
            }
            else
            {
                pnlCurıousSub.Visible = false;
            }

        }

        private void bttnChangeAccount_Click(object sender, EventArgs e)
        {
            HideCuriousSub();
            ChangeAccounnt();
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void pctrSettingIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürəyim istəyəndə gələr bu özəllik", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürəyim istəyəndə gələr bu özəllik", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pctrBoxAccountIcon_Click(object sender, EventArgs e)
        {
            HideCuriousSub();
            ChangeAccounnt();
            
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            HideCuriousSub();
            ChangeAccounnt();
            
        }

        private void bttnGoodOfTheWeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working on this feature", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttnLuckOfTheWeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working on this feature", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
