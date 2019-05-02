namespace CollegeApplication
{
    partial class CourseManagerForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.lvwCourses = new System.Windows.Forms.ListView();
            this.colCourseCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCourseDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoadCourses = new System.Windows.Forms.Button();
            this.btnSaveCourses = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCourseDescription = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.lbxSections = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNoOfEvaluations = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(547, 54);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(166, 51);
            this.btnAddCourse.TabIndex = 0;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnAddSection
            // 
            this.btnAddSection.Enabled = false;
            this.btnAddSection.Location = new System.Drawing.Point(547, 161);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(166, 51);
            this.btnAddSection.TabIndex = 1;
            this.btnAddSection.Text = "Add Section";
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Enabled = false;
            this.btnAddTeacher.Location = new System.Drawing.Point(547, 269);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(166, 51);
            this.btnAddTeacher.TabIndex = 2;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // lvwCourses
            // 
            this.lvwCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCourseCode,
            this.colCourseName,
            this.colCourseDescription});
            this.lvwCourses.FullRowSelect = true;
            this.lvwCourses.HideSelection = false;
            this.lvwCourses.Location = new System.Drawing.Point(34, 421);
            this.lvwCourses.MultiSelect = false;
            this.lvwCourses.Name = "lvwCourses";
            this.lvwCourses.Size = new System.Drawing.Size(679, 207);
            this.lvwCourses.TabIndex = 4;
            this.lvwCourses.UseCompatibleStateImageBehavior = false;
            this.lvwCourses.View = System.Windows.Forms.View.Details;
            this.lvwCourses.SelectedIndexChanged += new System.EventHandler(this.lvwCourses_SelectedIndexChanged);
            // 
            // colCourseCode
            // 
            this.colCourseCode.Text = "Course Code";
            this.colCourseCode.Width = 120;
            // 
            // colCourseName
            // 
            this.colCourseName.Text = "Name";
            this.colCourseName.Width = 120;
            // 
            // colCourseDescription
            // 
            this.colCourseDescription.Text = "Description";
            this.colCourseDescription.Width = 240;
            // 
            // btnLoadCourses
            // 
            this.btnLoadCourses.Location = new System.Drawing.Point(34, 650);
            this.btnLoadCourses.Name = "btnLoadCourses";
            this.btnLoadCourses.Size = new System.Drawing.Size(166, 51);
            this.btnLoadCourses.TabIndex = 5;
            this.btnLoadCourses.Text = "Load";
            this.btnLoadCourses.UseVisualStyleBackColor = true;
            this.btnLoadCourses.Click += new System.EventHandler(this.btnLoadCourses_Click);
            // 
            // btnSaveCourses
            // 
            this.btnSaveCourses.Location = new System.Drawing.Point(282, 650);
            this.btnSaveCourses.Name = "btnSaveCourses";
            this.btnSaveCourses.Size = new System.Drawing.Size(166, 51);
            this.btnSaveCourses.TabIndex = 6;
            this.btnSaveCourses.Text = "Save";
            this.btnSaveCourses.UseVisualStyleBackColor = true;
            this.btnSaveCourses.Click += new System.EventHandler(this.btnSaveCourses_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 650);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 51);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNoOfEvaluations);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCourseDescription);
            this.groupBox1.Controls.Add(this.lblCourseName);
            this.groupBox1.Controls.Add(this.lblCourseCode);
            this.groupBox1.Controls.Add(this.lbxSections);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 368);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sections";
            // 
            // lblCourseDescription
            // 
            this.lblCourseDescription.Location = new System.Drawing.Point(168, 149);
            this.lblCourseDescription.Name = "lblCourseDescription";
            this.lblCourseDescription.Size = new System.Drawing.Size(281, 51);
            this.lblCourseDescription.TabIndex = 6;
            this.lblCourseDescription.Text = "label4";
            this.lblCourseDescription.Visible = false;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(168, 107);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(52, 18);
            this.lblCourseName.TabIndex = 5;
            this.lblCourseName.Text = "label4";
            this.lblCourseName.Visible = false;
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(168, 58);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(52, 18);
            this.lblCourseCode.TabIndex = 4;
            this.lblCourseCode.Text = "label4";
            this.lblCourseCode.Visible = false;
            // 
            // lbxSections
            // 
            this.lbxSections.FormattingEnabled = true;
            this.lbxSections.ItemHeight = 18;
            this.lbxSections.Location = new System.Drawing.Point(171, 266);
            this.lbxSections.Name = "lbxSections";
            this.lbxSections.Size = new System.Drawing.Size(285, 76);
            this.lbxSections.TabIndex = 3;
            this.lbxSections.SelectedIndexChanged += new System.EventHandler(this.lbxSections_SelectedIndexChanged);
            this.lbxSections.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbxSections_Format);
            this.lbxSections.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxSections_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desciption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "No of Evaluations";
            // 
            // lblNoOfEvaluations
            // 
            this.lblNoOfEvaluations.AutoSize = true;
            this.lblNoOfEvaluations.Location = new System.Drawing.Point(168, 203);
            this.lblNoOfEvaluations.Name = "lblNoOfEvaluations";
            this.lblNoOfEvaluations.Size = new System.Drawing.Size(52, 18);
            this.lblNoOfEvaluations.TabIndex = 9;
            this.lblNoOfEvaluations.Text = "label4";
            this.lblNoOfEvaluations.Visible = false;
            // 
            // CourseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 738);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveCourses);
            this.Controls.Add(this.btnLoadCourses);
            this.Controls.Add(this.lvwCourses);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.btnAddCourse);
            this.Name = "CourseManagerForm";
            this.Text = "CollegeCourseManager - College Console";
            this.Load += new System.EventHandler(this.CourseManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.ListView lvwCourses;
        private System.Windows.Forms.Button btnLoadCourses;
        private System.Windows.Forms.Button btnSaveCourses;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxSections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colCourseCode;
        private System.Windows.Forms.ColumnHeader colCourseName;
        private System.Windows.Forms.ColumnHeader colCourseDescription;
        private System.Windows.Forms.Label lblCourseDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Label lblNoOfEvaluations;
        private System.Windows.Forms.Label label5;
    }
}

