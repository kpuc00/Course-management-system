using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezikovi_kursove
{
    public partial class SignUp : Form
    {
        private CourseSystem courseSystem = new CourseSystem();

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            bool isLanguageSelected = false;
            foreach (RadioButton rb in gbLanguage.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    isLanguageSelected = true;
                    break;
                }
            }
            bool isLanguageLevelSelected = false;
            foreach (RadioButton rb in gbLanguage.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    isLanguageLevelSelected = true;
                    break;
                }
            }
            bool isCourseTypeSelected = false;
            foreach (RadioButton rb in gbLanguage.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    isCourseTypeSelected = true;
                    break;
                }
            }

            if(!String.IsNullOrEmpty(name) && isLanguageSelected && isLanguageLevelSelected && isCourseTypeSelected)
            {
                Status status = Status.CANDIDATE;
                Language language;

                if (rbEnglish.Checked) language = Language.ENGLISH;
                else if (rbGerman.Checked) language = Language.GERMAN;
                else language = Language.FRENCH;

                LanguageLevel languageLevel;
                if (rbLevelA.Checked) languageLevel = LanguageLevel.A;
                else if (rbLevelB.Checked) languageLevel = LanguageLevel.B;
                else languageLevel = LanguageLevel.C;

                CourseType courseType;
                if (rbOnce.Checked) courseType = CourseType.ONCE;
                else if (rbTwice.Checked) courseType = CourseType.TWICE;
                else courseType = CourseType.DAILY;

                Candidate candidate = new Candidate(name, status, language, languageLevel, courseType);
                courseSystem.AddCandidate(candidate);
                MessageBox.Show("Успешна регистрация!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show( "Не сте попълнили всички полета!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
