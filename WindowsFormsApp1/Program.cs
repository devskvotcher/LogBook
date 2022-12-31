using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataModel;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            using (LogBook context = new LogBook())
            {
                Patients patient = new Patients();
                
                patient.PatientID = 1;
                patient.PatientSurname = "Трофимов";
                patient.PatientName = "Сергей";
                patient.PatientSecondName = "Николаевич";
                patient.PatientMedicalHistoryID = 73207;
                patient.PatientAge = 54;
                patient.PatientDeliveri = new DateTime(2015, 7, 20, 18, 30, 25);
                patient.DepartmentID = 1;
                patient.PatientTransferTime = new DateTime(2020, 7, 20, 18, 30, 25);
                patient.PatientResult = "Перевод на отделение";
                patient.PatientTimeOfHospitalization = 25;
                patient.COVID19 = true;


                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }
    }
}
