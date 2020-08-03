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
    public partial class Department_List : Form
    {
        public Department_List()
        {
            InitializeComponent();
        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void load_deparments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Department_List_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ITEM-71084; Initial Catalog=EmployeeManagementDB;Integrated Security=true;");
            //User Id=sa; password=123;
            con.Open();
            string query = "select * from Department";
            //  string query = "insert into Department(DeptName, DeptLocation, DeptEmail) values('abhi', 'Moradabad', 'a@gmail.com')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            deparment_list_grid.DataSource = dt;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
