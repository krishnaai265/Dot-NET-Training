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
    public partial class Emp_List : Form
    {
        public Emp_List()
        {
            InitializeComponent();
        }

        private void Label_title_Click(object sender, EventArgs e)
        {

        }

        private void Employee_list_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Emp_List_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-722JGNJ\\SQLEXPRESS; Initial Catalog=EmployeeManagementDB;Integrated Security=true;");
            //User Id=sa; password=123;
            con.Open();
            string query = "select * from employee";
            //  string query = "insert into Department(DeptName, DeptLocation, DeptEmail) values('abhi', 'Moradabad', 'a@gmail.com')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            employee_list_grid.DataSource = dt;
        }
    }
}
