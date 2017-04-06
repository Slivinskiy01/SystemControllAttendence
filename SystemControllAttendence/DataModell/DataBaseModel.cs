namespace SystemControllAttendence.DataModell
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataBaseModel : DbContext
    {
        // Контекст настроен для использования строки подключения "DataBaseModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "SystemControllAttendence.DataModell.DataBaseModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DataBaseModel" 
        // в файле конфигурации приложения.
        public DataBaseModel(): base("name=DataBaseModel")
        {


        }




        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Departament> Departaments { get; set; }

        public DbSet<User> Users { get; set; }

        ///
    }
}