using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModel
{
    public class PatientResult
    {
    //    [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientResultID { get; set; }
        [Required]
        public string PatientResultName { get; set; }
        public ICollection<Patients> Patients { get; set; } = new List<Patients>();
    }
}
