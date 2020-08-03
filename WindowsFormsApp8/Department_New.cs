using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp8
{
    public partial class Department_New : Form
    {
        public Department_New()
        {
            InitializeComponent();
        }

        private void frmDepartmentSearch_Load(object sender, EventArgs e)
        {
            combo_department_new_location.Text = "Select Location";
        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void button_new_clear_Click(object sender, EventArgs e)
        {
            text_department_new_email.Text = string.Empty;
            combo_department_new_location.SelectedIndex = 0;
            text_department_new_name.Text = string.Empty;
        }

        private void button_department_new_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ITEM-71084; Initial Catalog=EmployeeManagementDB;Integrated Security=true;");
            //User Id=sa; password=123;
            con.Open();
            string query = "insert into Department(DeptName,  DeptLocation, DeptEmail) values (@dname, @dlocation, @demail )";
          //  string query = "insert into Department(DeptName, DeptLocation, DeptEmail) values('abhi', 'Moradabad', 'a@gmail.com')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@dname", text_department_new_name.Text);
            cmd.Parameters.AddWithValue("@dlocation", combo_department_new_location.Text);
            cmd.Parameters.AddWithValue("@demail", text_department_new_email.Text);

            int result = cmd.ExecuteNonQuery();
            if (result > 0) {
                MessageBox.Show("Department Added Successfully ");
            }
            else {
                MessageBox.Show("Please Contact Your Administrator");
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_department_new_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
