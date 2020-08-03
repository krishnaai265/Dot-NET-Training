namespace WindowsFormsApp8
{
    partial class Department_Search
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
            this.text_department_search_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_department_search_id = new System.Windows.Forms.TextBox();
            this.label_departmentname = new System.Windows.Forms.Label();
            this.button_department_search_clear = new System.Windows.Forms.Button();
            this.button_department_search_search = new System.Windows.Forms.Button();
            this.text_department_search_location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_department_search_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(204, 91);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(336, 42);
            this.label_title.TabIndex = 20;
            this.label_title.Text = "DEPARTMENT SEARCH";
            // 
            // text_department_search_email
            // 
            this.text_department_search_email.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_department_search_email.Location = new System.Drawing.Point(293, 329);
            this.text_department_search_email.Name = "text_department_search_email";
            this.text_department_search_email.Size = new System.Drawing.Size(147, 26);
            this.text_department_search_email.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Department Email:";
            // 
            // text_department_search_id
            // 
            this.text_department_search_id.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_department_search_id.Location = new System.Drawing.Point(292, 221);
            this.text_department_search_id.Name = "text_department_search_id";
            this.text_department_search_id.Size = new System.Drawing.Size(147, 26);
            this.text_department_search_id.TabIndex = 22;
            // 
            // label_departmentname
            // 
            this.label_departmentname.AutoSize = true;
            this.label_departmentname.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_departmentname.Location = new System.Drawing.Point(76, 224);
            this.label_departmentname.Name = "label_departmentname";
            this.label_departmentname.Size = new System.Drawing.Size(134, 22);
            this.label_departmentname.TabIndex = 24;
            this.label_departmentname.Text = "Department Id:";
            this.label_departmentname.Click += new System.EventHandler(this.label_departmentname_Click);
            // 
            // button_department_search_clear
            // 
            this.button_department_search_clear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_department_search_clear.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department_search_clear.Location = new System.Drawing.Point(593, 213);
            this.button_department_search_clear.Name = "button_department_search_clear";
            this.button_department_search_clear.Size = new System.Drawing.Size(75, 34);
            this.button_department_search_clear.TabIndex = 26;
            this.button_department_search_clear.Text = "Clear";
            this.button_department_search_clear.UseVisualStyleBackColor = false;
            this.button_department_search_clear.Click += new System.EventHandler(this.button_department_search_clear_Click);
            // 
            // button_department_search_search
            // 
            this.button_department_search_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_department_search_search.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department_search_search.Location = new System.Drawing.Point(479, 213);
            this.button_department_search_search.Name = "button_department_search_search";
            this.button_department_search_search.Size = new System.Drawing.Size(75, 34);
            this.button_department_search_search.TabIndex = 27;
            this.button_department_search_search.Text = "Search";
            this.button_department_search_search.UseVisualStyleBackColor = false;
            this.button_department_search_search.Click += new System.EventHandler(this.button_department_search_search_Click);
            // 
            // text_department_search_location
            // 
            this.text_department_search_location.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_department_search_location.Location = new System.Drawing.Point(293, 384);
            this.text_department_search_location.Name = "text_department_search_location";
            this.text_department_search_location.Size = new System.Drawing.Size(147, 26);
            this.text_department_search_location.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Department Location:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_department_search_name
            // 
            this.text_department_search_name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_department_search_name.Location = new System.Drawing.Point(293, 276);
            this.text_department_search_name.Name = "text_department_search_name";
            this.text_department_search_name.Size = new System.Drawing.Size(147, 26);
            this.text_department_search_name.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Department Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.h_line_a;
            this.pictureBox1.Location = new System.Drawing.Point(70, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 28);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Department_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(708, 515);
            this.Controls.Add(this.text_department_search_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_department_search_location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_department_search_clear);
            this.Controls.Add(this.button_department_search_search);
            this.Controls.Add(this.text_department_search_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_department_search_id);
            this.Controls.Add(this.label_departmentname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_title);
            this.Name = "Department_Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox text_department_search_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_department_search_id;
        private System.Windows.Forms.Label label_departmentname;
        private System.Windows.Forms.Button button_department_search_clear;
        private System.Windows.Forms.Button button_department_search_search;
        private System.Windows.Forms.TextBox text_department_search_location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_department_search_name;
        private System.Windows.Forms.Label label3;
    }
}