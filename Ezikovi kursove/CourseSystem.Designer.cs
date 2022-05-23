namespace Ezikovi_kursove
{
    partial class CourseSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(143, 50);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(159, 29);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Записване";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(143, 101);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(159, 29);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "Управление";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(143, 227);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(159, 29);
            this.btnUndo.TabIndex = 2;
            this.btnUndo.Text = "Отмени промените";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // CourseSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 303);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CourseSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система за езикови курсове";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CourseSystem_FormClosing);
            this.Load += new System.EventHandler(this.CourseSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSignUp;
        private Button btnManage;
        private Button btnUndo;
    }
}