using System;
using System.Windows.Forms;

namespace SAD
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            Username.Text = null;
            Password.Text = null;
        }

        private void Password_OnValueChanged(object sender, EventArgs e)
        {
            Password.isPassword = true;
        }

        private void BunifuImageButton2_MouseDown(object sender, MouseEventArgs e)
        {
            Password.isPassword = false;
        }

        private void BunifuImageButton2_MouseUp(object sender, MouseEventArgs e)
        {
            Password.isPassword = true;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            String username = "";
            username = this.userTableAdapter.GetName(Username.Text, Password.Text);

            MessageBox.Show(username);

            if (username == null)
            {
                MessageBox.Show("Username or Password invalid! Please try again");
            }
            else
            {
                Username.Text = null;
                Password.Text = null;
            }

        }

    }
}
