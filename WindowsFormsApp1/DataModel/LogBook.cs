using ADO.Net.Client.Core;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.DataModel
{
    public class LogBook : DbContext
    {
       
        // Контекст настроен для использования строки подключения "LogBook" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WindowsFormsApp1.DataModel.LogBook" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "LogBook" 
        // в файле конфигурации приложения.
        public LogBook()
            : base("name=LogBook")
        {            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //   modelBuilder.Entity <Patients> (b =>
            //   {
            //       b.HasKey(d => d.DepartmentID);                
            //       b
            //       .HasMany(d => d.Departments)
            //       .WithOne(c => c.Patients);
            //   });

            modelBuilder.Entity<Patients>()
                .HasKey(p => p.PatientID);

            modelBuilder.Entity<Department>()
                .HasMany(p => p.Patients)
                .WithRequired(p => p.Department);

            modelBuilder.Entity<PatientResult>()
                .HasMany(p => p.Patients)
                .WithRequired(p => p.PatientResult);

        }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PatientResult> PatientResults { get; set; }

       

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}