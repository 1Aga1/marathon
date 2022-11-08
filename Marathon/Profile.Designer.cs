namespace Marathon
{
    partial class Profile
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.to_main = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save_profile_btn = new System.Windows.Forms.Button();
            this.load_img_btn = new System.Windows.Forms.Button();
            this.profile_avatar = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.lable3 = new System.Windows.Forms.Label();
            this.height_txtbox = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.weight_txtbox = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.full_name_txtbox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.gender_txtbox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.birthday_txtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_avatar)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height_txtbox)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_txtbox)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.to_main);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 100);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(431, 344);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(148, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Профиль";
            // 
            // to_main
            // 
            this.to_main.AutoSize = true;
            this.to_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_main.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_main.ForeColor = System.Drawing.SystemColors.Control;
            this.to_main.Location = new System.Drawing.Point(136, 17);
            this.to_main.Name = "to_main";
            this.to_main.Size = new System.Drawing.Size(117, 21);
            this.to_main.TabIndex = 0;
            this.to_main.Text = "Marathon 2022";
            this.to_main.Click += new System.EventHandler(this.to_main_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.save_profile_btn);
            this.panel2.Controls.Add(this.load_img_btn);
            this.panel2.Controls.Add(this.profile_avatar);
            this.panel2.Controls.Add(this.flowLayoutPanel7);
            this.panel2.Controls.Add(this.flowLayoutPanel6);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.flowLayoutPanel5);
            this.panel2.Controls.Add(this.flowLayoutPanel4);
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 291);
            this.panel2.TabIndex = 6;
            // 
            // save_profile_btn
            // 
            this.save_profile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_profile_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.save_profile_btn.Location = new System.Drawing.Point(140, 255);
            this.save_profile_btn.Name = "save_profile_btn";
            this.save_profile_btn.Size = new System.Drawing.Size(83, 24);
            this.save_profile_btn.TabIndex = 7;
            this.save_profile_btn.Text = "Сохранить";
            this.save_profile_btn.UseVisualStyleBackColor = true;
            this.save_profile_btn.Click += new System.EventHandler(this.save_profile_btn_Click);
            // 
            // load_img_btn
            // 
            this.load_img_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_img_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.load_img_btn.Location = new System.Drawing.Point(49, 103);
            this.load_img_btn.Name = "load_img_btn";
            this.load_img_btn.Size = new System.Drawing.Size(83, 24);
            this.load_img_btn.TabIndex = 6;
            this.load_img_btn.Text = "Загрузить";
            this.load_img_btn.UseVisualStyleBackColor = true;
            this.load_img_btn.Click += new System.EventHandler(this.load_img_btn_Click);
            // 
            // profile_avatar
            // 
            this.profile_avatar.Image = global::Marathon.Properties.Resources.users_defoult;
            this.profile_avatar.Location = new System.Drawing.Point(29, 3);
            this.profile_avatar.Name = "profile_avatar";
            this.profile_avatar.Size = new System.Drawing.Size(128, 94);
            this.profile_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_avatar.TabIndex = 5;
            this.profile_avatar.TabStop = false;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.lable3);
            this.flowLayoutPanel7.Controls.Add(this.height_txtbox);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(12, 202);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(165, 47);
            this.flowLayoutPanel7.TabIndex = 4;
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.lable3.Location = new System.Drawing.Point(3, 0);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(35, 18);
            this.lable3.TabIndex = 0;
            this.lable3.Text = "Рост";
            // 
            // height_txtbox
            // 
            this.height_txtbox.DecimalPlaces = 1;
            this.height_txtbox.Location = new System.Drawing.Point(3, 21);
            this.height_txtbox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.height_txtbox.Name = "height_txtbox";
            this.height_txtbox.Size = new System.Drawing.Size(162, 20);
            this.height_txtbox.TabIndex = 9;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label5);
            this.flowLayoutPanel6.Controls.Add(this.weight_txtbox);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(12, 144);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(165, 47);
            this.flowLayoutPanel6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Вес";
            // 
            // weight_txtbox
            // 
            this.weight_txtbox.DecimalPlaces = 1;
            this.weight_txtbox.Location = new System.Drawing.Point(3, 21);
            this.weight_txtbox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weight_txtbox.Name = "weight_txtbox";
            this.weight_txtbox.Size = new System.Drawing.Size(162, 20);
            this.weight_txtbox.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.full_name_txtbox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(196, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(165, 47);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // full_name_txtbox
            // 
            this.full_name_txtbox.Location = new System.Drawing.Point(3, 21);
            this.full_name_txtbox.Name = "full_name_txtbox";
            this.full_name_txtbox.ReadOnly = true;
            this.full_name_txtbox.Size = new System.Drawing.Size(156, 20);
            this.full_name_txtbox.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.email_txtbox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(196, 162);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(165, 47);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // email_txtbox
            // 
            this.email_txtbox.Location = new System.Drawing.Point(3, 21);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.ReadOnly = true;
            this.email_txtbox.Size = new System.Drawing.Size(156, 20);
            this.email_txtbox.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label4);
            this.flowLayoutPanel5.Controls.Add(this.gender_txtbox);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(196, 109);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(165, 47);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пол";
            // 
            // gender_txtbox
            // 
            this.gender_txtbox.Location = new System.Drawing.Point(3, 21);
            this.gender_txtbox.Name = "gender_txtbox";
            this.gender_txtbox.ReadOnly = true;
            this.gender_txtbox.Size = new System.Drawing.Size(156, 20);
            this.gender_txtbox.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label);
            this.flowLayoutPanel4.Controls.Add(this.birthday_txtbox);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(196, 56);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(165, 47);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(102, 18);
            this.label.TabIndex = 0;
            this.label.Text = "Дата рождения";
            // 
            // birthday_txtbox
            // 
            this.birthday_txtbox.Location = new System.Drawing.Point(3, 21);
            this.birthday_txtbox.Name = "birthday_txtbox";
            this.birthday_txtbox.ReadOnly = true;
            this.birthday_txtbox.Size = new System.Drawing.Size(156, 20);
            this.birthday_txtbox.TabIndex = 1;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.ShowIcon = false;
            this.Text = "Profile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_avatar)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height_txtbox)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_txtbox)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label to_main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox full_name_txtbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gender_txtbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox birthday_txtbox;
        private System.Windows.Forms.PictureBox profile_avatar;
        private System.Windows.Forms.Button load_img_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save_profile_btn;
        private System.Windows.Forms.NumericUpDown height_txtbox;
        private System.Windows.Forms.NumericUpDown weight_txtbox;
    }
}