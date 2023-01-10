using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddDepartments : Form
    {
        Form1 form;
        public AddDepartments(Form1 parentForm)
        {
            form = parentForm;
            InitializeComponent();
            
        }

        private void AddDepartments_Load(object sender, EventArgs e)
        {
            form.UpdateLogBook();
        }
    }
}
