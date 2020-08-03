namespace WindowsFormsApp8
{
    partial class Department_List
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
            this.label_title = new System.Windows.Forms.Label();
            this.deparment_list_grid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deparment_list_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(228, 103);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(280, 42);
            this.label_title.TabIndex = 18;
            this.label_title.Text = "DEPARTMENT LIST";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // deparment_list_grid
            // 
            this.deparment_list_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deparment_list_grid.Location = new System.Drawing.Point(51, 225);
            this.deparment_list_grid.Name = "deparment_list_grid";
            this.deparment_list_grid.Size = new System.Drawing.Size(661, 275);
            this.deparment_list_grid.TabIndex = 20;
            this.deparment_list_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.load_deparments_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.h_line_a;
            this.pictureBox1.Location = new System.Drawing.Point(79, 147);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 28);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Department_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(759, 582);
            this.Controls.Add(this.deparment_list_grid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_title);
            this.Name = "Department_List";
            this.Text = "frmDepartmentList";
            this.Load += new System.EventHandler(this.Department_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deparment_list_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView deparment_list_grid;
    }
}