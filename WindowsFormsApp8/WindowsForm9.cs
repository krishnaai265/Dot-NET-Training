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
    public partial class WindowsForm9 : Form
    {
        public WindowsForm9()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Department_Search f = new Department_Search();
            LayoutMdi(MdiLayout.ArrangeIcons);
            f.MdiParent = this;
            f.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void projectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Department_New f = new Department_New();
            LayoutMdi(MdiLayout.ArrangeIcons);
            f.MdiParent = this;
            f.Show();
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department_List w = new Department_List();
            w.MdiParent = this;
            LayoutMdi(MdiLayout.ArrangeIcons);
            w.Show();

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department_Manage m = new Department_Manage();
            m.MdiParent = this;
            LayoutMdi(MdiLayout.ArrangeIcons);
            m.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WindowsForm9_Load(object sender, EventArgs e)
        {

        }

        private void empNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp_New n = new Emp_New();
            n.Show();
        }

        private void EmpSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp_List l = new Emp_List();
            l.Show();
        }

        private void EmpManageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Emp_Manage m = new Emp_Manage();
            m.Show();
        }
    }
}
