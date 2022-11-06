namespace Marathon
{
    partial class auth_form
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.log_in = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.to_main = new System.Windows.Forms.Label();
            this.to_sign_in = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.email_txtbox);
            this.flowLayoutPanel1.Controls.Add(this.password_txtbox);
            this.flowLayoutPanel1.Controls.Add(this.log_in);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 92);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // email_txtbox
            // 
            this.email_txtbox.Location = new System.Drawing.Point(3, 3);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(197, 20);
            this.email_txtbox.TabIndex = 4;
            this.email_txtbox.Text = "E-mail";
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(3, 29);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(197, 20);
            this.password_txtbox.TabIndex = 5;
            this.password_txtbox.Text = "Password";
            this.password_txtbox.UseSystemPasswordChar = true;
            // 
            // log_in
            // 
            this.log_in.Location = new System.Drawing.Point(60, 55);
            this.log_in.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(75, 23);
            this.log_in.TabIndex = 11;
            this.log_in.Text = "Log in";
            this.log_in.UseVisualStyleBackColor = true;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.to_main);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 100);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(100, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Authorization";
            // 
            // to_main
            // 
            this.to_main.AutoSize = true;
            this.to_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_main.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_main.ForeColor = System.Drawing.SystemColors.Control;
            this.to_main.Location = new System.Drawing.Point(105, 9);
            this.to_main.Name = "to_main";
            this.to_main.Size = new System.Drawing.Size(117, 21);
            this.to_main.TabIndex = 0;
            this.to_main.Text = "Marathon 2022";
            this.to_main.Click += new System.EventHandler(this.to_main_Click);
            // 
            // to_sign_in
            // 
            this.to_sign_in.AutoSize = true;
            this.to_sign_in.Location = new System.Drawing.Point(141, 201);
            this.to_sign_in.Name = "to_sign_in";
            this.to_sign_in.Size = new System.Drawing.Size(39, 13);
            this.to_sign_in.TabIndex = 6;
            this.to_sign_in.Text = "Sign in";
            this.to_sign_in.Click += new System.EventHandler(this.to_sign_in_Click);
            // 
            // auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 233);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.to_sign_in);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "auth_form";
            this.ShowIcon = false;
            this.Text = "Authorization";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label to_main;
        private System.Windows.Forms.Label to_sign_in;
    }
}