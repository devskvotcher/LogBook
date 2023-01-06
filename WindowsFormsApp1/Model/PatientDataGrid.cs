using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataModel;

namespace WindowsFormsApp1.Model
{
    public class PatientDataGrid
    {
        Patients patient;

        public PatientDataGrid(Patients p)
        {
            patient = p;
        }

    }
}
