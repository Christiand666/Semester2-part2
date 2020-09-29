using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advokaterne.Views
{
    public partial class CasesView : UserControl
    {
        public CasesView()
        {
            InitializeComponent();
        }

        private void CasesView_Load(object sender, EventArgs e)
        {
            foreach(string s in Service.EmployeeCRUD.GetSpec())
            {
                comboSpecial.Items.Add(s);
            }

            foreach(string s in Service.CustomerCRUD.GetCustomerList())
            {
                comboClient.Items.Add(s);
            }

            foreach(var item in Service.CaseCRUD.GetAllCases())
            {
                
                ComboCases.Items.Add(item.Name + " " + item.ID.ToString());
            }

            foreach(var ep in Service.EmployeeCRUD.GetEmployeeList(true))
            
            {
                    comboEmployee.Items.Add(ep);
            }
            
        }

        private void ComboCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCases.Text == " ")
            {
                MessageBox.Show("Vælg eller opret en kunde");
                return;
            }
            if (ComboCases.Text == "Ny Case")
            {
                BtnCase.Text = "Create Case";

                txtName.Clear();
                DescriptionTextBox1.Clear();
                comboEmployee.Text = "";
                comboSpecial.Text = "";
            }
            else
            {
                BtnCase.Text = "Update Case";

                string[] strings1 = ComboCases.Text.Split(' ');
                lblCaseID.Text = strings1[strings1.Length - 1];

                var CaseC = Service.CaseCRUD.GetCaseByID(int.Parse(strings1[strings1.Length - 1]));
                txtName.Text = CaseC.Name;
                DescriptionTextBox1.Text = CaseC.Description;



                string[] strings = lblCaseID.Text.Split(' ');
                lblCaseID.Text = strings[strings.Length - 1];

                var response = Service.CaseCRUD.GetClientByCaseID(int.Parse(strings[strings.Length - 1]));

                txtfName.Text = response.client.fName;
                txtlName.Text = response.client.lName;
                txtCPR.Text = response.client.CPR;
                txtPhone.Text = response.client.Phone.ToString();
                txtTlf.Text = response.client.Telephone.ToString();
                txtEmail.Text = response.client.email;
                comboSpecial.Text = response.Employee.Special;
                comboEmployee.Text = response.Employee.fName + " " + response.Employee.lName + " " + response.Employee.ID.ToString();

                foreach (string s in comboClient.Items)
                {
                    if (s.Contains(response.client.ID.ToString()))
                    {
                        comboClient.Text = s;
                        break;
                    }
                }
           
               

            }

        }

        private void BtnCase_Click(object sender, EventArgs e)
        {
            if (lblCustomID.Text == "")
            {
                MessageBox.Show("Vælg eller opret en kunde");
                return;
            }
            if (ComboCases.Text == "Ny Case")
            {
               


                string[] strings = comboEmployee.Text.Split(' ');
                string employeID = strings[strings.Length - 1];

                string[] strings2 = lblCustomID.Text.Split(' ');
                string customID = strings2[strings2.Length - 1];
                string success = Service.CaseCRUD.CreateCase(txtName.Text, DescriptionTextBox1.Text, Guid.Parse(employeID), Guid.Parse(customID));
                if (success == null)
                {
                    MessageBox.Show("Der skete en fejl, prøv igen");
                }
                else
                {
                    MessageBox.Show("Case oprettet");
                }
            }else if (ComboCases.Text == "Vælg en Case") {
                MessageBox.Show("Vælg en case");
                return;
            }
            else
            {
                string[] strings = comboEmployee.Text.Split(' ');
                string employeIDU = strings[strings.Length - 1];
                bool success = Service.CaseCRUD.UpdateCase(int.Parse(lblCaseID.Text), txtName.Text, DescriptionTextBox1.Text, Guid.Parse(employeIDU), Guid.Parse(lblCustomID.Text)) ;
                if (success)
                    MessageBox.Show("Ansat updateret");
                else
                    MessageBox.Show("Der skete en fejl prøv igen");
            }
        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboClient.Text == "Opret kunde")
            {
                lblCustomID.Text = "";
                BtnCustomer.Text = "Opret Kunde";

                txtfName.Clear();
                txtlName.Clear();
                txtCPR.Clear();
                txtPhone.Clear();
                txtTlf.Clear();
                txtEmail.Clear();
            }
            else
            {
                BtnCustomer.Text = "Updater kunde";
                string[] strings = comboClient.Text.Split(' ');
                lblCustomID.Text = strings[strings.Length - 1];

                var cli = Service.CustomerCRUD.GetClientByID(Guid.Parse(strings[strings.Length - 1]));
                txtCPR.Text = cli.CPR;
                txtEmail.Text = cli.email;
                txtfName.Text = cli.fName;
                txtlName.Text = cli.lName;
                txtPhone.Text = cli.Phone.ToString();
                txtTlf.Text = cli.Telephone.ToString();
            }
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length != 8)
            {
                MessageBox.Show("Telefonnummer skal være 8 tegn");
                return;
            }
            if (txtTlf.Text.Length != 8)
            {
                MessageBox.Show("Telefonnummer skal være 8 tegn");
                return;
            }
            if (comboClient.Text == "Opret kunde")
            {
                var client = Service.CustomerCRUD.CreateClient(txtfName.Text, txtlName.Text, txtCPR.Text, int.Parse(txtPhone.Text), txtEmail.Text, int.Parse(txtTlf.Text));
                
                if (client == null)
                    MessageBox.Show("Der skete en fejl prøv igen med create");
                else
                    lblCustomID.Text = client.ID.ToString();
            }
            else
            {
                bool success = Service.CustomerCRUD.UpdateClient(Guid.Parse(lblCustomID.Text), txtEmail.Text, txtfName.Text, txtlName.Text, int.Parse(txtPhone.Text), txtCPR.Text, int.Parse(txtTlf.Text));
                if (success)
                    MessageBox.Show("Ansat updateret");
                else
                    MessageBox.Show("Der skete en fejl prøv igen med update");
            }
        }

      

        private void comboSpecial_SelectedIndexChanged(object sender, EventArgs e)
        { 
            comboEmployee.Items.Clear();
            foreach (var item in Service.EmployeeCRUD.GetNamesBySpecial(comboSpecial.Text))
            {
                comboEmployee.Items.Add(item);
                comboEmployee.Text = item;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = Service.CaseCRUD.DeleteCase(int.Parse(lblCaseID.Text));
            if (success)
                MessageBox.Show("Data slettet");
            else
                MessageBox.Show("Der skete en fejl, prøv igen eller kør oprydningsprogrammet");
        }
    }
}
