using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ClassManager.Models
{
    public class Lecturer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; } //Date of born
        public DateTime DateOfJoin { get; set; }
        public bool Selected { get; set; }
        [Unique]
        public string KeyId { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public ICollection<LecturerSesssion> LecturerSessions { get; set; }= new HashSet<LecturerSesssion>();
        public ICollection<AssignGrade> AssignGrade { get; set; }=new HashSet<AssignGrade>();
    }
}