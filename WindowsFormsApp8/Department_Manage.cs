using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Department_Manage : Form
    {
        public Department_Manage()
        {
            InitializeComponent();
        }

        private void Emp_Manage_Load(object sender, EventArgs e)
        {

        }

        private void button_department_modify_search_Click(object sender, EventArgs e)
        {
            clearFields();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);
            //User Id=sa; password=123;
            con.Open();
            string query = "select * from Department where DeptId = @id";
            //  string query = "insert into Department(DeptName, DeptLocation, DeptEmail) values('abhi', 'Moradabad', 'a@gmail.com')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", text_department_modify_id.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                text_department_modify_name.Text = dr[1].ToString();
                text_department_modify_email.Text = dr["DeptEmail"].ToString();
                text_department_modify_location.Text = dr["DeptLocation"].ToString();
            }
            else
            {
                MessageBox.Show("There is no such Department exist with ID.\n If problem persist Please Contact Your Administrator");
                clearFields();
            }
            con.Close();
        }
        void clearFields()
        {
            text_department_modify_name.Text = string.Empty;
            text_department_modify_email.Text = string.Empty;
            text_department_modify_location.Text = string.Empty;
        }

        private void button_department_modify_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ITEM-71084; Initial Catalog=EmployeeManagementDB;Integrated Security=true;");
            //User Id=sa; password=123;
            con.Open();
            string query = "Update Department set DeptName=@dname,  DeptLocation=@dlocation, DeptEmail=@demail where DeptId =@id";
            //  string query = "insert into Department(DeptName, DeptLocation, DeptEmail) values('abhi', 'Moradabad', 'a@gmail.com')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", text_department_modify_id.Text);
            cmd.Parameters.AddWithValue("@dname", text_department_modify_name.Text);
            cmd.Parameters.AddWithValue("@dlocation", text_department_modify_location.Text);
            cmd.Parameters.AddWithValue("@demail", text_department_modify_email.Text);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Department Updated Successfully ");
                clearFields();
            }
            else
            {
                MessageBox.Show("Please Contact Your Administrator");
                clearFields();
            }
            con.Close();
        }

        private void button_department_modify_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ITEM-71084; Initial Catalog=EmployeeManagementDB;Integrated Security=true;");
            //User Id=sa; password=123;
            con.Open();
            string query = "delete from Department where DeptId=@id";
            //  string query = "insert into Department(DeptName, DeptLocation, DeptEmail) values('abhi', 'Moradabad', 'a@gmail.com')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", text_department_modify_id.Text);
        //    cmd.Parameters.AddWithValue("@dname", text_department_modify_name.Text);
      //      cmd.Parameters.AddWithValue("@dlocation", text_department_modify_location.Text);
      //      cmd.Parameters.AddWithValue("@demail", text_department_modify_email.Text);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Department Updated Successfully ");
                clearFields();
            }
            else
            {
                MessageBox.Show("Please Contact Your Administrator");
                clearFields();
            }
            con.Close();
        }

        private void button_department_modify_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void button_department_modify_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
