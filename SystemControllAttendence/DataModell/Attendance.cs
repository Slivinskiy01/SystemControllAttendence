using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemControllAttendence.DataModell
{
    public class Attendance
    {
        public int Id { get; set; }
        public string DayWeek { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? OutTime { get; set; }
        public Personnel Personnel { get; set; }
    }
}
