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
       //-----------------------------------Разобраться с дублированием дурацких словарей------------------------------------------------------------------------------------- 
        Dictionary<string, int> keyValuePairsForPatientResult = new Dictionary<string, int>();
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

            using (LogBook context = new LogBook())
            {
              // Department department = new Department();
              // department.Name = "876";
              // PatientResult result1 = new PatientResult();
              // result1.PatientResultName = "Dead";
              // context.Departments.Add(department);
              // context.PatientResults.Add(result1);
              // context.SaveChanges();

                Patients patient = new Patients();
             //    patient.PatientID = Patien; автоиндексация
                patient.PatientSurname = PatientSurname.Text;
                patient.PatientName = PatientName.Text;
                patient.PatientSecondName = PatientLastName.Text;
                patient.PatientMedicalHistoryID = int.Parse(PatientHistory.Text);
                patient.PatientAge = int.Parse(PatientAge.Text);
                patient.PatientDeliveri = PatientDeliviry.Value;
                               
                int depId = GetIndexForDepartment();
                Department dep = (from d in context.Departments 
                                  where d.DepartmentID == depId
                                  select d).FirstOrDefault();
        
                dep.Patients.Add(patient);

                int resultId = GetIndexForPatientResult();
                PatientResult result = (from d in context.PatientResults
                                        where d.PatientResultID == resultId
                                        select d).FirstOrDefault();

                result.Patients.Add(patient);

                patient.PatientTransferTime = PatientTransferTime.Value;
                patient.PatientTimeOfHospitalization = patient.PatientTransferTime.Hour - patient.PatientDeliveri.Hour;
                patient.COVID19 = GetCOVID19(COVID19.SelectedIndex);
                //context.Patients.Add(patient);
                // MessageBox.Show($"Ф: {patient.PatientSurname}, И {patient.PatientName}, ИБ {patient.PatientMedicalHistoryID}, В {patient.PatientAge}, DD {patient.PatientDeliveri}, PT{patient.PatientTimeOfHospitalization}");

                MessageBox.Show($"{patient.PatientTransferTime.Hour - patient.PatientDeliveri.Hour}");
                context.SaveChanges();

            }
            MessageBox.Show("Пациент успешно добавлен");
            parentForm.UpdateLogBook();
            Close();
        }

        private void GetDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var r = GetDepartment.SelectedItem.ToString();

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
            var keysForDepartment = keyValuePairsForDepartment.Keys.ToList();

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
            var keysForPatientResult = keyValuePairsForPatientResult.Keys.ToList();

            foreach (var item in keysForPatientResult)
            {
                PatientResult.Items.Add(item);
            }
        }
        private int GetIndexForDepartment()
        {
            var id = keyValuePairsForDepartment[GetDepartment.SelectedItem.ToString()];
            
            return id;
        }
        private int GetIndexForPatientResult()
        {
            var id = keyValuePairsForPatientResult[PatientResult.SelectedItem.ToString()];

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
            return COVID19.SelectedIndex == 1;
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

        private void AddForm_Load(object sender, EventArgs e)
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
