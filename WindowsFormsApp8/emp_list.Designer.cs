namespace WindowsFormsApp8
{
    partial class Emp_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employee_list_grid = new System.Windows.Forms.DataGridView();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.employee_list_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_list_grid
            // 
            this.employee_list_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_list_grid.Location = new System.Drawing.Point(70, 157);
            this.employee_list_grid.Name = "employee_list_grid";
            this.employee_list_grid.Size = new System.Drawing.Size(661, 275);
            this.employee_list_grid.TabIndex = 23;
            this.employee_list_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_list_grid_CellContentClick);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(285, 35);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(235, 42);
            this.label_title.TabIndex = 21;
            this.label_title.Text = "EMPLOYEE LIST";
            this.label_title.Click += new System.EventHandler(this.Label_title_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.h_line_a;
            this.pictureBox1.Location = new System.Drawing.Point(98, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 28);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Emp_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.employee_list_grid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_title);
            this.Name = "Emp_List";
            this.Text = "emp_list";
            this.Load += new System.EventHandler(this.Emp_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_list_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employee_list_grid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_title;
    }
}