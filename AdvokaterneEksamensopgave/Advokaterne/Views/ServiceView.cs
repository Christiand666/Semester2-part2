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
    public partial class ServiceView : UserControl
    {
        public ServiceView()
        {

            InitializeComponent();

        }

        private void ServiceView_Load(object sender, EventArgs e)
        {
            foreach (var item in Service.CaseCRUD.GetAllCases())
            {
                comboCase.Items.Add(item.Name + " " + item.ID.ToString());
            }
            foreach (var item in Service.ServiceCRUD.GetAllServicesWithCases())
            {
                comboService.Items.Add(item.Service.Name + " " + item.Service.ID.ToString());
            }

        }

        private void udregnBtn_Click(object sender, EventArgs e)
        {

        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] CaseStrings = comboCase.Text.Split(' ');
            lblCaseID.Text = CaseStrings[CaseStrings.Length - 1];
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            if(comboService.Text == "Opret service")
            {
                if(!int.TryParse(txtPrice.Text, out int price))
                {
                    MessageBox.Show("Pris var ikke et helt tal");
                    return;
                }
                string[] strings = comboCase.Text.Split(' ');
                if(!int.TryParse(strings[strings.Length - 1], out int CaseID))
                {
                    MessageBox.Show("Der skete en fejl prøv at genindlæse programmet");
                    return;
                }
                string response = Service.ServiceCRUD.CreateService(txtName.Text, price, radioIsHourlyPay.Checked, CaseID);
                MessageBox.Show(response);
            }
            else if(comboService.Text != "Vælg en service")
            {
                if(!int.TryParse(txtPrice.Text, out int Price))
                {
                    MessageBox.Show("Prisen var ikke et helt tal");
                    return;
                }

                bool success = Service.ServiceCRUD.UpdateService(int.Parse(lblServiceID.Text), 
                    txtName.Text, Price, 
                    radioIsHourlyPay.Checked, 
                    int.Parse(lblCaseID.Text));

                if(success)
                {
                    MessageBox.Show("Service updateres");
                }else
                {
                    MessageBox.Show("Fejl, prøv igen");
                }
            }
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboService.Text == "Opret service")
            {
                BtnAction.Text = "Opret Service";
            }else
            {
                BtnAction.Text = "Update Service";

                string[] strings = comboService.Text.Split(' ');
                lblServiceID.Text = strings[strings.Length - 1];

                var response = Service.ServiceCRUD.GetServiceByID(int.Parse(strings[strings.Length - 1]));

                txtName.Text = response.Service.Name;
                txtPrice.Text = response.Service.Price.ToString();
                radioIsHourlyPay.Checked = response.Service.isHourly;

                foreach(string s in comboCase.Items)
                {
                    if(s.Contains(response.Case.ID.ToString()))
                    {
                        comboCase.Text = s;
                        break;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = Service.ServiceCRUD.DeleteService(int.Parse(lblServiceID.Text));
            if (!success)
                MessageBox.Show("Der skete en fejl prøv igen");
            else
            {
                MessageBox.Show("Service slettet");
                foreach (var item in Service.ServiceCRUD.GetAllServicesWithCases())
                {
                    comboService.Items.Add(item.Service.Name + " " + item.Service.ID.ToString());
                }
            }
                

        }
    }
}
