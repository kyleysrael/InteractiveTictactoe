using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using UserNamespace;

namespace tic_tac_toe
{
    public partial class AdministratorView : Form
    {
        private Administrator admin;
        private LoginForm loginForm;

        public AdministratorView(Administrator admin, LoginForm loginForm)
        {
            InitializeComponent();
            this.admin = admin;
            this.loginForm = loginForm; 
            UpdatePlayerCountLabel();
        }

        private void newUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameToChangePass_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPasswordReset_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            string playerName = newUsername.Text;
            string playerId = newUsername.Text;
            string playerPassword = newPassword.Text;

            bool success = admin.createPlayer(playerName, playerId, playerPassword);
            if (!string.IsNullOrEmpty(playerName) && !string.IsNullOrEmpty(playerPassword) && success)
            {
                guna2MessageDialog1.Icon = MessageDialogIcon.None;
                guna2MessageDialog1.Show("Player created successfully.", "Success");
                UpdatePlayerCountLabel();
                ClearCreateAccountFields();
            }
            else
            {
                guna2MessageDialog1.Icon = MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Invalid request.", "Error");
            }
        }





        private void numOfPlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePlayerCountLabel()
        {
            numOfPlayer.Text = $"{admin.PlayerCount}";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm(admin).Show();
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearCreateAccountFields()
        {
            newUsername.Text = string.Empty;
            newPassword.Text = string.Empty;
        }

        private void ClearResetPasswordFields()
        {
            usernameToChangePass.Text = string.Empty;
            newPasswordReset.Text = string.Empty;
        }

        private void resetBtn_Click_1(object sender, EventArgs e)
        {
            string playerId = usernameToChangePass.Text;
            string newPassword = newPasswordReset.Text;

            if (string.IsNullOrEmpty(playerId) || string.IsNullOrEmpty(newPassword))
            {
                guna2MessageDialog1.Icon = MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please enter both username and new password.");
                return;
            }

            bool success = admin.updatePlayerPassword(playerId, newPassword);
            if (success)
            {
                guna2MessageDialog1.Icon = MessageDialogIcon.Information;
                guna2MessageDialog1.Show("Password updated successfully.");
                ClearResetPasswordFields();
            }
            else
            {
                guna2MessageDialog1.Icon = MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Player not found.");
            }
        }

        private void AdministratorView_Load(object sender, EventArgs e)
        {

        }


        private void newUsernameAdmin_TextChanged(object sender, EventArgs e)
        {.

        }


        private void updateAdminUsername_Click_1(object sender, EventArgs e)
        {
            string newAdminName = newUsernameAdmin.Text;
            if (string.IsNullOrEmpty(newAdminName))
            {
                guna2MessageDialog1.Icon = MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please enter a new username.", "Error");
                return;
            }

            admin.updateAdminName(newAdminName);
            guna2MessageDialog1.Icon = MessageDialogIcon.Information;
            guna2MessageDialog1.Show("Admin username updated successfully.", "Success");
            newUsernameAdmin.Text = string.Empty;
        }
    }
}
