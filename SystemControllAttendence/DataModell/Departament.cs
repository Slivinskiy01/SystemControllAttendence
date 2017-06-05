using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemControllAttendence.DataModell
{
    public class Departament
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Departament ParentDep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Departament> ChildDep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Personnel> Personel { get; set; }
    }
}
