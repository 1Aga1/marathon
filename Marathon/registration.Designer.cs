namespace Marathon
{
    partial class reg_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.to_main = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.full_name_txtbox = new System.Windows.Forms.TextBox();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.confirm_password_txtbox = new System.Windows.Forms.TextBox();
            this.date_birth_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.gender_txtbox = new System.Windows.Forms.ComboBox();
            this.country_txtbox = new System.Windows.Forms.ComboBox();
            this.sign_in = new System.Windows.Forms.Button();
            this.to_log_in = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.to_main);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(100, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Регистрация";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.full_name_txtbox);
            this.flowLayoutPanel1.Controls.Add(this.email_txtbox);
            this.flowLayoutPanel1.Controls.Add(this.password_txtbox);
            this.flowLayoutPanel1.Controls.Add(this.confirm_password_txtbox);
            this.flowLayoutPanel1.Controls.Add(this.date_birth_txtbox);
            this.flowLayoutPanel1.Controls.Add(this.gender_txtbox);
            this.flowLayoutPanel1.Controls.Add(this.country_txtbox);
            this.flowLayoutPanel1.Controls.Add(this.sign_in);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 317);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.users_defoult;
            this.pictureBox1.Location = new System.Drawing.Point(50, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // full_name_txtbox
            // 
            this.full_name_txtbox.Location = new System.Drawing.Point(3, 105);
            this.full_name_txtbox.Name = "full_name_txtbox";
            this.full_name_txtbox.Size = new System.Drawing.Size(197, 20);
            this.full_name_txtbox.TabIndex = 3;
            this.full_name_txtbox.Text = "ФИО";
            // 
            // email_txtbox
            // 
            this.email_txtbox.Location = new System.Drawing.Point(3, 131);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(197, 20);
            this.email_txtbox.TabIndex = 4;
            this.email_txtbox.Text = "E-mail";
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(3, 157);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(197, 20);
            this.password_txtbox.TabIndex = 5;
            this.password_txtbox.Text = "Password";
            this.password_txtbox.UseSystemPasswordChar = true;
            // 
            // confirm_password_txtbox
            // 
            this.confirm_password_txtbox.Location = new System.Drawing.Point(3, 183);
            this.confirm_password_txtbox.Name = "confirm_password_txtbox";
            this.confirm_password_txtbox.Size = new System.Drawing.Size(197, 20);
            this.confirm_password_txtbox.TabIndex = 6;
            this.confirm_password_txtbox.Text = "Password";
            this.confirm_password_txtbox.UseSystemPasswordChar = true;
            // 
            // date_birth_txtbox
            // 
            this.date_birth_txtbox.Location = new System.Drawing.Point(3, 209);
            this.date_birth_txtbox.Mask = "00/00/0000";
            this.date_birth_txtbox.Name = "date_birth_txtbox";
            this.date_birth_txtbox.Size = new System.Drawing.Size(197, 20);
            this.date_birth_txtbox.TabIndex = 8;
            this.date_birth_txtbox.ValidatingType = typeof(System.DateTime);
            // 
            // gender_txtbox
            // 
            this.gender_txtbox.FormattingEnabled = true;
            this.gender_txtbox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.gender_txtbox.Location = new System.Drawing.Point(3, 235);
            this.gender_txtbox.Name = "gender_txtbox";
            this.gender_txtbox.Size = new System.Drawing.Size(197, 21);
            this.gender_txtbox.TabIndex = 9;
            this.gender_txtbox.Text = "Пол";
            // 
            // country_txtbox
            // 
            this.country_txtbox.FormattingEnabled = true;
            this.country_txtbox.Items.AddRange(new object[] {
            "Россия",
            "США",
            "Бразилия",
            "Япония",
            "Китай"});
            this.country_txtbox.Location = new System.Drawing.Point(3, 262);
            this.country_txtbox.Name = "country_txtbox";
            this.country_txtbox.Size = new System.Drawing.Size(197, 21);
            this.country_txtbox.TabIndex = 10;
            this.country_txtbox.Text = "Страна";
            // 
            // sign_in
            // 
            this.sign_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_in.Location = new System.Drawing.Point(35, 289);
            this.sign_in.Margin = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(125, 23);
            this.sign_in.TabIndex = 11;
            this.sign_in.Text = "Зарегистрироваться";
            this.sign_in.UseVisualStyleBackColor = true;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // to_log_in
            // 
            this.to_log_in.AutoSize = true;
            this.to_log_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_log_in.Location = new System.Drawing.Point(123, 426);
            this.to_log_in.Name = "to_log_in";
            this.to_log_in.Size = new System.Drawing.Size(73, 13);
            this.to_log_in.TabIndex = 3;
            this.to_log_in.Text = "Авторизация";
            this.to_log_in.Click += new System.EventHandler(this.to_log_in_Click);
            // 
            // reg_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.to_log_in);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "reg_form";
            this.ShowIcon = false;
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label to_main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox full_name_txtbox;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox confirm_password_txtbox;
        private System.Windows.Forms.MaskedTextBox date_birth_txtbox;
        private System.Windows.Forms.ComboBox gender_txtbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox country_txtbox;
        private System.Windows.Forms.Button sign_in;
        private System.Windows.Forms.Label to_log_in;
    }
}