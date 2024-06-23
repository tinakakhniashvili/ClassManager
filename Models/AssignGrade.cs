using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManager.Models
{
    public class AssignGrade
    {
        public int Id { get; set; }
        public int? GradeId { get; set; }
        public Grade? Grade { get; set; }
        public int? LecturerId { get; set; }
        public Lecturer? Lecturer { get; set; }
        
    }
}