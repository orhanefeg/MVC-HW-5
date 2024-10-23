#nullable enable 
using BLL.DAL;

namespace BLL.Models
{
    public class StudentModel
    {
        public Student Record { get; set; }

        public string Name => Record.Name;

        public string Surname => Record.Surname;

        public DateTime? BirthDate => Record.BirthDate;

        public decimal? Gpa => Record.Gpa;
    }
}
