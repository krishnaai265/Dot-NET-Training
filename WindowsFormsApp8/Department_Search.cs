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
    public partial class Department_Search : Form
    {
        public Department_Search()
        {
            InitializeComponent();
        }

        private void button_department_new_cancel_Click(object sender, EventArgs e)
        {

        }

        private void label_departmentname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_department_search_search_Click(object sender, EventArgs e)
        {
            clearFields();
            SqlConnection con = new SqlConnection("Data Source=ITEM-71084; Initial Catalog=EmployeeManagementDB;Integrated Security=true;");
            //User Id=sa; password=123;
            con.Open();
            string query = "select * from Department where DeptId = @id";
            //  string query = "insert into Department(DeptName, DeptLocation, DeptEmail) values('abhi', 'Moradabad', 'a@gmail.com')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", text_department_search_id.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                text_department_search_name.Text = dr[1].ToString();
                text_department_search_email.Text = dr["DeptEmail"].ToString();
                text_department_search_location.Text = dr[3].ToString();
            }
            else
            {
                MessageBox.Show("There is no such Department exist with ID.\n If problem persist Please Contact Your Administrator");
                clearFields();
            }
            con.Close();
        }

        private void button_department_search_clear_Click(object sender, EventArgs e)
        {
            clearFields();

        }
        void clearFields()
        {
            text_department_search_name.Text = string.Empty;
            text_department_search_email.Text = string.Empty;
            text_department_search_location.Text = string.Empty;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
