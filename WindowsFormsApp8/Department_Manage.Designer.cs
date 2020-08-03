namespace WindowsFormsApp8
{
    partial class Department_Manage
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
            this.text_department_modify_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_department_modify_location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_department_modify_clear = new System.Windows.Forms.Button();
            this.button_department_modify_search = new System.Windows.Forms.Button();
            this.text_department_modify_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_department_modify_id = new System.Windows.Forms.TextBox();
            this.label_departmentname = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_department_modify_delete = new System.Windows.Forms.Button();
            this.button_department_modify_cancel = new System.Windows.Forms.Button();
            this.button_department_modify_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_department_modify_name
            // 
            this.text_department_modify_name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_department_modify_name.Location = new System.Drawing.Point(390, 297);
            this.text_department_modify_name.Name = "text_department_modify_name";
            this.text_department_modify_name.Size = new System.Drawing.Size(147, 26);
            this.text_department_modify_name.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Department Name:";
            // 
            // text_department_modify_location
            // 
            this.text_department_modify_location.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_department_modify_location.Location = new System.Drawing.Point(390, 405);
            this.text_department_modify_location.Name = "text_department_modify_location";
            this.text_department_modify_location.Size = new System.Drawing.Size(147, 26);
            this.text_department_modify_location.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Department Location:";
            // 
            // button_department_modify_clear
            // 
            this.button_department_modify_clear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_department_modify_clear.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department_modify_clear.Location = new System.Drawing.Point(576, 201);
            this.button_department_modify_clear.Name = "button_department_modify_clear";
            this.button_department_modify_clear.Size = new System.Drawing.Size(75, 34);
            this.button_department_modify_clear.TabIndex = 38;
            this.button_department_modify_clear.Text = "Clear";
            this.button_department_modify_clear.UseVisualStyleBackColor = false;
            this.button_department_modify_clear.Click += new System.EventHandler(this.button_department_modify_clear_Click);
            // 
            // button_department_modify_search
            // 
            this.button_department_modify_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_department_modify_search.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department_modify_search.Location = new System.Drawing.Point(462, 201);
            this.button_department_modify_search.Name = "button_department_modify_search";
            this.button_department_modify_search.Size = new System.Drawing.Size(75, 34);
            this.button_department_modify_search.TabIndex = 39;
            this.button_department_modify_search.Text = "Search";
            this.button_department_modify_search.UseVisualStyleBackColor = false;
            this.button_department_modify_search.Click += new System.EventHandler(this.button_department_modify_search_Click);
            // 
            // text_department_modify_email
            // 
            this.text_department_modify_email.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_department_modify_email.Location = new System.Drawing.Point(390, 350);
            this.text_department_modify_email.Name = "text_department_modify_email";
            this.text_department_modify_email.Size = new System.Drawing.Size(147, 26);
            this.text_department_modify_email.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Department Email:";
            // 
            // text_department_modify_id
            // 
            this.text_department_modify_id.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_department_modify_id.Location = new System.Drawing.Point(275, 209);
            this.text_department_modify_id.Name = "text_department_modify_id";
            this.text_department_modify_id.Size = new System.Drawing.Size(147, 26);
            this.text_department_modify_id.TabIndex = 34;
            // 
            // label_departmentname
            // 
            this.label_departmentname.AutoSize = true;
            this.label_departmentname.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_departmentname.Location = new System.Drawing.Point(67, 212);
            this.label_departmentname.Name = "label_departmentname";
            this.label_departmentname.Size = new System.Drawing.Size(134, 22);
            this.label_departmentname.TabIndex = 36;
            this.label_departmentname.Text = "Department Id:";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(187, 79);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(340, 42);
            this.label_title.TabIndex = 32;
            this.label_title.Text = "DEPARTMENT MODIFY";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.h_line_a;
            this.pictureBox1.Location = new System.Drawing.Point(53, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 28);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // button_department_modify_delete
            // 
            this.button_department_modify_delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_department_modify_delete.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department_modify_delete.Location = new System.Drawing.Point(314, 485);
            this.button_department_modify_delete.Name = "button_department_modify_delete";
            this.button_department_modify_delete.Size = new System.Drawing.Size(93, 34);
            this.button_department_modify_delete.TabIndex = 44;
            this.button_department_modify_delete.Text = "Delete";
            this.button_department_modify_delete.UseVisualStyleBackColor = false;
            this.button_department_modify_delete.Click += new System.EventHandler(this.button_department_modify_delete_Click);
            // 
            // button_department_modify_cancel
            // 
            this.button_department_modify_cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_department_modify_cancel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department_modify_cancel.Location = new System.Drawing.Point(440, 485);
            this.button_department_modify_cancel.Name = "button_department_modify_cancel";
            this.button_department_modify_cancel.Size = new System.Drawing.Size(98, 34);
            this.button_department_modify_cancel.TabIndex = 46;
            this.button_department_modify_cancel.Text = "Cancel";
            this.button_department_modify_cancel.UseVisualStyleBackColor = false;
            this.button_department_modify_cancel.Click += new System.EventHandler(this.button_department_modify_cancel_Click);
            // 
            // button_department_modify_update
            // 
            this.button_department_modify_update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_department_modify_update.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department_modify_update.Location = new System.Drawing.Point(180, 485);
            this.button_department_modify_update.Name = "button_department_modify_update";
            this.button_department_modify_update.Size = new System.Drawing.Size(96, 34);
            this.button_department_modify_update.TabIndex = 45;
            this.button_department_modify_update.Text = "Update";
            this.button_department_modify_update.UseVisualStyleBackColor = false;
            this.button_department_modify_update.Click += new System.EventHandler(this.button_department_modify_update_Click);
            // 
            // Department_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(704, 582);
            this.Controls.Add(this.button_department_modify_delete);
            this.Controls.Add(this.button_department_modify_cancel);
            this.Controls.Add(this.button_department_modify_update);
            this.Controls.Add(this.text_department_modify_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_department_modify_location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_department_modify_clear);
            this.Controls.Add(this.button_department_modify_search);
            this.Controls.Add(this.text_department_modify_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_department_modify_id);
            this.Controls.Add(this.label_departmentname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_title);
            this.Name = "Department_Manage";
            this.Text = "Department_Manage";
            this.Load += new System.EventHandler(this.Emp_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_department_modify_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_department_modify_location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_department_modify_clear;
        private System.Windows.Forms.Button button_department_modify_search;
        private System.Windows.Forms.TextBox text_department_modify_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_department_modify_id;
        private System.Windows.Forms.Label label_departmentname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_department_modify_delete;
        private System.Windows.Forms.Button button_department_modify_cancel;
        private System.Windows.Forms.Button button_department_modify_update;
    }
}