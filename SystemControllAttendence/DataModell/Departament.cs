using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemControllAttendence.DataModell
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Personnel Person { get; set; }
        public Departament ParentDepartament { get; set; }
    }
}
