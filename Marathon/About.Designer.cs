namespace Marathon
{
    partial class About
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.to_main = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.charity_organizations = new System.Windows.Forms.Button();
            this.marathon_time_btn = new System.Windows.Forms.Button();
            this.bmi_btn = new System.Windows.Forms.Button();
            this.bmr_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.to_main);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(104, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "О марафоне";
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
            // panel4
            // 
            this.panel4.Controls.Add(this.charity_organizations);
            this.panel4.Controls.Add(this.marathon_time_btn);
            this.panel4.Controls.Add(this.bmi_btn);
            this.panel4.Controls.Add(this.bmr_btn);
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 206);
            this.panel4.TabIndex = 3;
            // 
            // charity_organizations
            // 
            this.charity_organizations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.charity_organizations.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.charity_organizations.Location = new System.Drawing.Point(71, 132);
            this.charity_organizations.Name = "charity_organizations";
            this.charity_organizations.Size = new System.Drawing.Size(198, 57);
            this.charity_organizations.TabIndex = 9;
            this.charity_organizations.Text = "Благотворительные организации";
            this.charity_organizations.UseVisualStyleBackColor = true;
            this.charity_organizations.Click += new System.EventHandler(this.charity_organizations_Click);
            // 
            // marathon_time_btn
            // 
            this.marathon_time_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.marathon_time_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.marathon_time_btn.Location = new System.Drawing.Point(71, 9);
            this.marathon_time_btn.Name = "marathon_time_btn";
            this.marathon_time_btn.Size = new System.Drawing.Size(198, 35);
            this.marathon_time_btn.TabIndex = 8;
            this.marathon_time_btn.Text = "Длительность марафона";
            this.marathon_time_btn.UseVisualStyleBackColor = true;
            this.marathon_time_btn.Click += new System.EventHandler(this.marathon_time_btn_Click);
            // 
            // bmi_btn
            // 
            this.bmi_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmi_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.bmi_btn.Location = new System.Drawing.Point(71, 91);
            this.bmi_btn.Name = "bmi_btn";
            this.bmi_btn.Size = new System.Drawing.Size(198, 35);
            this.bmi_btn.TabIndex = 7;
            this.bmi_btn.Text = "BMI Калькулятор";
            this.bmi_btn.UseVisualStyleBackColor = true;
            this.bmi_btn.Click += new System.EventHandler(this.bmi_btn_Click);
            // 
            // bmr_btn
            // 
            this.bmr_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmr_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.bmr_btn.Location = new System.Drawing.Point(71, 50);
            this.bmr_btn.Name = "bmr_btn";
            this.bmr_btn.Size = new System.Drawing.Size(198, 35);
            this.bmr_btn.TabIndex = 6;
            this.bmr_btn.Text = "BMR Калькулятор";
            this.bmr_btn.UseVisualStyleBackColor = true;
            this.bmr_btn.Click += new System.EventHandler(this.bmr_btn_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 307);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label to_main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button charity_organizations;
        private System.Windows.Forms.Button marathon_time_btn;
        private System.Windows.Forms.Button bmi_btn;
        private System.Windows.Forms.Button bmr_btn;
    }
}