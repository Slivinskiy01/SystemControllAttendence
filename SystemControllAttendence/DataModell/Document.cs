using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemControllAttendence.DataModell
{
    public class Document
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public Personnel Personnel { get; set; }
    }
}
