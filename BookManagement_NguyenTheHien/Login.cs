using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HoangNgocTrinh
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoginName.Text)|| string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                MessageBox.Show("Please input both email and password to login !", "Miss input ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserAccountService u = new();
            UserAccount? acc = u.CheckLogin(txtLoginName.Text, txtLoginPassword.Text);
            if (acc == null)
            {
                MessageBox.Show("Login fail! Check the email and password again!", "Wrong cridentails ", MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
            if (acc.Role !=1)
            {
                MessageBox.Show("You don't have permisson to access this feature!", "Wrong privilege ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BookManagerMainUI b = new BookManagerMainUI();
            b.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
