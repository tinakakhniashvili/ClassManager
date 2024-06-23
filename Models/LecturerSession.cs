using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManager.Models
{
    public class LecturerSesssion
    {
        public int Id { get; set; }
        public int? LecturerId { get; set; }
        public Lecturer? Lecturer { get; set; }
        public int? SessionId { get; set; }
        public Session? Session { get; set; }
         public ICollection<LecturerSesssion> LecturerSessions { get; set; }= new HashSet<LecturerSesssion>();
    }
}