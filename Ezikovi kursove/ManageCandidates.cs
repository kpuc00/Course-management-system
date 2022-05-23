using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezikovi_kursove
{
    public partial class ManageCandidates : Form
    {
        CourseSystem courseSystem = new CourseSystem();

        public ManageCandidates()
        {
            InitializeComponent();
            
            cbLanguage.SelectedIndex = 0;
            cbLanguageLevel.SelectedIndex = 0;
            cbLanguage2.SelectedIndex = 0;
            cbLanguageLevel2.SelectedIndex = 0;
            cbCourseType.SelectedIndex = 0;
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(365);

            RefreshLbxCandidates();
            RefreshLbxCriteria();
            RefreshCourses();
            RefreshCoursesData();
        }

        private void RefreshLbxCandidates()
        {
            lbxCandidates.DataSource = FilterCandidates((Language)cbLanguage.SelectedIndex, (LanguageLevel)cbLanguageLevel.SelectedIndex);
        }

        private void RefreshLbxCriteria()
        {
            var data = FilterCandidates((Language)cbLanguage2.SelectedIndex, (LanguageLevel)cbLanguageLevel2.SelectedIndex, (CourseType)cbCourseType.SelectedIndex, Status.CANDIDATE);
            lbxCriteria.DataSource = data;
            lbCount.Text = data.Count.ToString();
            if (data.Count > 0) btnConfirm.Enabled = true; 
            else btnConfirm.Enabled = false;
        }

        private void RefreshCourses()
        {
            if (courseSystem.GetCourses().Count > 0) cbCoursePicker.DataSource = courseSystem.GetCourses();
        }

        private void RefreshCoursesData()
        {
            if (cbCoursePicker.SelectedIndex != -1)
            {
                Course course = courseSystem.GetCourses().ElementAt(cbCoursePicker.SelectedIndex);
                lbLanguage.Text = course.Language.ToString();
                lbLanguageLevel.Text = course.Level.ToString();
                lbCourseType.Text = course.Type.ToString();
                lbStartDate.Text = course.StartDate.Date.ToString();
                var confirmed = FilterCandidates(course.StartDate, Status.CONFIRMED);
                lbxConfirmed.DataSource = confirmed;
                var enrolled = FilterCandidates(course.StartDate, Status.ENROLLED);
                lbxEnrolled.DataSource = enrolled;
            }
        }

        private List<Candidate> FilterCandidates(Language language, LanguageLevel level)
        {
            List<Candidate> allCandidates = courseSystem.GetCandidates();
            List<Candidate> filtered = new List<Candidate>();
            foreach (Candidate candidate in allCandidates)
            {
                if (candidate.Status == Status.CANDIDATE && candidate.Language == language && candidate.LanguageLevel == level)
                {
                        filtered.Add(candidate);
                }
            }
            return filtered;
        }

        private List<Candidate> FilterCandidates(Language language, LanguageLevel level, CourseType courseType, Status status)
        {
            List<Candidate> allCandidates = courseSystem.GetCandidates();
            List<Candidate> filtered = new List<Candidate>();
            foreach (Candidate candidate in allCandidates)
            {
                if (candidate.Status == status && candidate.Language == language && candidate.LanguageLevel == level && candidate.CourseType == courseType)
                {
                    filtered.Add(candidate);
                }
            }
            return filtered;
        }

        private List<Candidate> FilterCandidates(DateTime startDate, Status status)
        {
            List<Candidate> allCandidates = courseSystem.GetCandidates();
            List<Candidate> filtered = new List<Candidate>();
            foreach (Candidate candidate in allCandidates)
            {
                if (candidate.StartDate == startDate && candidate.Status == status)
                {
                    filtered.Add(candidate);
                }
            }
            return filtered;
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLbxCandidates();
        }

        private void cbLanguageLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLbxCandidates();
        }

        private void cbLanguage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLbxCriteria();
        }

        private void cbLanguageLevel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLbxCriteria();
        }

        private void cbCourseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLbxCriteria();
        }

        private void nbCandidates_ValueChanged(object sender, EventArgs e)
        {
            RefreshLbxCriteria();
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            int numCandidates = (int)nbCandidates.Value;
            if(cbLanguage2.SelectedIndex != -1 && cbLanguageLevel2.SelectedIndex != -1 && cbCourseType.SelectedIndex != -1 && numCandidates > 0)
            {
                var candidates = FilterCandidates((Language)cbLanguage2.SelectedIndex, (LanguageLevel)cbLanguageLevel2.SelectedIndex, (CourseType)cbCourseType.SelectedIndex, Status.CANDIDATE).Take((int)nbCandidates.Value);
                if (numCandidates > candidates.Count()) numCandidates = candidates.Count();
                foreach (Candidate candidate in candidates)
                {
                    var updatedCandidate = courseSystem.GetCandidates().FirstOrDefault(x => x.Id == candidate.Id);
                    if (updatedCandidate != null)
                    {
                        updatedCandidate.Status = Status.CONFIRMED;
                        updatedCandidate.StartDate = dateTimePicker1.Value.Date;
                        if (courseSystem.GetCourses().FirstOrDefault(x => x.StartDate == candidate.StartDate) == null) 
                            courseSystem.AddCourse(new Course(dateTimePicker1.Value.Date, candidate.Language, candidate.LanguageLevel, candidate.CourseType));
                    }
                }
                
                MessageBox.Show($"Успешно сформиране на курс от {numCandidates} кандидат(и).", "Сформиране на курс", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshLbxCriteria();
                RefreshLbxCandidates();
                RefreshCourses();
                RefreshCoursesData();
            }
            else MessageBox.Show("Не сте задали стойност във всички полета!", "Сформиране на курс", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void cbCoursePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCoursesData();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Candidate selected = (Candidate)lbxConfirmed.SelectedItem;
            DialogResult result = MessageBox.Show("Желаете ли да внесете пари?", $"Плащане - {selected.Name}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var updatedCandidate = courseSystem.GetCandidates().FirstOrDefault(x => x.Id == selected.Id);
                if (updatedCandidate != null)
                {
                    updatedCandidate.Status = Status.ENROLLED;
                }
                MessageBox.Show("Кандидатът е записан успешно!", $"Плащане - {selected.Name}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshLbxCriteria();
                RefreshLbxCandidates();
                RefreshCourses();
                RefreshCoursesData();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Candidate selected = (Candidate)lbxConfirmed.SelectedItem;
            DialogResult result = MessageBox.Show("Това действие ще постави лицето в списъка с чакащи кандидати. Желаете ли да продължите?", $"Отписване - {selected.Name}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var updatedCandidate = courseSystem.GetCandidates().FirstOrDefault(x => x.Id == selected.Id);
                if (updatedCandidate != null)
                {
                    updatedCandidate.Status = Status.CANDIDATE;
                    updatedCandidate.StartDate = null;
                }
                MessageBox.Show("Кандидатът беше премахнат от този курс успешно!", $"Отписване - {selected.Name}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshLbxCriteria();
                RefreshLbxCandidates();
                RefreshCourses();
                RefreshCoursesData();
            }
        }

        private void lbxConfirmed_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbxConfirmed.SelectedIndex != -1)
            {
                btnPayment.Enabled = true;
                btnRemove.Enabled = true;
            }
            else
            {
                btnPayment.Enabled = false;
                btnRemove.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Candidate selected = (Candidate)lbxCandidates.SelectedItem;
            DialogResult result = MessageBox.Show("Това действие ще изтрие лицето от системата. Желаете ли да продължите?", $"Изтриване - {selected.Name}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var candidate = courseSystem.GetCandidates().FirstOrDefault(x => x.Id == selected.Id);
                if (candidate != null)
                {
                    courseSystem.GetCandidates().Remove(candidate);
                }
                RefreshLbxCriteria();
                RefreshLbxCandidates();
                RefreshCourses();
                RefreshCoursesData();
            }
        }

        private void lbxCandidates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCandidates.SelectedIndex != -1)
            {
                btnDelete.Enabled = true; 
            }
            else
            {
                btnDelete.Enabled = false; 
            }
        }
    }
}
