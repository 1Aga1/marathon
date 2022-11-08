namespace Marathon
{
    partial class Bmi_calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.to_main = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.calc_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.bmi_txtbox = new System.Windows.Forms.TextBox();
            this.female_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.male_btn = new System.Windows.Forms.Button();
            this.dataSet1 = new Marathon.DataSet1();
            this.runnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runnersTableAdapter = new Marathon.DataSet1TableAdapters.runnersTableAdapter();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.result_txtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.height_txtbox = new System.Windows.Forms.NumericUpDown();
            this.weight_txtbox = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersBindingSource)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_txtbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_txtbox)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(555, 100);
            this.panel1.TabIndex = 3;
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
            this.label2.Location = new System.Drawing.Point(197, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "BMI калькулятор";
            // 
            // to_main
            // 
            this.to_main.AutoSize = true;
            this.to_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_main.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_main.ForeColor = System.Drawing.SystemColors.Control;
            this.to_main.Location = new System.Drawing.Point(224, 14);
            this.to_main.Name = "to_main";
            this.to_main.Size = new System.Drawing.Size(117, 21);
            this.to_main.TabIndex = 0;
            this.to_main.Text = "Marathon 2022";
            this.to_main.Click += new System.EventHandler(this.to_main_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Индекс массы тела - величина, позволяющая оценить степень соответствия массы чело" +
    "века и его роста\r\n и тем самым косвенно судить о том, является ли масса недостат" +
    "очной, нормальной или избыточной";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.calc_btn);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.flowLayoutPanel4);
            this.panel4.Controls.Add(this.flowLayoutPanel3);
            this.panel4.Controls.Add(this.female_btn);
            this.panel4.Controls.Add(this.flowLayoutPanel2);
            this.panel4.Controls.Add(this.male_btn);
            this.panel4.Location = new System.Drawing.Point(0, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 258);
            this.panel4.TabIndex = 5;
            // 
            // calc_btn
            // 
            this.calc_btn.Location = new System.Drawing.Point(76, 223);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(75, 23);
            this.calc_btn.TabIndex = 6;
            this.calc_btn.Text = "Рассчитать";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.height_txtbox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(60, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(112, 43);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Рост";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.bmi_txtbox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(260, 169);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(114, 43);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "BMI";
            // 
            // bmi_txtbox
            // 
            this.bmi_txtbox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bmi_txtbox.Location = new System.Drawing.Point(3, 16);
            this.bmi_txtbox.Name = "bmi_txtbox";
            this.bmi_txtbox.ReadOnly = true;
            this.bmi_txtbox.Size = new System.Drawing.Size(100, 20);
            this.bmi_txtbox.TabIndex = 0;
            // 
            // female_btn
            // 
            this.female_btn.CausesValidation = false;
            this.female_btn.Image = global::Marathon.Properties.Resources.female_icon;
            this.female_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.female_btn.Location = new System.Drawing.Point(128, 13);
            this.female_btn.Name = "female_btn";
            this.female_btn.Size = new System.Drawing.Size(100, 78);
            this.female_btn.TabIndex = 3;
            this.female_btn.Text = "Женский";
            this.female_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.female_btn.UseVisualStyleBackColor = true;
            this.female_btn.Click += new System.EventHandler(this.female_btn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.weight_txtbox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(60, 169);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(112, 43);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Вес";
            // 
            // male_btn
            // 
            this.male_btn.CausesValidation = false;
            this.male_btn.Image = global::Marathon.Properties.Resources.male_icon;
            this.male_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.male_btn.Location = new System.Drawing.Point(12, 13);
            this.male_btn.Name = "male_btn";
            this.male_btn.Size = new System.Drawing.Size(100, 78);
            this.male_btn.TabIndex = 2;
            this.male_btn.Text = "Мужской";
            this.male_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.male_btn.UseVisualStyleBackColor = true;
            this.male_btn.Click += new System.EventHandler(this.male_btn_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // runnersBindingSource
            // 
            this.runnersBindingSource.DataMember = "runners";
            this.runnersBindingSource.DataSource = this.dataSet1;
            // 
            // runnersTableAdapter
            // 
            this.runnersTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.result_txtbox);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(406, 169);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(114, 43);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Результат";
            // 
            // result_txtbox
            // 
            this.result_txtbox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.result_txtbox.Location = new System.Drawing.Point(3, 16);
            this.result_txtbox.Name = "result_txtbox";
            this.result_txtbox.ReadOnly = true;
            this.result_txtbox.Size = new System.Drawing.Size(100, 20);
            this.result_txtbox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(315, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // height_txtbox
            // 
            this.height_txtbox.DecimalPlaces = 1;
            this.height_txtbox.Location = new System.Drawing.Point(3, 16);
            this.height_txtbox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.height_txtbox.Name = "height_txtbox";
            this.height_txtbox.Size = new System.Drawing.Size(109, 20);
            this.height_txtbox.TabIndex = 8;
            // 
            // weight_txtbox
            // 
            this.weight_txtbox.DecimalPlaces = 1;
            this.weight_txtbox.Location = new System.Drawing.Point(3, 16);
            this.weight_txtbox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weight_txtbox.Name = "weight_txtbox";
            this.weight_txtbox.Size = new System.Drawing.Size(109, 20);
            this.weight_txtbox.TabIndex = 9;
            // 
            // Bmi_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 390);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Bmi_calculator";
            this.ShowIcon = false;
            this.Text = "BMI калькулятор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersBindingSource)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_txtbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_txtbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label to_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource runnersBindingSource;
        private DataSet1TableAdapters.runnersTableAdapter runnersTableAdapter;
        private System.Windows.Forms.Button male_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button female_btn;
        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bmi_txtbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox result_txtbox;
        private System.Windows.Forms.NumericUpDown height_txtbox;
        private System.Windows.Forms.NumericUpDown weight_txtbox;
    }
}