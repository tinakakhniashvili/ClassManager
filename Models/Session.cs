using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManager.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Start { get; set; }
        public string End { get; set; }

        public ICollection<Enroll> Enrollment { get; set; } = new HashSet<Enroll>();
        public ICollection<LecturerSesssion> LecturerSessions { get; set; }= new HashSet<LecturerSesssion>();
    }
}