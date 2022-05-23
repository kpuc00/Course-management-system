namespace Ezikovi_kursove
{
    partial class ManageCandidates
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
            this.lbxCandidates = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCandidates = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLanguageLevel = new System.Windows.Forms.ComboBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.tpCreateCourse = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxCriteria = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nbCandidates = new System.Windows.Forms.NumericUpDown();
            this.cbCourseType = new System.Windows.Forms.ComboBox();
            this.cbLanguageLevel2 = new System.Windows.Forms.ComboBox();
            this.cbLanguage2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpCourses = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbLanguageLevel = new System.Windows.Forms.Label();
            this.lbCourseType = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCoursePicker = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxEnrolled = new System.Windows.Forms.ListBox();
            this.lbxConfirmed = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpCandidates.SuspendLayout();
            this.tpCreateCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbCandidates)).BeginInit();
            this.tpCourses.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCandidates
            // 
            this.lbxCandidates.FormattingEnabled = true;
            this.lbxCandidates.ItemHeight = 20;
            this.lbxCandidates.Location = new System.Drawing.Point(6, 61);
            this.lbxCandidates.Name = "lbxCandidates";
            this.lbxCandidates.Size = new System.Drawing.Size(802, 564);
            this.lbxCandidates.TabIndex = 1;
            this.lbxCandidates.SelectedIndexChanged += new System.EventHandler(this.lbxCandidates_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCandidates);
            this.tabControl1.Controls.Add(this.tpCreateCourse);
            this.tabControl1.Controls.Add(this.tpCourses);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 665);
            this.tabControl1.TabIndex = 2;
            // 
            // tpCandidates
            // 
            this.tpCandidates.BackColor = System.Drawing.Color.Transparent;
            this.tpCandidates.Controls.Add(this.label17);
            this.tpCandidates.Controls.Add(this.btnDelete);
            this.tpCandidates.Controls.Add(this.label2);
            this.tpCandidates.Controls.Add(this.label1);
            this.tpCandidates.Controls.Add(this.cbLanguageLevel);
            this.tpCandidates.Controls.Add(this.cbLanguage);
            this.tpCandidates.Controls.Add(this.lbxCandidates);
            this.tpCandidates.Location = new System.Drawing.Point(4, 29);
            this.tpCandidates.Name = "tpCandidates";
            this.tpCandidates.Padding = new System.Windows.Forms.Padding(3);
            this.tpCandidates.Size = new System.Drawing.Size(814, 632);
            this.tpCandidates.TabIndex = 1;
            this.tpCandidates.Text = "Чакащи кандидати";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(369, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(295, 17);
            this.label17.TabIndex = 12;
            this.label17.Text = "Кликнете върху кандидат, за да го маркирате.";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(670, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Премахване";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Изберете ниво";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Изберете курс";
            // 
            // cbLanguageLevel
            // 
            this.cbLanguageLevel.FormattingEnabled = true;
            this.cbLanguageLevel.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbLanguageLevel.Location = new System.Drawing.Point(175, 26);
            this.cbLanguageLevel.Name = "cbLanguageLevel";
            this.cbLanguageLevel.Size = new System.Drawing.Size(151, 28);
            this.cbLanguageLevel.TabIndex = 3;
            this.cbLanguageLevel.SelectedIndexChanged += new System.EventHandler(this.cbLanguageLevel_SelectedIndexChanged);
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "Английски",
            "Немски",
            "Френски"});
            this.cbLanguage.Location = new System.Drawing.Point(6, 26);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(151, 28);
            this.cbLanguage.TabIndex = 2;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // tpCreateCourse
            // 
            this.tpCreateCourse.BackColor = System.Drawing.Color.Transparent;
            this.tpCreateCourse.Controls.Add(this.label16);
            this.tpCreateCourse.Controls.Add(this.dateTimePicker1);
            this.tpCreateCourse.Controls.Add(this.lbCount);
            this.tpCreateCourse.Controls.Add(this.label7);
            this.tpCreateCourse.Controls.Add(this.lbxCriteria);
            this.tpCreateCourse.Controls.Add(this.btnConfirm);
            this.tpCreateCourse.Controls.Add(this.label6);
            this.tpCreateCourse.Controls.Add(this.nbCandidates);
            this.tpCreateCourse.Controls.Add(this.cbCourseType);
            this.tpCreateCourse.Controls.Add(this.cbLanguageLevel2);
            this.tpCreateCourse.Controls.Add(this.cbLanguage2);
            this.tpCreateCourse.Controls.Add(this.label5);
            this.tpCreateCourse.Controls.Add(this.label4);
            this.tpCreateCourse.Controls.Add(this.label3);
            this.tpCreateCourse.Location = new System.Drawing.Point(4, 29);
            this.tpCreateCourse.Name = "tpCreateCourse";
            this.tpCreateCourse.Size = new System.Drawing.Size(814, 632);
            this.tpCreateCourse.TabIndex = 2;
            this.tpCreateCourse.Text = "Сформиране на курс";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(627, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Дата на начало";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(627, 26);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 5, 22, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 27);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 22, 23, 28, 24, 0);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCount.Location = new System.Drawing.Point(331, 84);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(18, 20);
            this.lbCount.TabIndex = 10;
            this.lbCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Брой кандидати, отговарящи на критериите:";
            // 
            // lbxCriteria
            // 
            this.lbxCriteria.FormattingEnabled = true;
            this.lbxCriteria.ItemHeight = 20;
            this.lbxCriteria.Location = new System.Drawing.Point(5, 107);
            this.lbxCriteria.Name = "lbxCriteria";
            this.lbxCriteria.Size = new System.Drawing.Size(806, 504);
            this.lbxCriteria.TabIndex = 8;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(665, 72);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 29);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Сформиране";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnCreateCourse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Брой кандидати";
            // 
            // nbCandidates
            // 
            this.nbCandidates.Location = new System.Drawing.Point(493, 26);
            this.nbCandidates.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbCandidates.Name = "nbCandidates";
            this.nbCandidates.Size = new System.Drawing.Size(121, 27);
            this.nbCandidates.TabIndex = 3;
            this.nbCandidates.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbCandidates.ValueChanged += new System.EventHandler(this.nbCandidates_ValueChanged);
            // 
            // cbCourseType
            // 
            this.cbCourseType.FormattingEnabled = true;
            this.cbCourseType.Items.AddRange(new object[] {
            "Веднъж седмично",
            "Два пъти седмично",
            "Всеки ден"});
            this.cbCourseType.Location = new System.Drawing.Point(310, 25);
            this.cbCourseType.Name = "cbCourseType";
            this.cbCourseType.Size = new System.Drawing.Size(166, 28);
            this.cbCourseType.TabIndex = 5;
            this.cbCourseType.SelectedIndexChanged += new System.EventHandler(this.cbCourseType_SelectedIndexChanged);
            // 
            // cbLanguageLevel2
            // 
            this.cbLanguageLevel2.FormattingEnabled = true;
            this.cbLanguageLevel2.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbLanguageLevel2.Location = new System.Drawing.Point(178, 25);
            this.cbLanguageLevel2.Name = "cbLanguageLevel2";
            this.cbLanguageLevel2.Size = new System.Drawing.Size(114, 28);
            this.cbLanguageLevel2.TabIndex = 4;
            this.cbLanguageLevel2.SelectedIndexChanged += new System.EventHandler(this.cbLanguageLevel2_SelectedIndexChanged);
            // 
            // cbLanguage2
            // 
            this.cbLanguage2.FormattingEnabled = true;
            this.cbLanguage2.Items.AddRange(new object[] {
            "Английски",
            "Немски",
            "Френски"});
            this.cbLanguage2.Location = new System.Drawing.Point(5, 25);
            this.cbLanguage2.Name = "cbLanguage2";
            this.cbLanguage2.Size = new System.Drawing.Size(151, 28);
            this.cbLanguage2.TabIndex = 3;
            this.cbLanguage2.SelectedIndexChanged += new System.EventHandler(this.cbLanguage2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Изберете тип на курса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Изберете ниво";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Изберете език";
            // 
            // tpCourses
            // 
            this.tpCourses.BackColor = System.Drawing.Color.Transparent;
            this.tpCourses.Controls.Add(this.label15);
            this.tpCourses.Controls.Add(this.btnPayment);
            this.tpCourses.Controls.Add(this.btnRemove);
            this.tpCourses.Controls.Add(this.groupBox1);
            this.tpCourses.Controls.Add(this.cbCoursePicker);
            this.tpCourses.Controls.Add(this.label10);
            this.tpCourses.Controls.Add(this.label9);
            this.tpCourses.Controls.Add(this.label8);
            this.tpCourses.Controls.Add(this.lbxEnrolled);
            this.tpCourses.Controls.Add(this.lbxConfirmed);
            this.tpCourses.Location = new System.Drawing.Point(4, 29);
            this.tpCourses.Name = "tpCourses";
            this.tpCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tpCourses.Size = new System.Drawing.Size(814, 632);
            this.tpCourses.TabIndex = 0;
            this.tpCourses.Text = "Курсове";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(7, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(394, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Кликнете върху кандидат, за да променяте неговите детайли.";
            // 
            // btnPayment
            // 
            this.btnPayment.Enabled = false;
            this.btnPayment.Location = new System.Drawing.Point(478, 263);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(151, 29);
            this.btnPayment.TabIndex = 10;
            this.btnPayment.Text = "Платена такса";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(657, 263);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(151, 29);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Премахване";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbLanguage);
            this.groupBox1.Controls.Add(this.lbLanguageLevel);
            this.groupBox1.Controls.Add(this.lbCourseType);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbStartDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(206, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детайли";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(55, 26);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(33, 20);
            this.lbLanguage.TabIndex = 14;
            this.lbLanguage.Text = "null";
            // 
            // lbLanguageLevel
            // 
            this.lbLanguageLevel.AutoSize = true;
            this.lbLanguageLevel.Location = new System.Drawing.Point(61, 50);
            this.lbLanguageLevel.Name = "lbLanguageLevel";
            this.lbLanguageLevel.Size = new System.Drawing.Size(33, 20);
            this.lbLanguageLevel.TabIndex = 13;
            this.lbLanguageLevel.Text = "null";
            // 
            // lbCourseType
            // 
            this.lbCourseType.AutoSize = true;
            this.lbCourseType.Location = new System.Drawing.Point(344, 26);
            this.lbCourseType.Name = "lbCourseType";
            this.lbCourseType.Size = new System.Drawing.Size(33, 20);
            this.lbCourseType.TabIndex = 12;
            this.lbCourseType.Text = "null";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Тип на курса:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Ниво:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Език:";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(412, 50);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(33, 20);
            this.lbStartDate.TabIndex = 8;
            this.lbStartDate.Text = "null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Начална дата на курса:";
            // 
            // cbCoursePicker
            // 
            this.cbCoursePicker.FormattingEnabled = true;
            this.cbCoursePicker.Location = new System.Drawing.Point(7, 26);
            this.cbCoursePicker.Name = "cbCoursePicker";
            this.cbCoursePicker.Size = new System.Drawing.Size(193, 28);
            this.cbCoursePicker.TabIndex = 5;
            this.cbCoursePicker.SelectedIndexChanged += new System.EventHandler(this.cbCoursePicker_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Изберете сформиран курс";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Записани кандидати";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Потвърдени кандидати";
            // 
            // lbxEnrolled
            // 
            this.lbxEnrolled.FormattingEnabled = true;
            this.lbxEnrolled.ItemHeight = 20;
            this.lbxEnrolled.Location = new System.Drawing.Point(6, 362);
            this.lbxEnrolled.Name = "lbxEnrolled";
            this.lbxEnrolled.Size = new System.Drawing.Size(802, 264);
            this.lbxEnrolled.TabIndex = 1;
            // 
            // lbxConfirmed
            // 
            this.lbxConfirmed.FormattingEnabled = true;
            this.lbxConfirmed.ItemHeight = 20;
            this.lbxConfirmed.Location = new System.Drawing.Point(6, 113);
            this.lbxConfirmed.Name = "lbxConfirmed";
            this.lbxConfirmed.Size = new System.Drawing.Size(802, 144);
            this.lbxConfirmed.TabIndex = 0;
            this.lbxConfirmed.SelectedIndexChanged += new System.EventHandler(this.lbxConfirmed_SelectedIndexChanged_1);
            // 
            // ManageCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 689);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ManageCandidates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление";
            this.tabControl1.ResumeLayout(false);
            this.tpCandidates.ResumeLayout(false);
            this.tpCandidates.PerformLayout();
            this.tpCreateCourse.ResumeLayout(false);
            this.tpCreateCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbCandidates)).EndInit();
            this.tpCourses.ResumeLayout(false);
            this.tpCourses.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox lbxCandidates;
        private TabControl tabControl1;
        private TabPage tpCandidates;
        private TabPage tpCourses;
        private Label label2;
        private Label label1;
        private ComboBox cbLanguageLevel;
        private ComboBox cbLanguage;
        private TabPage tpCreateCourse;
        private Label lbCount;
        private Label label7;
        private ListBox lbxCriteria;
        private Button btnConfirm;
        private Label label6;
        private NumericUpDown nbCandidates;
        private ComboBox cbCourseType;
        private ComboBox cbLanguageLevel2;
        private ComboBox cbLanguage2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private ListBox lbxEnrolled;
        private ListBox lbxConfirmed;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbCoursePicker;
        private Label label10;
        private GroupBox groupBox1;
        private Label lbStartDate;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label lbLanguage;
        private Label lbLanguageLevel;
        private Label lbCourseType;
        private Button btnPayment;
        private Button btnRemove;
        private Label label15;
        private Label label16;
        private Button btnDelete;
        private Label label17;
    }
}