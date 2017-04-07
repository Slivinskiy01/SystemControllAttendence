using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemControllAttendence.DataModell;
namespace SystemControllAttendence
{
    public class EmployeeManipulation
    {
        /// <summary>
        /// Статический экземпляр класса. 
        /// </summary>
        public static EmployeeManipulation Instance = new EmployeeManipulation(); 
        /// <summary>
        /// Метод добавления нового сотрудника
        /// </summary>
        /// <param name="Person">Модель Сотрудник</param>
        /// <param name="Docum">Модель документ</param>
        public void AddEmployee(Personnel Person, Document Docum)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите добавить сотрудника?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var Db = new DataBaseModel())
                {
                    var Doc = Db.Documents.ToList();
                    foreach (var a in Doc)
                    {
                        if (Docum.Number == a.Number)
                        {
                            MessageBox.Show("Такой номер документа уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    Db.Personnels.Add(Person);
                    Db.Documents.Add(Docum);
                    try
                    {
                        Db.SaveChanges();
                        MessageBox.Show("Сотрудник добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при добавлении записи в БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Изменения не сохранены", "Информация");
            }
        }
        /// <summary>
        /// Метод удаления сотрудника и его документов по Id сотрудника
        /// </summary>
        /// <param name="id">Id Сотрудника</param>
        public void DelletPersonnelById(int id)
        {
            using (var db = new DataBaseModel())
            {
                var Per = db.Personnels.FirstOrDefault(x => x.Id == id);
                while (true)
                {
                    var Doc = db.Documents.FirstOrDefault(x => x.Personnel.Id == Per.Id);
                    if (Doc != null)
                    {
                        db.Documents.Remove(Doc);
                        db.SaveChanges();
                    }
                    else break;
                }
                db.Personnels.Remove(Per);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Метод пойска Сотрудника по номеру документа
        /// </summary>
        /// <param name="id">Номер документа</param>
        /// <returns></returns>
        public static Document GetPersonnelByDocNumber(int id)
        {
            using (var Db = new DataBaseModel())
            {

                var Doc = Db.Documents.FirstOrDefault(x => x.Number == id);
                if (null != Doc)
                {
                    var Per = Db.Personnels.ToList();
                    return Doc;
                }
                else
                {
                    MessageBox.Show("Сотрудник не найден");
                    return null;
                }
            }
        }

    }
}
