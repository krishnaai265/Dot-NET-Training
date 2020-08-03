namespace WindowsFormsApp8
{
    partial class Department_New
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
            this.button_department_new_login = new System.Windows.Forms.Button();
            this.text_department_new_name = new System.Windows.Forms.TextBox();
            this.button_department_new_cancel = new System.Windows.Forms.Button();
            this.button_department_new_clear = new System.Windows.Forms.Button();
            this.label_location = new System.Windows.Forms.Label();
            this.label_departmentname = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.text_department_new_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_department_new_location = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_department_new_login
            // 
            this.button_department_new_login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_department_new_login.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department_new_login.Location = new System.Drawing.Point(290, 435);
            this.button_department_new_login.Name = "button_department_new_login";
            this.button_department_new_login.Size = new System.Drawing.Size(75, 34);
            this.button_department_new_login.TabIndex = 4;
            this.button_department_new_login.Text = "Login";
            this.button_department_new_login.UseVisualStyleBackColor = false;
            this.button_department_new_login.Click += new System.EventHandler(this.button_department_new_login_Click);
            // 
            // text_department_new_name
            // 
            this.text_department_new_name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_department_new_name.Location = new System.Drawing.Point(370, 230);
            this.text_department_new_name.Name = "text_department_new_name";
            this.text_department_new_name.Size = new System.Drawing.Size(147, 26);
            this.text_department_new_name.TabIndex = 1;
            // 
            // button_department_new_cancel
            // 
            this.button_department_new_cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_department_new_cancel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department_new_cancel.Location = new System.Drawing.Point(400, 435);
            this.button_department_new_cancel.Name = "button_department_new_cancel";
            this.button_department_new_cancel.Size = new System.Drawing.Size(75, 34);
            this.button_department_new_cancel.TabIndex = 6;
            this.button_department_new_cancel.Text = "Cancel";
            this.button_department_new_cancel.UseVisualStyleBackColor = false;
            this.button_department_new_cancel.Click += new System.EventHandler(this.button_department_new_cancel_Click);
            // 
            // button_department_new_clear
            // 
            this.button_department_new_clear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_department_new_clear.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department_new_clear.Location = new System.Drawing.Point(176, 435);
            this.button_department_new_clear.Name = "button_department_new_clear";
            this.button_department_new_clear.Size = new System.Drawing.Size(75, 34);
            this.button_department_new_clear.TabIndex = 5;
            this.button_department_new_clear.Text = "Clear";
            this.button_department_new_clear.UseVisualStyleBackColor = false;
            this.button_department_new_clear.Click += new System.EventHandler(this.button_new_clear_Click);
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_location.Location = new System.Drawing.Point(154, 346);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(186, 22);
            this.label_location.TabIndex = 11;
            this.label_location.Text = "Department Location:";
            // 
            // label_departmentname
            // 
            this.label_departmentname.AutoSize = true;
            this.label_departmentname.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_departmentname.Location = new System.Drawing.Point(154, 233);
            this.label_departmentname.Name = "label_departmentname";
            this.label_departmentname.Size = new System.Drawing.Size(164, 22);
            this.label_departmentname.TabIndex = 10;
            this.label_departmentname.Text = "Department Name:";
            this.label_departmentname.Click += new System.EventHandler(this.label_username_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(231, 115);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(201, 42);
            this.label_title.TabIndex = 9;
            this.label_title.Text = "NEW ADMIN";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // text_department_new_email
            // 
            this.text_department_new_email.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_department_new_email.Location = new System.Drawing.Point(371, 289);
            this.text_department_new_email.Name = "text_department_new_email";
            this.text_department_new_email.Size = new System.Drawing.Size(147, 26);
            this.text_department_new_email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Department Email:";
            // 
            // combo_department_new_location
            // 
            this.combo_department_new_location.FormattingEnabled = true;
            this.combo_department_new_location.ItemHeight = 13;
            this.combo_department_new_location.Items.AddRange(new object[] {
            "Delhi",
            "Chennai",
            "Hyderabad",
            "Moradabad"});
            this.combo_department_new_location.Location = new System.Drawing.Point(371, 346);
            this.combo_department_new_location.Name = "combo_department_new_location";
            this.combo_department_new_location.Size = new System.Drawing.Size(146, 21);
            this.combo_department_new_location.TabIndex = 3;
            this.combo_department_new_location.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.h_line_a;
            this.pictureBox1.Location = new System.Drawing.Point(16, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 28);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Department_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(630, 554);
            this.Controls.Add(this.combo_department_new_location);
            this.Controls.Add(this.text_department_new_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_department_new_login);
            this.Controls.Add(this.text_department_new_name);
            this.Controls.Add(this.button_department_new_cancel);
            this.Controls.Add(this.button_department_new_clear);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.label_departmentname);
            this.Controls.Add(this.label_title);
            this.Name = "Department_New";
            this.Text = "frmDepartmentSearch";
            this.Load += new System.EventHandler(this.frmDepartmentSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_department_new_login;
        private System.Windows.Forms.TextBox text_department_new_name;
        private System.Windows.Forms.Button button_department_new_cancel;
        private System.Windows.Forms.Button button_department_new_clear;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label_departmentname;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox text_department_new_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_department_new_location;
    }
}