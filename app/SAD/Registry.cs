using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD
{
    public partial class Registry : UserControl
    {
        public Registry()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            nameTextBox.Text = null;
            emailTextBox.Text = null;
            addressTextBox.Text = null;
            passwordTextBox.Text = null;
            confirmpasswordTextBox.Text = null;
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == null || emailTextBox.Text == null || addressTextBox.Text == null || passwordTextBox.Text == null || confirmpasswordTextBox.Text == null)
            {
                MessageBox.Show("Please fill out all the fields!");
            }
            else if (passwordTextBox.Text != confirmpasswordTextBox.Text)
            {
                MessageBox.Show("Passwords don't match!");
            }
            else if (this.userTableAdapter.CheckEmail(emailTextBox.Text) != null)
            {
                MessageBox.Show("Email already exists in our system!");
            }
            //Meter a password em hash
            this.userTableAdapter.NewUser(emailTextBox.Text, nameTextBox.Text, addressTextBox.Text, passwordTextBox.Text);
            this.SendToBack();
        }
    }
}
