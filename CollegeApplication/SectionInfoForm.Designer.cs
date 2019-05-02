namespace CollegeApplication
{
    partial class SectionInfoForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAssignedCourse = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblMaxNoOfStudents = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.lblSectionId = new System.Windows.Forms.Label();
            this.ttpTeacherInfo = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(224, 426);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Assigned course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Max No. of Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Section ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Faculty";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAssignedCourse);
            this.groupBox1.Controls.Add(this.lblFaculty);
            this.groupBox1.Controls.Add(this.lblMaxNoOfStudents);
            this.groupBox1.Controls.Add(this.lblSemester);
            this.groupBox1.Controls.Add(this.lblSectionName);
            this.groupBox1.Controls.Add(this.lblSectionId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(36, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 366);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section information";
            // 
            // lblAssignedCourse
            // 
            this.lblAssignedCourse.AutoSize = true;
            this.lblAssignedCourse.Location = new System.Drawing.Point(208, 286);
            this.lblAssignedCourse.Name = "lblAssignedCourse";
            this.lblAssignedCourse.Size = new System.Drawing.Size(52, 18);
            this.lblAssignedCourse.TabIndex = 31;
            this.lblAssignedCourse.Text = "label7";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(208, 232);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(52, 18);
            this.lblFaculty.TabIndex = 30;
            this.lblFaculty.Text = "label7";
            // 
            // lblMaxNoOfStudents
            // 
            this.lblMaxNoOfStudents.AutoSize = true;
            this.lblMaxNoOfStudents.Location = new System.Drawing.Point(208, 180);
            this.lblMaxNoOfStudents.Name = "lblMaxNoOfStudents";
            this.lblMaxNoOfStudents.Size = new System.Drawing.Size(52, 18);
            this.lblMaxNoOfStudents.TabIndex = 29;
            this.lblMaxNoOfStudents.Text = "label7";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(208, 130);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(52, 18);
            this.lblSemester.TabIndex = 28;
            this.lblSemester.Text = "label7";
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Location = new System.Drawing.Point(208, 83);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(52, 18);
            this.lblSectionName.TabIndex = 27;
            this.lblSectionName.Text = "label7";
            // 
            // lblSectionId
            // 
            this.lblSectionId.AutoSize = true;
            this.lblSectionId.Location = new System.Drawing.Point(208, 38);
            this.lblSectionId.Name = "lblSectionId";
            this.lblSectionId.Size = new System.Drawing.Size(52, 18);
            this.lblSectionId.TabIndex = 26;
            this.lblSectionId.Text = "label7";
            // 
            // SectionInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "SectionInfoForm";
            this.Text = "SectionInfoForm - College Console";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAssignedCourse;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblMaxNoOfStudents;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.Label lblSectionId;
        private System.Windows.Forms.ToolTip ttpTeacherInfo;
    }
}