using ADO.Net.Client.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModel
{
    public class Patients
    {
        [Key]
        public int PatientID { get; set; }
        public string PatientSurname { get; set; }
        public string PatientName { get; set; }
        public string PatientSecondName { get; set; }
        public int PatientMedicalHistoryID { get; set; }
        public int PatientAge { get; set; }
        public DateTime PatientDeliveri { get; set; }
        public int DepartmentID { get; set; }
        public DateTime PatientTransferTime { get; set; }
        public string PatientResult { get; set; }
        public int PatientTimeOfHospitalization { get; set; }
        public bool COVID19 { get; set; }


    }
}
