using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemControllAttendence.DataModell
{
    public class Personnel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Column(TypeName = "Image")]
        public byte[] Photo { get; set; }

        public ICollection<Document> Documents { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<Departament> Departaments { get; set; }
        
        public Personnel()
        {
            Documents = new List<Document>();
            Attendances = new List<Attendance>();
            Departaments = new List<Departament>();
        }
    }
}
