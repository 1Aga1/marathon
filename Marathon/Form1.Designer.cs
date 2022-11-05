namespace Marathon
{
    partial class main_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.new_runner_btn = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(89, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marathon 2022";
            // 
            // new_runner_btn
            // 
            this.new_runner_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_runner_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.new_runner_btn.Location = new System.Drawing.Point(66, 127);
            this.new_runner_btn.Name = "new_runner_btn";
            this.new_runner_btn.Size = new System.Drawing.Size(198, 35);
            this.new_runner_btn.TabIndex = 1;
            this.new_runner_btn.Text = "Стать бегуном";
            this.new_runner_btn.UseVisualStyleBackColor = true;
            this.new_runner_btn.Click += new System.EventHandler(this.new_runner_btn_Click);
            // 
            // about
            // 
            this.about.Cursor = System.Windows.Forms.Cursors.Help;
            this.about.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.about.Location = new System.Drawing.Point(66, 185);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(198, 35);
            this.about.TabIndex = 3;
            this.about.Text = "О событии";
            this.about.UseVisualStyleBackColor = true;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(339, 254);
            this.Controls.Add(this.about);
            this.Controls.Add(this.new_runner_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.ShowIcon = false;
            this.Text = "Marathon 2022";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button new_runner_btn;
        private System.Windows.Forms.Button about;
    }
}

