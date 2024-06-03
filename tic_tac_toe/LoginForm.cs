using System;
using System.Windows.Forms;
using UserNamespace;

namespace tic_tac_toe
{
    public partial class LoginForm : Form
    {
        private Administrator admin;

        public LoginForm(Administrator admin = null, string adminUsername = null)
        {
            InitializeComponent();
            this.admin = admin != null ? admin : new Administrator("administrator", adminUsername ?? "ad", "ad");
        }


        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (admin.verifyLogin(emailTextBox.Text, passwordTextbox.Text))
            {
                this.Hide();
                new AdministratorView(admin, this).Show();
            }
            else if (admin.verifyPlayerLogin(emailTextBox.Text, passwordTextbox.Text))
            {
                this.Hide();
                new Main(admin).Show();
            }
            else
            {
                label2.Text = "Incorrect username or password.";
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}