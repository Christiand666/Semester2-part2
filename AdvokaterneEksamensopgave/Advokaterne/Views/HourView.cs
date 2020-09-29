using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Advokaterne.Views
{
    public partial class HourView : UserControl
    {
        public HourView()
        {
            InitializeComponent();
        }

        private void HourView_Load(object sender, EventArgs e)
        {
            refreshData();
            foreach(var item in Service.ServiceCRUD.GetAllServicesWithCases())
            {
                comboService.Items.Add(item.Service.Name + " " + item.Service.ID.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            button1.Text = "Indberet";
            txtHoursDriven.Text = "";
            txtHoursWorked.Text = "";
            lblID.Text = "";
        }

        private void refreshData()
        {
            hourDataView.DataSource = Service.HourCRUD.GetAllHours();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Indberet")
            {
                int id = int.Parse(comboService.Text.Split(' ')[comboService.Text.Split(' ').Length - 1]);
                string msg = Service.HourCRUD.CreateHour(int.Parse(txtHoursDriven.Text), int.Parse(txtHoursWorked.Text), dateTimePicker1.Value, id);

                MessageBox.Show(msg);
                refreshData();
            }
            else
            {
                int id = int.Parse(comboService.Text.Split(' ')[comboService.Text.Split(' ').Length - 1]);
                bool success = Service.HourCRUD.UpdateHour(int.Parse(lblID.Text), 
                        int.Parse(txtHoursDriven.Text), 
                        int.Parse(txtHoursWorked.Text), 
                        dateTimePicker1.Value,
                        id
                    );
                if (success)
                {
                    refreshData();
                }else
                {
                    MessageBox.Show("Der skete en fejl prøv igen");
                }
            }
        }

        private void radioService_CheckedChanged(object sender, EventArgs e)
        {
            //var Services = Service.ServiceCRUD.
        }

        private void radioCase_CheckedChanged(object sender, EventArgs e)
        {
            var cases = Service.CaseCRUD.GetAllCases();
            foreach(var item in cases)
            {
                comboService.Items.Add(item.Name + " " + item.ID.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = GetDataRow(hourDataView);
            if (row == null)
                return;

            lblID.Text = row.Cells[0].EditedFormattedValue.ToString();
            txtHoursWorked.Text = row.Cells[1].EditedFormattedValue.ToString();
            txtHoursDriven.Text = row.Cells[2].EditedFormattedValue.ToString();
            dateTimePicker1.Value = DateTime.Parse(row.Cells[3].EditedFormattedValue.ToString() + " 00:00:00 AM");
            foreach(string s in comboService.Items)
            {
                if(s.Split(' ')[s.Split(' ').Length - 1] == row.Cells[4].EditedFormattedValue.ToString())
                {
                    comboService.Text = s;
                    break;
                }
            }
            button1.Text = "Updater timer";
        }

        private DataGridViewRow GetDataRow(DataGridView Data)
        {
            try
            {
                if (Data.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Vælg venligst kun 1 row");
                    return null;
                }
                int index = Data.SelectedRows[0].Index;

                var Row = Data.Rows[index];
                return Row;
            }
            catch
            {
                MessageBox.Show("Vælg venligst en hel række");
                return null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Row = GetDataRow(hourDataView);
            if (Row == null)
                return;

            bool success = Service.HourCRUD.DeleteHour(int.Parse(Row.Cells[0].EditedFormattedValue.ToString()));
            if(!success)
            {
                MessageBox.Show("Der skete en fejl prøv igen, eller indlæs siden igen");
                return;
            }
            refreshData();
            MessageBox.Show("Timer slettet slettet");
        }
    }
}
