using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SystemControllAttendence.DataModell;

namespace SystemControllAttendence
{
    class AttentenceControl
    {

        private void RegEnterOut(int DocNumbers)
        {
            var Doc = EmployeeManipulation.Instance.GetPersonnelByDocNumber(DocNumbers);
            using (var db = new DataBaseModel())
            {
                var Per = db.Personnels.Find(Doc.Personnel.Id);
                var At = db.Attendances.ToList();
                Attendance LastAten = Per.Attendances.ToList().LastOrDefault();
                if (LastAten != null)
                {
                    if (LastAten.LoginTime != null && LastAten.OutTime != null)
                        CreateNewEnter(Per);
                }
                else if (LastAten.LoginTime != null && LastAten.OutTime == null)
                {
                    if (DateTime.Now.Date == LastAten.LoginTime.Value.Date)
                    {
                        var AtendEdit = db.Attendances.Single(x => x.Id == LastAten.Id);
                        AtendEdit.OutTime = DateTime.Now;
                        db.SaveChanges();
                    }
                    else CreateNewEnter(Per);
                }
                else CreateNewEnter(Per);
            }
        }

        private void CreateNewEnter(Personnel Per)
        {
            using (var db = new DataBaseModel())
            {
                var Atend = new Attendance()
                {
                    DayWeek = DateTime.Now.DayOfWeek.ToString(),
                    LoginTime = DateTime.Now,
                    OutTime = null,
                    Personnel = Per
                };
                db.Attendances.Add(Atend);
                db.SaveChanges();
            }
        }
    }
}