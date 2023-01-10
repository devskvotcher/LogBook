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
using System.Windows.Forms.Design;
using WindowsFormsApp1.DataModel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            using (LogBook book = new LogBook())
            {
                var deps = book.Departments.ToList();
                var all = book.Patients.ToList();
                if (all.Count > 0)
                {
                    UpdateLogBook();
                }
            }

        }

        public void UpdateLogBook()
        {
            using (LogBook book = new LogBook())
            {
                var all = book.Patients.ToList();
                dataGridView1.RowCount = all.Count;
                dataGridView1.ColumnCount = 12;
                for (int i = 0; i < all.Count; i++)
                {
                    dataGridView1[0, i].Value = all[i].PatientID;
                    dataGridView1[1, i].Value = all[i].PatientSurname;
                    dataGridView1[2, i].Value = all[i].PatientName;
                    dataGridView1[3, i].Value = all[i].PatientSecondName;
                    dataGridView1[5, i].Value = all[i].PatientMedicalHistoryID.ToString();
                    dataGridView1[6, i].Value = all[i].PatientAge;
                    dataGridView1[7, i].Value = all[i].PatientDeliveri.ToShortTimeString();
                    dataGridView1[8, i].Value = all[i].Department.Name;
                    dataGridView1[9, i].Value = all[i].PatientResult.PatientResultName;
                    dataGridView1[10, i].Value = all[i].PatientTimeOfHospitalization;
                    dataGridView1[11, i].Value = all[i].COVID19;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            int patientId = int.Parse(dataGridView1[0, selectedRow].Value.ToString());
            using (LogBook context = new LogBook())
            {
                Patients patient = (from p in context.Patients where p.PatientID == patientId select p).FirstOrDefault();
                if (patient == null)
                {
                    MessageBox.Show("Пациент не выбран");
                }
                else
                {
                    var f = new EditForm(this, patient);
                        f.Show();
                    Hide();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form2 = new AddForm(this);
            Hide();
            form2.Show();

            using (LogBook context = new LogBook())
            {
                //  PatientResult patientResult = new PatientResult();
                //  patientResult.PatientResultID = 1;
                //  patientResult.PatientResultName = "Перевод на отделение";
                //  context.PatientResults.Add(patientResult);
                //  Department department = new Department();
                //  department.DepartmentID = 1;
                //  department.Name = "2-ое инфекционное";
                //  context.Departments.Add(department);

                //  context.SaveChanges();
            }
            using (LogBook book = new LogBook())
            {
                var all = book.Patients.ToList();
                if (all.Count > 0)
                {
                    UpdateLogBook();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            int patientId = int.Parse(dataGridView1[0, selectedRow].Value.ToString());
            using (LogBook context = new LogBook())
            {
                Patients patient = (from p in context.Patients where p.PatientID == patientId select p).FirstOrDefault();
                if (patient == null)
                {
                    MessageBox.Show("Пациент не выбран");
                }
                else
                {
                    context.Patients.Remove(patient);
                    context.SaveChanges();
                    UpdateLogBook();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form3 = new AddDepartments(this);
            Hide();
            form3.Show();
        }
    }
}
