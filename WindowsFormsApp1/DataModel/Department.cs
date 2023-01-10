using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModel
{
    public class Department
    {
    //    [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }
  //      [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public ICollection<Patients> Patients { get; set; }  = new List<Patients>();
    }
}
