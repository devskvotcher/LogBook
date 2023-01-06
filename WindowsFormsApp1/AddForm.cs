using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddForm : Form
    {
        Form1 parentForm;

        //---------------------------------------------------------------------------------------------------------
        Dictionary<string, int> keyValuePairsForDepartment = new Dictionary<string, int>();
        List<string> keysForDepartment = new List<string>();
       //-----------------------------------Разобраться с дублированием дурацких словарей------------------------------------------------------------------------------------- 
        Dictionary<string, int> keyValuePairsForPatientResult = new Dictionary<string, int>();
        List<string> keysForPatientResult = new List<string>();
        public AddForm(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            PatientSurname.TextChanged += PatientSurname_TextChanged;
            PatientName.TextChanged += PatientName_TextChanged;
            PatientLastName.TextChanged += PatientLastName_TextChanged;
            PatientHistory.TextChanged += PatientHistory_TextChanged;
            PatientAge.TextChanged += PatientAge_TextChanged;
            PatientDeliviry.ValueChanged += PatientDeliviry_ValueChanged;
            PatientTransferTime.ValueChanged += PatientTransferTime_ValueChanged;            
            FillDepartment();           
            FillPatientResult();
            FillCOVID19();
        }
        //-------------------------------------------------------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            Close();

            using (LogBook context = new LogBook())
            {
                Patients patient = new Patients();
             //    patient.PatientID = Patien; автоиндексация
                patient.PatientSurname = PatientSurname.Text;
                patient.PatientName = PatientName.Text;
                patient.PatientSecondName = PatientLastName.Text;
                patient.PatientMedicalHistoryID = int.Parse(PatientHistory.Text);
                patient.PatientAge = int.Parse(PatientAge.Text);
                patient.PatientDeliveri = DateTime.ParseExact(PatientDeliviry.Text, "gdd-MM-yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                patient.DepartmentID = GetDepartment.SelectedIndex;
                patient.PatientTransferTime = DateTime.ParseExact(PatientDeliviry.Text, "gdd-MM-yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                patient.PatientResultID = PatientResult.SelectedIndex;
             //  patient.PatientTimeOfHospitalization = 25;
                patient.COVID19 = GetCOVID19(COVID19.SelectedIndex);
                context.Patients.Add(patient);
            }
        }

        private void GetDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

            GetIndexForDepartment();            
        }

        private void PatientResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetIndexForPatientResult();        
        }
        private void FillDepartment()
        {
            GetDepartment.SelectedIndexChanged += GetDepartment_SelectedIndexChanged;
            using (LogBook book = new LogBook())
            {
                var deps = book.Departments;
                foreach (var item in deps)
                {
                    keyValuePairsForDepartment[item.Name] = item.DepartmentID;
                }
            }
            keysForDepartment = keyValuePairsForDepartment.Keys.ToList();

            foreach (var item in keysForDepartment)
            {
                GetDepartment.Items.Add(item);
            }
        }

        private void FillPatientResult()
        {
            PatientResult.SelectedIndexChanged += PatientResult_SelectedIndexChanged;
            using (LogBook book = new LogBook())
            {
                var patientResult = book.PatientResults;
                foreach (var item in patientResult)
                {
                    keyValuePairsForPatientResult[item.PatientResultName] = item.PatientResultID;
                }
            }
            keysForPatientResult = keyValuePairsForPatientResult.Keys.ToList();

            foreach (var item in keysForPatientResult)
            {
                PatientResult.Items.Add(item);
            }
        }
        private int GetIndexForDepartment()
        {
            var id = keyValuePairsForDepartment[keysForDepartment[GetDepartment.SelectedIndex]];
            
            return id;
        }
        private int GetIndexForPatientResult()
        {
            var id = keyValuePairsForPatientResult[keysForPatientResult[GetDepartment.SelectedIndex]];

            return id;
        }
        private void FillCOVID19()
        {
            COVID19.SelectedIndexChanged += COVID19_SelectedIndexChanged;
            COVID19.Items.Add("Да");
            COVID19.Items.Add("Нет");
        }

        private void COVID19_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private bool GetCOVID19(int selectedIndexChanged)
        {
            if(COVID19.SelectedIndex == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PatientSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientDeliviry_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PatientTransferTime_ValueChanged(object sender, EventArgs e)
        {

        }

        //   ForPatientResult
        //   ForDepartment
        //    private void ClearList()
        //    {
        //        keyValuePairs.Clear();
        //        keys.Clear();
        //    }

        // private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        //     List<string> keys;
        //     using (LogBook book = new LogBook())
        //     {
        //         var deps = book.Departments;
        //         foreach (var item in deps)
        //         {
        //             keyValuePairs[item.Name] = item.DepartmentID;
        //         }
        //     }
        //     // dateTimePicker1.Value;
        //     keys = keyValuePairs.Keys.ToList();
        //
        //     foreach (var item in keys)
        //     {
        //         GetDepartment.Items.Add(item);
        //     }
        //
        //     var id = keyValuePairs[keys[GetDepartment.SelectedIndex]];
        //     // MessageBox.Show($"Выбран {keys[GetDepartment.SelectedIndex]}, его индекс {id}");
        // }
    }
}
