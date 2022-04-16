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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pnlCuriousSub.Visible = false;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void opnfrm(Form frm) 
        {
            panel1.Controls.Clear();
            
            
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void changeAccount()
        {
            DialogResult sellectCA = new DialogResult();
            sellectCA = MessageBox.Show("Do you want to change your account?", "Change Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sellectCA == DialogResult.Yes)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
        }

        private void hideCuriousSub() 
        {
            if (pnlCuriousSub.Visible == true)
            {
                pnlCuriousSub.Visible = false;
            }
        }

        private void pictureBoxMenuIcon_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void bttnTabble_Click(object sender, EventArgs e)
        {
            hideCuriousSub();
            Form4 frm4 = new Form4();
            opnfrm(frm4);
        }

        private void bttnPlyrStatic_Click(object sender, EventArgs e)
        {
            hideCuriousSub();
            Form5 frm5 = new Form5();
            opnfrm(frm5);
        }

        private void bttnCurious_Click(object sender, EventArgs e)
        {
            
            if (pnlCuriousSub.Visible == false)
            {
                pnlCuriousSub.Visible = true;
            }
            else
            {
                pnlCuriousSub.Visible = false;
            }
        }

        private void pctrBoxChangeAccount_Click(object sender, EventArgs e)
        {
            hideCuriousSub();
            changeAccount();
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            hideCuriousSub();
            changeAccount();
        }

        private void pctrBoxSettingIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürəyim istəyəndə gələr bu özəllik", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürəyim istəyəndə gələr bu özəllik", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideCuriousSub();
            changeAccount();
        }

        private void bttnGoodOfWeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working on this feature", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttnLuckyOfWeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working on this feature", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
