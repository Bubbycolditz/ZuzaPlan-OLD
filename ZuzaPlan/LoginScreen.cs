using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZuzaPlan
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void signinLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupButton.Visible = false;
            signinButton.Visible = true;
            phoneInput.Visible = false;
            label3.Visible = false;
            signinLink.Visible = false;
            signupLink.Visible = true;
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupButton.Visible = true;
            signinButton.Visible = false;
            phoneInput.Visible = true;
            label3.Visible = true;
            signinLink.Visible = true;
            signupLink.Visible = false;
        }

        private void phoneInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
