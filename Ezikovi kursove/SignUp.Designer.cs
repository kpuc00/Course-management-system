namespace Ezikovi_kursove
{
    partial class SignUp
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbGerman = new System.Windows.Forms.RadioButton();
            this.rbFrench = new System.Windows.Forms.RadioButton();
            this.rbLevelA = new System.Windows.Forms.RadioButton();
            this.rbLevelB = new System.Windows.Forms.RadioButton();
            this.rbLevelC = new System.Windows.Forms.RadioButton();
            this.rbOnce = new System.Windows.Forms.RadioButton();
            this.rbTwice = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.gbLanguageLevel = new System.Windows.Forms.GroupBox();
            this.gpCourseType = new System.Windows.Forms.GroupBox();
            this.gbLanguage.SuspendLayout();
            this.gbLanguageLevel.SuspendLayout();
            this.gpCourseType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(70, 168);
            this.tbName.MaxLength = 60;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(345, 27);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вашите три имена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Данни на кандидата";
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(6, 31);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(104, 24);
            this.rbEnglish.TabIndex = 4;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "Английски";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbGerman
            // 
            this.rbGerman.AutoSize = true;
            this.rbGerman.Location = new System.Drawing.Point(6, 61);
            this.rbGerman.Name = "rbGerman";
            this.rbGerman.Size = new System.Drawing.Size(83, 24);
            this.rbGerman.TabIndex = 4;
            this.rbGerman.TabStop = true;
            this.rbGerman.Text = "Немски";
            this.rbGerman.UseVisualStyleBackColor = true;
            // 
            // rbFrench
            // 
            this.rbFrench.AutoSize = true;
            this.rbFrench.Location = new System.Drawing.Point(6, 91);
            this.rbFrench.Name = "rbFrench";
            this.rbFrench.Size = new System.Drawing.Size(90, 24);
            this.rbFrench.TabIndex = 4;
            this.rbFrench.TabStop = true;
            this.rbFrench.Text = "Френски";
            this.rbFrench.UseVisualStyleBackColor = true;
            // 
            // rbLevelA
            // 
            this.rbLevelA.AutoSize = true;
            this.rbLevelA.Location = new System.Drawing.Point(6, 26);
            this.rbLevelA.Name = "rbLevelA";
            this.rbLevelA.Size = new System.Drawing.Size(40, 24);
            this.rbLevelA.TabIndex = 4;
            this.rbLevelA.TabStop = true;
            this.rbLevelA.Text = "A";
            this.rbLevelA.UseVisualStyleBackColor = true;
            // 
            // rbLevelB
            // 
            this.rbLevelB.AutoSize = true;
            this.rbLevelB.Location = new System.Drawing.Point(6, 56);
            this.rbLevelB.Name = "rbLevelB";
            this.rbLevelB.Size = new System.Drawing.Size(39, 24);
            this.rbLevelB.TabIndex = 4;
            this.rbLevelB.TabStop = true;
            this.rbLevelB.Text = "B";
            this.rbLevelB.UseVisualStyleBackColor = true;
            // 
            // rbLevelC
            // 
            this.rbLevelC.AutoSize = true;
            this.rbLevelC.Location = new System.Drawing.Point(6, 86);
            this.rbLevelC.Name = "rbLevelC";
            this.rbLevelC.Size = new System.Drawing.Size(39, 24);
            this.rbLevelC.TabIndex = 4;
            this.rbLevelC.TabStop = true;
            this.rbLevelC.Text = "C";
            this.rbLevelC.UseVisualStyleBackColor = true;
            // 
            // rbOnce
            // 
            this.rbOnce.AutoSize = true;
            this.rbOnce.Location = new System.Drawing.Point(6, 26);
            this.rbOnce.Name = "rbOnce";
            this.rbOnce.Size = new System.Drawing.Size(169, 24);
            this.rbOnce.TabIndex = 4;
            this.rbOnce.TabStop = true;
            this.rbOnce.Text = "Веднъж на седмица";
            this.rbOnce.UseVisualStyleBackColor = true;
            // 
            // rbTwice
            // 
            this.rbTwice.AutoSize = true;
            this.rbTwice.Location = new System.Drawing.Point(6, 56);
            this.rbTwice.Name = "rbTwice";
            this.rbTwice.Size = new System.Drawing.Size(178, 24);
            this.rbTwice.TabIndex = 4;
            this.rbTwice.TabStop = true;
            this.rbTwice.Text = "Два пъти на седмица";
            this.rbTwice.UseVisualStyleBackColor = true;
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Location = new System.Drawing.Point(6, 86);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(99, 24);
            this.rbDaily.TabIndex = 4;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Всеки ден";
            this.rbDaily.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(313, 515);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(102, 37);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Записване";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.rbEnglish);
            this.gbLanguage.Controls.Add(this.rbGerman);
            this.gbLanguage.Controls.Add(this.rbFrench);
            this.gbLanguage.Location = new System.Drawing.Point(70, 230);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(186, 125);
            this.gbLanguage.TabIndex = 6;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Изберете курс по език";
            // 
            // gbLanguageLevel
            // 
            this.gbLanguageLevel.Controls.Add(this.rbLevelA);
            this.gbLanguageLevel.Controls.Add(this.rbLevelB);
            this.gbLanguageLevel.Controls.Add(this.rbLevelC);
            this.gbLanguageLevel.Location = new System.Drawing.Point(259, 230);
            this.gbLanguageLevel.Name = "gbLanguageLevel";
            this.gbLanguageLevel.Size = new System.Drawing.Size(156, 125);
            this.gbLanguageLevel.TabIndex = 7;
            this.gbLanguageLevel.TabStop = false;
            this.gbLanguageLevel.Text = "Посочете ниво";
            // 
            // gpCourseType
            // 
            this.gpCourseType.Controls.Add(this.rbOnce);
            this.gpCourseType.Controls.Add(this.rbTwice);
            this.gpCourseType.Controls.Add(this.rbDaily);
            this.gpCourseType.Location = new System.Drawing.Point(70, 361);
            this.gpCourseType.Name = "gpCourseType";
            this.gpCourseType.Size = new System.Drawing.Size(345, 125);
            this.gpCourseType.TabIndex = 8;
            this.gpCourseType.TabStop = false;
            this.gpCourseType.Text = "Изберете тип на курса";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 587);
            this.Controls.Add(this.gpCourseType);
            this.Controls.Add(this.gbLanguageLevel);
            this.Controls.Add(this.gbLanguage);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записване на кандидат";
            this.gbLanguage.ResumeLayout(false);
            this.gbLanguage.PerformLayout();
            this.gbLanguageLevel.ResumeLayout(false);
            this.gbLanguageLevel.PerformLayout();
            this.gpCourseType.ResumeLayout(false);
            this.gpCourseType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbName;
        private Label label1;
        private Label label2;
        private RadioButton rbEnglish;
        private RadioButton rbGerman;
        private RadioButton rbFrench;
        private RadioButton rbLevelA;
        private RadioButton rbLevelB;
        private RadioButton rbLevelC;
        private RadioButton rbOnce;
        private RadioButton rbTwice;
        private RadioButton rbDaily;
        private Button btnSignUp;
        private GroupBox gbLanguage;
        private GroupBox gbLanguageLevel;
        private GroupBox gpCourseType;
    }
}