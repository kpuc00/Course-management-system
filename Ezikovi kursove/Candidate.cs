using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezikovi_kursove
{
    public class Candidate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public Language Language { get; set; }
        public LanguageLevel LanguageLevel { get; set; }
        public CourseType CourseType { get; set; }
        public DateTime? StartDate { get; set; }
        public Candidate(string name, Status status, Language language, LanguageLevel languageLevel, CourseType courseType)
        {
            Id = Guid.NewGuid().ToString("N");
            Name = name;
            Status = status;
            Language = language;
            LanguageLevel = languageLevel;
            CourseType = courseType;
            StartDate = null;
        }
        public override string ToString()
        {
            //return $"Име: {Name} - Статус: {Status} - Курс: {Language} - Ниво: {LanguageLevel} - Тип на курс: {CourseType}";
            return Name;
        }
    }
}
