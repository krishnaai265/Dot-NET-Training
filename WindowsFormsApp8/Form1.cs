using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (text_username.Text != "admin" || text_password.Text != "admin") {
                MessageBox.Show("Invalid_Credentials. Please try Again..");
            }
            else if (text_username.Text != "" && text_password.Text != "")
            {
                //MessageBox.Show(null, "Login Successful.", "Login Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Hide();
                WindowsForm9 w = new WindowsForm9();
                w.Show();

            }
            else
            {
                MessageBox.Show("Please Enter your Crendentials");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_username.Text = "";
            text_password.Text = string.Empty;

        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_username.Text))
            {
                errorusername.SetError(text_username, "Username is Required");
            }else {
                errorusername.SetError(text_username, string.Empty);
            }
        }
    }
}
