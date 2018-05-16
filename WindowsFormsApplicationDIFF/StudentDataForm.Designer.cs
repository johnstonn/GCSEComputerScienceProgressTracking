namespace StudentTrackerNS
{
    partial class StudentDataForm
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
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvStudentProgress = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAverageM1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalM1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAverageVA = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNatAvgMK1 = new System.Windows.Forms.TextBox();
            this.txtNatAverageGrade1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAvgGM1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNatAvgGrade2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNatAvgMK2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNatAverageGrade2 = new System.Windows.Forms.TextBox();
            this.txtAvgGM2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalM2 = new System.Windows.Forms.TextBox();
            this.txtAverageM2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnMale = new System.Windows.Forms.Button();
            this.btnFemale = new System.Windows.Forms.Button();
            this.btnEAL = new System.Windows.Forms.Button();
            this.btnDisadvantaged = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentProgress)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(209, 398);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(103, 45);
            this.btnPopulate.TabIndex = 0;
            this.btnPopulate.Text = "Populate All";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulateFullClass_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(318, 398);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 44);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvStudentProgress
            // 
            this.dgvStudentProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentProgress.Location = new System.Drawing.Point(46, 73);
            this.dgvStudentProgress.Name = "dgvStudentProgress";
            this.dgvStudentProgress.Size = new System.Drawing.Size(1173, 303);
            this.dgvStudentProgress.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(100, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 44);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAverageM1
            // 
            this.txtAverageM1.Location = new System.Drawing.Point(113, 43);
            this.txtAverageM1.Name = "txtAverageM1";
            this.txtAverageM1.Size = new System.Drawing.Size(53, 20);
            this.txtAverageM1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total of Mock 1";
            // 
            // txtTotalM1
            // 
            this.txtTotalM1.Location = new System.Drawing.Point(113, 18);
            this.txtTotalM1.Name = "txtTotalM1";
            this.txtTotalM1.Size = new System.Drawing.Size(53, 20);
            this.txtTotalM1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Average of Mock 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAverageVA);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(436, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overview";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Average Value Added";
            // 
            // txtAverageVA
            // 
            this.txtAverageVA.Location = new System.Drawing.Point(134, 25);
            this.txtAverageVA.Name = "txtAverageVA";
            this.txtAverageVA.Size = new System.Drawing.Size(53, 20);
            this.txtAverageVA.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNatAvgMK1);
            this.groupBox3.Controls.Add(this.txtTotalM1);
            this.groupBox3.Controls.Add(this.txtNatAverageGrade1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtAverageM1);
            this.groupBox3.Controls.Add(this.txtAvgGM1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(220, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 146);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mock 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "National Avg. Grade";
            // 
            // txtNatAvgMK1
            // 
            this.txtNatAvgMK1.Location = new System.Drawing.Point(115, 96);
            this.txtNatAvgMK1.Name = "txtNatAvgMK1";
            this.txtNatAvgMK1.Size = new System.Drawing.Size(53, 20);
            this.txtNatAvgMK1.TabIndex = 19;
            // 
            // txtNatAverageGrade1
            // 
            this.txtNatAverageGrade1.Location = new System.Drawing.Point(115, 120);
            this.txtNatAverageGrade1.Name = "txtNatAverageGrade1";
            this.txtNatAverageGrade1.Size = new System.Drawing.Size(53, 20);
            this.txtNatAverageGrade1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Avg. Grade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "National Avg. mk 1";
            // 
            // txtAvgGM1
            // 
            this.txtAvgGM1.Location = new System.Drawing.Point(113, 67);
            this.txtAvgGM1.Name = "txtAvgGM1";
            this.txtAvgGM1.Size = new System.Drawing.Size(53, 20);
            this.txtAvgGM1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNatAvgGrade2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNatAvgMK2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNatAverageGrade2);
            this.groupBox2.Controls.Add(this.txtAvgGM2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTotalM2);
            this.groupBox2.Controls.Add(this.txtAverageM2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(401, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 146);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mock 2";
            // 
            // txtNatAvgGrade2
            // 
            this.txtNatAvgGrade2.AutoSize = true;
            this.txtNatAvgGrade2.Location = new System.Drawing.Point(7, 123);
            this.txtNatAvgGrade2.Name = "txtNatAvgGrade2";
            this.txtNatAvgGrade2.Size = new System.Drawing.Size(103, 13);
            this.txtNatAvgGrade2.TabIndex = 26;
            this.txtNatAvgGrade2.Text = "National Avg. Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Avg. Grade";
            // 
            // txtNatAvgMK2
            // 
            this.txtNatAvgMK2.Location = new System.Drawing.Point(116, 96);
            this.txtNatAvgMK2.Name = "txtNatAvgMK2";
            this.txtNatAvgMK2.Size = new System.Drawing.Size(53, 20);
            this.txtNatAvgMK2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total of Mock 2";
            // 
            // txtNatAverageGrade2
            // 
            this.txtNatAverageGrade2.Location = new System.Drawing.Point(116, 120);
            this.txtNatAverageGrade2.Name = "txtNatAverageGrade2";
            this.txtNatAverageGrade2.Size = new System.Drawing.Size(53, 20);
            this.txtNatAverageGrade2.TabIndex = 25;
            // 
            // txtAvgGM2
            // 
            this.txtAvgGM2.Location = new System.Drawing.Point(115, 67);
            this.txtAvgGM2.Name = "txtAvgGM2";
            this.txtAvgGM2.Size = new System.Drawing.Size(53, 20);
            this.txtAvgGM2.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "National Avg. mk 2";
            // 
            // txtTotalM2
            // 
            this.txtTotalM2.Location = new System.Drawing.Point(115, 17);
            this.txtTotalM2.Name = "txtTotalM2";
            this.txtTotalM2.Size = new System.Drawing.Size(53, 20);
            this.txtTotalM2.TabIndex = 11;
            // 
            // txtAverageM2
            // 
            this.txtAverageM2.Location = new System.Drawing.Point(115, 42);
            this.txtAverageM2.Name = "txtAverageM2";
            this.txtAverageM2.Size = new System.Drawing.Size(53, 20);
            this.txtAverageM2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Average of Mock 2";
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(525, 11);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(219, 23);
            this.cmbClass.TabIndex = 9;
            this.cmbClass.Text = "Class A";
            // 
            // btnMale
            // 
            this.btnMale.Location = new System.Drawing.Point(63, 24);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(51, 51);
            this.btnMale.TabIndex = 10;
            this.btnMale.Text = "Male Data";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.Click += new System.EventHandler(this.btnMale_Click);
            // 
            // btnFemale
            // 
            this.btnFemale.Location = new System.Drawing.Point(6, 24);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(51, 51);
            this.btnFemale.TabIndex = 11;
            this.btnFemale.Text = "Female Data";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // btnEAL
            // 
            this.btnEAL.Location = new System.Drawing.Point(120, 24);
            this.btnEAL.Name = "btnEAL";
            this.btnEAL.Size = new System.Drawing.Size(51, 51);
            this.btnEAL.TabIndex = 12;
            this.btnEAL.Text = "EAL Data";
            this.btnEAL.UseVisualStyleBackColor = true;
            this.btnEAL.Click += new System.EventHandler(this.btnEAL_Click);
            // 
            // btnDisadvantaged
            // 
            this.btnDisadvantaged.Location = new System.Drawing.Point(177, 24);
            this.btnDisadvantaged.Name = "btnDisadvantaged";
            this.btnDisadvantaged.Size = new System.Drawing.Size(51, 51);
            this.btnDisadvantaged.TabIndex = 13;
            this.btnDisadvantaged.Text = "Disadv data";
            this.btnDisadvantaged.UseVisualStyleBackColor = true;
            this.btnDisadvantaged.Click += new System.EventHandler(this.btnDisadvantaged_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFemale);
            this.groupBox4.Controls.Add(this.btnDisadvantaged);
            this.groupBox4.Controls.Add(this.btnMale);
            this.groupBox4.Controls.Add(this.btnEAL);
            this.groupBox4.Location = new System.Drawing.Point(100, 463);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 116);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query Data";
            // 
            // StudentDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 643);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvStudentProgress);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPopulate);
            this.Name = "StudentDataForm";
            this.Text = "Student Tracker";
            this.Load += new System.EventHandler(this.StudentDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentProgress)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dgvStudentProgress;
        public System.Windows.Forms.TextBox txtAverageM1;
        public System.Windows.Forms.TextBox txtTotalM1;
        public System.Windows.Forms.TextBox txtAverageM2;
        public System.Windows.Forms.TextBox txtTotalM2;
        public System.Windows.Forms.TextBox txtAvgGM2;
        public System.Windows.Forms.TextBox txtAvgGM1;
        public System.Windows.Forms.TextBox txtAverageVA;
        public System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnMale;
        private System.Windows.Forms.Button btnFemale;
        private System.Windows.Forms.Button btnEAL;
        private System.Windows.Forms.Button btnDisadvantaged;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtNatAvgMK1;
        public System.Windows.Forms.TextBox txtNatAverageGrade1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtNatAvgGrade2;
        public System.Windows.Forms.TextBox txtNatAvgMK2;
        public System.Windows.Forms.TextBox txtNatAverageGrade2;
        private System.Windows.Forms.Label label11;
    }
}

