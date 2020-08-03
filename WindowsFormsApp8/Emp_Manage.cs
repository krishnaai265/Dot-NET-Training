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
    public partial class Emp_Manage : Form
    {
        public Emp_Manage()
        {
            InitializeComponent();
        }

        private void Button_employee_modify_search_Click(object sender, EventArgs e)
        {
            clearFields();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-722JGNJ\\SQLEXPRESS; Initial Catalog=EmployeeManagementDB;Integrated Security=true;");
            //  User Id=sa; password=123;
            con.Open();
            string query = "select * from employee where empid = @id";
            //  string query = "insert into Department(DeptName, DeptLocation, DeptEmail) values('abhi', 'Moradabad', 'a@gmail.com')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", text_employee_modify_id.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                text_employee_modify_name.Text = dr[1].ToString();
                text_employee_modify_email.Text = dr["empname"].ToString();
                text_employee_modify_salary.Text = dr["salary"].ToString();
                text_employee_modify_deptid.Text = dr["deptid"].ToString();
            }
            else
            {
                MessageBox.Show("There is no such Department exist with ID.\n If problem persist Please Contact Your Administrator");
                clearFields();
            }
            con.Close();
        }

        private void clearFields() {
            text_employee_modify_id.Text = string.Empty;
            text_employee_modify_name.Text = string.Empty;
            text_employee_modify_email.Text = string.Empty;
            text_employee_modify_salary.Text = string.Empty;
            text_employee_modify_deptid.Text = string.Empty;
        }

        private void Button_employee_modify_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
