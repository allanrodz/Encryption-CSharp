using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypting
{
    public partial class Form1 : Form
    {

        HashClass hc = new HashClass();

        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        string username = "admin";
        string password = "qwerty";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            //hc.Passhash

            if (user == username)
            {
                if (pass == password)
                {
                    MessageBox.Show("You are now Logged in", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Clear();
                    txtUser.Clear();
                    lblUser.Enabled = false;
                    lblPass.Enabled = false;
                    txtPass.Enabled = false;
                    txtUser.Enabled = false;
                    btnLogin.Enabled = false;
                    lblWelcome.Text = "Welcome " + user;

                   textBox1.Text = hc.Passhash(password);
                }
                else 
                {
                    MessageBox.Show("Wrong Password", "login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtUser.Clear();
                }

            }
            else
            {
                MessageBox.Show("Wrong Username", "login", MessageBoxButtons.OK, MessageBoxIcon.Error );
                txtPass.Clear();
                txtUser.Clear();
            }
        }
    }
}
