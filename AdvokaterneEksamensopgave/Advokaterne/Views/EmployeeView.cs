using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

namespace Advokaterne.Views
{
    public partial class EmployeeView : UserControl
    {
        public EmployeeView()
        {
            InitializeComponent();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            ComboEmployees.Items.Add("NEW");
            foreach (string s in Service.EmployeeCRUD.GetEmployeeList(true)) 
            {
                ComboEmployees.Items.Add(s);
            }
        }

        private void ComboEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboEmployees.Text == "NEW")
            {
                btnAction.Text = "Create";
            } else
            {
                btnAction.Text = "Update";
                var strings = ComboEmployees.Text.Split(' ');
                string lName = string.Empty;
                for (int i = 0; i < strings.Length; i++)
                {
                    if(i == strings.Length)
                    {
                        break;
                    }
                    if (i > 1)
                        lName += " ";
                    if (i > 0)
                        lName += strings[i];
                }
                var Employee = Service.EmployeeCRUD.GetEmplyeeByID(Guid.Parse(strings[strings.Length - 1]));
                txtEmail.Text = Employee.email;
                txtfName.Text = Employee.fName;
                txtlName.Text = Employee.lName;
                txtPhone.Text = Employee.phone.ToString();
                txtSpecial.Text = Employee.Special;
                lblID.Text = Employee.ID.ToString();
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if(txtPhone.Text.Length != 8)
            {
                MessageBox.Show("Telefonnummer skal være 8 tegn");
                return;
            }
            if (ComboEmployees.Text == "Vælg en ansat")
                MessageBox.Show("Vælg en ansat");
            if(ComboEmployees.Text == "NEW")
            {
                if (int.TryParse(txtPhone.Text, out int phone))
                {
                    bool success = Service.EmployeeCRUD.CreateEmployee(txtfName.Text, txtlName.Text, txtSpecial.Text, int.Parse(txtPhone.Text), txtEmail.Text);
                    if (!success)
                    {
                        MessageBox.Show("Der skete en fejl, prøv igen");
                    }
                    else
                    {
                        MessageBox.Show("Ansat oprettet");
                    }
                }else
                {
                    MessageBox.Show("Telefon nummeret skal være tal");
                    return;
                }
            }else
            {
                bool success = Service.EmployeeCRUD.UpdateEmployee(Guid.Parse(lblID.Text), txtEmail.Text, txtfName.Text, txtlName.Text, int.Parse(txtPhone.Text), txtSpecial.Text);
                if (success)
                    MessageBox.Show("Ansat updateret");
                else
                    MessageBox.Show("Der skete en fejl prøv igen");
            }
        }
    }
}
