using Microsoft.Data.SqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            using (LogBook context = new LogBook())
            {
                PatientResult patientResult = new PatientResult();
                patientResult.PatientResultID = 1;
                patientResult.PatientResultName = "Перевод на отделение";
                context.PatientResults.Add(patientResult);
                Department department = new Department();
                department.DepartmentID = 1;
                department.Name = "2-ое инфекционное";
                context.Departments.Add(department);

                Patients patient = new Patients();

                patient.PatientID = 1;
                patient.PatientSurname = "2Трофимов";
                patient.PatientName = "2Сергей";
                patient.PatientSecondName = "2Николаевич";
                patient.PatientMedicalHistoryID = 73207;
                patient.PatientAge = 54;
                patient.PatientDeliveri = new DateTime(2015, 7, 20, 18, 30, 25);
               // patient.DepartmentID = 1;
                patient.PatientTransferTime = new DateTime(2020, 7, 20, 18, 30, 25);
               // patient.PatientResultID = 1;
                patient.PatientTimeOfHospitalization = 25;
                patient.COVID19 = true;


                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
