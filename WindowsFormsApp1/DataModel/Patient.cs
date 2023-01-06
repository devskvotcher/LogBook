using ADO.Net.Client.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModel
{
    public class Patients
    {
    //    [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientID { get; set; }
  //      [Required]
        [MaxLength(50)]
        public string PatientSurname { get; set; }
   //     [Required]
        [MaxLength(50)]
        public string PatientName { get; set; }
        [MaxLength(50)]
        public string PatientSecondName { get; set; }
        [Required]
        public int PatientMedicalHistoryID { get; set; }
        [Required]
        public int PatientAge { get; set; }
        [Required]
        public DateTime PatientDeliveri { get; set; }
        [Required]
        public int DepartmentID { get; set; }
        public DateTime PatientTransferTime { get; set; }
        public int PatientResultID { get; set; }
        public int PatientTimeOfHospitalization { get; set; }
        public bool COVID19 { get; set; }

        public virtual Department Department { get; set; }
        public virtual PatientResult PatientResult { get; set; }

    }
}
