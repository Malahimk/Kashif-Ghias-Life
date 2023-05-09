using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Kashif_Ghias_Life
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textusername.Text == "kashif" && textpassword.Text == "22feb")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or Password is incorrect");
                textusername.Clear();
                textpassword.Clear();
                textusername.Focus();
            }
        }

        private void texusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

