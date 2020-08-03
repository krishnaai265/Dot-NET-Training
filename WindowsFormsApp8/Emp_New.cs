using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Emp_New : Form
    {
        public Emp_New()
        {
            InitializeComponent();
        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void text_employee_new_name_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void checkdata() {

            if (text_employee_new_name.Text.Trim().Equals("") || text_employee_new_salary.Text.Trim().Equals("") || text_employee_new_id.Text.Trim().Equals("")) { 
                button_employee_new_clear.Enabled = false;
                button_employee_new_login.Enabled = false;
            }else{
                button_employee_new_clear.Enabled = true;
                button_employee_new_login.Enabled = true;
            }
        }

        private void text_employee_new_email_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void text_employee_new_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void text_employee_new_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_employee_new_name.Text))
            {
                error_employee_new_name.SetError(text_employee_new_name, "Username is Required");
                checkdata();
            }
            else
            {
                error_employee_new_name.SetError(text_employee_new_name, string.Empty);
                checkdata();
            }
        }

        private void text_employee_new_email_TextChanged(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_employee_new_salary.Text))
            {
                error_employee_new_salary.SetError(text_employee_new_salary, "Salary is Required");
                checkdata();
            }
            else
            {
                error_employee_new_salary.SetError(text_employee_new_salary, string.Empty);
                checkdata();
            }
        }

        private void text_employee_new_id_TextChanged(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_employee_new_salary.Text))
            {
                error_employee_new_id.SetError(text_employee_new_id, "Dept. id is Required");
                checkdata();
            }
            else
            {
                error_employee_new_id.SetError(text_employee_new_id, string.Empty);
                checkdata();
            }
        }

        private void button_employee_new_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-722JGNJ\\SQLEXPRESS; Initial Catalog=EmployeeManagementDB;Integrated Security=true;");
            //User Id=sa; password=123;
            con.Open();
            // string query = "insert into employee(empname,  salary, deptid) values (@name, @salary, @id )";
            //  string query = "insert into Department(DeptName, DeptLocation, DeptEmail) values('abhi', 'Moradabad', 'a@gmail.com')";
            //  SqlCommand cmd = new SqlCommand(query, con);
            //  cmd.Parameters.AddWithValue("@name", text_employee_new_name.Text);
            //  cmd.Parameters.AddWithValue("@salary", text_employee_new_salary.Text);
            //  cmd.Parameters.AddWithValue("@id", text_employee_new_id.Text);

            int x = Int32.Parse(text_employee_new_salary.Text);
            if (x > 5000)
            {
                if (text_employee_new_name.Text != null)
                {
                    string query1 = "select * from Department";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                  //  cmd1.Parameters.AddWithValue("@id", text_employee_new_id.Text);
                    int result1 = cmd1.ExecuteNonQuery();
                   // MessageBox.Show(result1.ToString());
                    if (result1 > 0)
                    {
                        MessageBox.Show("Text 1");
                        /*int result = 1;//cmd.ExecuteNonQuery();
                        MessageBox.Show(result.ToString());
                        if (result > 0)
                        {
                            MessageBox.Show("Text 2");
                            MessageBox.Show("Department Added Successfully ");
                        }*/
                        
                    }
                    else
                    {
                        MessageBox.Show("Please Contact Your Administrator");
                    }
                }
                        else
                        {
                            MessageBox.Show("name should not be null ");
                        }
            }
            else {
                        MessageBox.Show("salary should be greater than 5000 ");
                    }


            con.Close();
        }

        private void Emp_New_Load(object sender, EventArgs e)
        {
            checkdata();
        }

        private void Button_employee_new_clear_Click(object sender, EventArgs e)
        {
            text_employee_new_name.Text = string.Empty;
            text_employee_new_salary.Text = string.Empty;
            text_employee_new_id.Text = string.Empty;

        }

        private void Button_employee_new_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
