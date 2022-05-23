using System.Text.Json; 

namespace Ezikovi_kursove
{
    public partial class CourseSystem : Form
    {
        private static List<Candidate> candidates = new List<Candidate>();
        private static List<Course> courses = new List<Course>();

        public CourseSystem()
        {
            InitializeComponent();
        }

        public List<Candidate> GetCandidates()
        {
            return candidates;  
        }
        public void AddCandidate(Candidate candidate)
        {
            candidates.Add(candidate);
        }

        public List<Course> GetCourses()
        {
            return courses;
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageCandidates manageCandidates = new ManageCandidates();
            manageCandidates.Show();
        }

        private void CourseSystem_Load(object sender, EventArgs e)
        {
            if (File.Exists("candidates.json"))
            {
                string json = File.ReadAllText("candidates.json");
                var deserialized = JsonSerializer.Deserialize<List<Candidate>>(json);
                if (deserialized != null)
                {
                    candidates = deserialized;

                    foreach (Candidate candidate in candidates)
                    {
                        if (candidate.StartDate != null)
                            if (courses.FirstOrDefault(x => x.StartDate == candidate.StartDate) == null) courses.Add(new Course((DateTime)candidate.StartDate, candidate.Language, candidate.LanguageLevel, candidate.CourseType));
                    }
                }
            }
        }

        private void CourseSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonSerializer.Serialize(candidates);
            File.WriteAllText("candidates.json", json);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Това действие ще възстанови всички промени от момента на стартиране на програмата. Желаете ли да продължите?", "Необратимо действие", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                CourseSystem_Load(sender, e);
                Application.Restart();
                Environment.Exit(0);
            }
            
        }
    }
}