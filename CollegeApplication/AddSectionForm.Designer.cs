namespace CollegeApplication
{
    partial class AddSectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSectionId = new System.Windows.Forms.TextBox();
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.numMaxNoOfStudents = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddingCourse = new System.Windows.Forms.TextBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxNoOfStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Section ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max No. of Students";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester";
            // 
            // txtSectionId
            // 
            this.txtSectionId.Location = new System.Drawing.Point(157, 42);
            this.txtSectionId.Name = "txtSectionId";
            this.txtSectionId.Size = new System.Drawing.Size(283, 25);
            this.txtSectionId.TabIndex = 1;
            this.txtSectionId.TextChanged += new System.EventHandler(this.txtSectionId_TextChanged);
            // 
            // txtSectionName
            // 
            this.txtSectionName.Location = new System.Drawing.Point(157, 97);
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(283, 25);
            this.txtSectionName.TabIndex = 2;
            this.txtSectionName.TextChanged += new System.EventHandler(this.txtSectionName_TextChanged);
            // 
            // numMaxNoOfStudents
            // 
            this.numMaxNoOfStudents.Location = new System.Drawing.Point(234, 211);
            this.numMaxNoOfStudents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxNoOfStudents.Name = "numMaxNoOfStudents";
            this.numMaxNoOfStudents.Size = new System.Drawing.Size(206, 25);
            this.numMaxNoOfStudents.TabIndex = 4;
            this.numMaxNoOfStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaxNoOfStudents.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(332, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 43);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(157, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 43);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Added to";
            // 
            // txtAddingCourse
            // 
            this.txtAddingCourse.Enabled = false;
            this.txtAddingCourse.Location = new System.Drawing.Point(157, 271);
            this.txtAddingCourse.Name = "txtAddingCourse";
            this.txtAddingCourse.Size = new System.Drawing.Size(283, 25);
            this.txtAddingCourse.TabIndex = 5;
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "Fall",
            "Winter",
            "Summer"});
            this.cmbSemester.Location = new System.Drawing.Point(157, 151);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(283, 26);
            this.cmbSemester.TabIndex = 3;
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 426);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.txtAddingCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.numMaxNoOfStudents);
            this.Controls.Add(this.txtSectionName);
            this.Controls.Add(this.txtSectionId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSectionForm";
            this.Text = "AddSectionForm - College Console";
            ((System.ComponentModel.ISupportInitialize)(this.numMaxNoOfStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSectionId;
        private System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.NumericUpDown numMaxNoOfStudents;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddingCourse;
        private System.Windows.Forms.ComboBox cmbSemester;
    }
}