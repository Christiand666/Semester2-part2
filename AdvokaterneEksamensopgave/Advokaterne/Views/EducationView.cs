using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

namespace Advokaterne.Views
{
    public partial class EducationView : UserControl
    {
        public EducationView()
        {
            InitializeComponent();
        }

        private void EducationView_Load(object sender, EventArgs e)
        {
            var Employees = Service.EducationCRUD.GetAllEmplyeesUnderEducation();
            dataGridEducationOngoing.DataSource = Employees;

            foreach(string s in Service.EmployeeCRUD.GetEmployeeList(false))
            {
                comboEmployees.Items.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strings = comboEmployees.Text.Split(' ');
            string lName = string.Empty;
            for(int i = 0; i < strings.Length; i++)
            {
                if(i != 0)
                {
                    lName += strings[i];
                    if (i < strings.Length)
                        lName += " ";
                }
            }
            bool success = Service.EducationCRUD.EducateEmployee(Guid.Parse(lblID.Text), strings[0], lName, textBox1.Text, DateStart.Value, DateEnd.Value);
            if (success)
                MessageBox.Show("Ansat sendt til uddannelse");
            else
                MessageBox.Show("Der skete en fejl, tjek om medarbejderen allerede er under uddannelse i pærioden eller prøv igen");

            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = GetDataRow(dataGridEducationOngoing);
            if (row == null)
                return;
            Service.EducationCRUD.DeleteEducationByID(Guid.Parse(row.Cells[4].EditedFormattedValue.ToString()));
            RefreshData();
        }

        private DataGridViewRow GetDataRow(DataGridView Data)
        {
            try
            {
                if (Data.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Please only choose one row");
                    return null;
                }
                int index = Data.SelectedRows[0].Index;

                var Row = Data.Rows[index];
                return Row;
            }
            catch
            {
                MessageBox.Show("Please select a whole row");
                return null;
            }
        }

        private void RefreshData()
        {
            var Employees = Service.EducationCRUD.GetAllEmplyeesUnderEducation();
            dataGridEducationOngoing.DataSource = Employees;
        }

        private void comboEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strings = comboEmployees.Text.Split(' ');
            lblID.Text = strings[strings.Length - 1];
        }
    }
}
