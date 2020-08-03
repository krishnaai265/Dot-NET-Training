namespace WindowsFormsApp8
{
    partial class Emp_New
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
            this.components = new System.ComponentModel.Container();
            this.text_employee_new_salary = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.button_employee_new_login = new System.Windows.Forms.Button();
            this.text_employee_new_name = new System.Windows.Forms.TextBox();
            this.button_employee_new_cancel = new System.Windows.Forms.Button();
            this.button_employee_new_clear = new System.Windows.Forms.Button();
            this.employee_date = new System.Windows.Forms.Label();
            this.label_employee_name = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_employee_new_id = new System.Windows.Forms.TextBox();
            this.error_employee_new_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_employee_new_salary = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_employee_new_id = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_employee_new_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_employee_new_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_employee_new_id)).BeginInit();
            this.SuspendLayout();
            // 
            // text_employee_new_salary
            // 
            this.text_employee_new_salary.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_employee_new_salary.Location = new System.Drawing.Point(393, 253);
            this.text_employee_new_salary.Name = "text_employee_new_salary";
            this.text_employee_new_salary.Size = new System.Drawing.Size(147, 26);
            this.text_employee_new_salary.TabIndex = 20;
            this.text_employee_new_salary.TextChanged += new System.EventHandler(this.text_employee_new_email_TextChanged);
            this.text_employee_new_salary.Validating += new System.ComponentModel.CancelEventHandler(this.text_employee_new_email_TextChanged);
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salary.Location = new System.Drawing.Point(177, 253);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(150, 22);
            this.label_salary.TabIndex = 29;
            this.label_salary.Text = "Employee Salary:";
            // 
            // button_employee_new_login
            // 
            this.button_employee_new_login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_employee_new_login.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_employee_new_login.Location = new System.Drawing.Point(312, 399);
            this.button_employee_new_login.Name = "button_employee_new_login";
            this.button_employee_new_login.Size = new System.Drawing.Size(75, 34);
            this.button_employee_new_login.TabIndex = 22;
            this.button_employee_new_login.Text = "Login";
            this.button_employee_new_login.UseVisualStyleBackColor = false;
            this.button_employee_new_login.Click += new System.EventHandler(this.button_employee_new_login_Click);
            // 
            // text_employee_new_name
            // 
            this.text_employee_new_name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_employee_new_name.Location = new System.Drawing.Point(392, 194);
            this.text_employee_new_name.Name = "text_employee_new_name";
            this.text_employee_new_name.Size = new System.Drawing.Size(147, 26);
            this.text_employee_new_name.TabIndex = 19;
            this.text_employee_new_name.TextChanged += new System.EventHandler(this.text_employee_new_name_TextChanged);
            this.text_employee_new_name.Validating += new System.ComponentModel.CancelEventHandler(this.text_employee_new_name_Validating);
            // 
            // button_employee_new_cancel
            // 
            this.button_employee_new_cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_employee_new_cancel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_employee_new_cancel.Location = new System.Drawing.Point(422, 399);
            this.button_employee_new_cancel.Name = "button_employee_new_cancel";
            this.button_employee_new_cancel.Size = new System.Drawing.Size(75, 34);
            this.button_employee_new_cancel.TabIndex = 24;
            this.button_employee_new_cancel.Text = "Cancel";
            this.button_employee_new_cancel.UseVisualStyleBackColor = false;
            this.button_employee_new_cancel.Click += new System.EventHandler(this.Button_employee_new_cancel_Click);
            // 
            // button_employee_new_clear
            // 
            this.button_employee_new_clear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_employee_new_clear.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_employee_new_clear.Location = new System.Drawing.Point(198, 399);
            this.button_employee_new_clear.Name = "button_employee_new_clear";
            this.button_employee_new_clear.Size = new System.Drawing.Size(75, 34);
            this.button_employee_new_clear.TabIndex = 23;
            this.button_employee_new_clear.Text = "Clear";
            this.button_employee_new_clear.UseVisualStyleBackColor = false;
            this.button_employee_new_clear.Click += new System.EventHandler(this.Button_employee_new_clear_Click);
            // 
            // employee_date
            // 
            this.employee_date.AutoSize = true;
            this.employee_date.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_date.Location = new System.Drawing.Point(176, 310);
            this.employee_date.Name = "employee_date";
            this.employee_date.Size = new System.Drawing.Size(134, 22);
            this.employee_date.TabIndex = 27;
            this.employee_date.Text = "Department Id:";
            // 
            // label_employee_name
            // 
            this.label_employee_name.AutoSize = true;
            this.label_employee_name.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_name.Location = new System.Drawing.Point(176, 197);
            this.label_employee_name.Name = "label_employee_name";
            this.label_employee_name.Size = new System.Drawing.Size(147, 22);
            this.label_employee_name.TabIndex = 26;
            this.label_employee_name.Text = "Employee Name:";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(244, 79);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(249, 42);
            this.label_title.TabIndex = 25;
            this.label_title.Text = "NEW EMPLOYEE";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.h_line_a;
            this.pictureBox1.Location = new System.Drawing.Point(38, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 28);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // text_employee_new_id
            // 
            this.text_employee_new_id.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_employee_new_id.Location = new System.Drawing.Point(392, 306);
            this.text_employee_new_id.Name = "text_employee_new_id";
            this.text_employee_new_id.Size = new System.Drawing.Size(147, 26);
            this.text_employee_new_id.TabIndex = 30;
            this.text_employee_new_id.TextChanged += new System.EventHandler(this.text_employee_new_id_TextChanged);
            this.text_employee_new_id.Validating += new System.ComponentModel.CancelEventHandler(this.text_employee_new_id_TextChanged);
            // 
            // error_employee_new_name
            // 
            this.error_employee_new_name.ContainerControl = this;
            // 
            // error_employee_new_salary
            // 
            this.error_employee_new_salary.ContainerControl = this;
            // 
            // error_employee_new_id
            // 
            this.error_employee_new_id.ContainerControl = this;
            // 
            // Emp_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(682, 531);
            this.Controls.Add(this.text_employee_new_id);
            this.Controls.Add(this.text_employee_new_salary);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_employee_new_login);
            this.Controls.Add(this.text_employee_new_name);
            this.Controls.Add(this.button_employee_new_cancel);
            this.Controls.Add(this.button_employee_new_clear);
            this.Controls.Add(this.employee_date);
            this.Controls.Add(this.label_employee_name);
            this.Controls.Add(this.label_title);
            this.Name = "Emp_New";
            this.Text = "emp_new";
            this.Load += new System.EventHandler(this.Emp_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_employee_new_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_employee_new_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_employee_new_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_employee_new_salary;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_employee_new_login;
        private System.Windows.Forms.TextBox text_employee_new_name;
        private System.Windows.Forms.Button button_employee_new_cancel;
        private System.Windows.Forms.Button button_employee_new_clear;
        private System.Windows.Forms.Label employee_date;
        private System.Windows.Forms.Label label_employee_name;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox text_employee_new_id;
        private System.Windows.Forms.ErrorProvider error_employee_new_name;
        private System.Windows.Forms.ErrorProvider error_employee_new_salary;
        private System.Windows.Forms.ErrorProvider error_employee_new_id;
    }
}