using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataModel;

namespace WindowsFormsApp1
{

    public partial class EditForm : Form
    {
        //---------------------------------------------------------------------------------------------------------
        Dictionary<string, int> keyValuePairsForDepartment = new Dictionary<string, int>();
        //-----------------------------------Разобраться с дублированием дурацких словарей------------------------------------------------------------------------------------- 
        Dictionary<string, int> keyValuePairsForPatientResult = new Dictionary<string, int>();
        Form1 parent;
        Patients patient;
        public EditForm(Form1 parent, Patients patient)
        {
            this.parent = parent;
            this.patient = patient;
            InitializeComponent();
            FillDepartment();
            FillPatientResult();
            FillCOVID19();

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            using (LogBook context = new LogBook())
            {
                // Department department = new Department();
                // department.Name = "876";
                // PatientResult result1 = new PatientResult();
                // result1.PatientResultName = "Dead";
                // context.Departments.Add(department);
                // context.PatientResults.Add(result1);
                // context.SaveChanges();


                //    patient.PatientID = Patien; автоиндексация
                PatientSurname.Text = patient.PatientSurname;
                PatientName.Text = patient.PatientName;
                PatientLastName.Text = patient.PatientSecondName;
                PatientHistory.Text = patient.PatientMedicalHistoryID.ToString();
                PatientAge.Text = patient.PatientAge.ToString();
                PatientDeliviry.Value = patient.PatientDeliveri;

                var departments = keyValuePairsForDepartment.Keys.ToList();
                for (int i = 0; i < departments.Count; i++)
                {
                    if (departments[i].Equals(patient.Department.Name))
                    {
                        GetDepartment.SelectedIndex = i;
                        break;
                    }
                }

                var results = keyValuePairsForPatientResult.Keys.ToList();
                for (int i = 0; i < results.Count; i++)
                {
                    if (results[i].Equals(patient.PatientResult.PatientResultName))
                    {
                        PatientResult.SelectedIndex = i;
                        break;
                    }
                }

                PatientTransferTime.Value = patient.PatientTransferTime;
                COVID19.SelectedIndex = patient.COVID19 ? 1 : 0;
                //context.Patients.Add(patient);
                // MessageBox.Show($"Ф: {patient.PatientSurname}, И {patient.PatientName}, ИБ {patient.PatientMedicalHistoryID}, В {patient.PatientAge}, DD {patient.PatientDeliveri}, PT{patient.PatientTimeOfHospitalization}");

                // context.SaveChanges();

            }
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

        private void Accept_Click(object sender, EventArgs e)
        {
            using (LogBook context = new LogBook())
            {
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
                //Посмотреть про разрыв связи между таблицами
                dep.Patients.Clear();
                //patient.Department.Patients.Remove(patient);
                //patient.PatientResult.Patients.Remove(patient);
                context.SaveChanges();
                //dep.Patients.Add(patient);
                //
                //int resultId = GetIndexForPatientResult();
                //PatientResult result = (from d in context.PatientResults
                //                        where d.PatientResultID == resultId
                //                        select d).FirstOrDefault();
                //
                //result.Patients.Add(patient);
                //
                //patient.PatientTransferTime = PatientTransferTime.Value;
                //patient.PatientTimeOfHospitalization = patient.PatientTransferTime.Hour - patient.PatientDeliveri.Hour;
                //patient.COVID19 = GetCOVID19(COVID19.SelectedIndex);
                //context.SaveChanges();
            }
        }
    }
}
