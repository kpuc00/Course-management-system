using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezikovi_kursove
{
    public class Course
    {
        private static int idSeeder = 1;
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public Language Language { get; set; }
        public LanguageLevel Level { get; set; }
        public CourseType Type { get; set; }
        public Course(DateTime date, Language language, LanguageLevel level, CourseType type)
        {
            Name = $"Курс {idSeeder}";
            idSeeder++;
            StartDate = date;
            Language = language;
            Level = level;
            Type = type;
        }
        public override string ToString()
        {
            return $"{Name} - {Language} {Level}";
        }
    }
}
