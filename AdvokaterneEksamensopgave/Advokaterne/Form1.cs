using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advokaterne.Views;
using Service;

namespace Advokaterne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Emp = new Views.EmployeeView();
            View.Controls.Clear();
            View.Controls.Add(Emp);
            Emp.AutoScroll = false;
            Emp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var CaseV = new Views.CasesView();
            View.Controls.Clear();
            View.Controls.Add(CaseV);
            CaseV.AutoScroll = false;
            CaseV.Show();
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            var Service = new Views.ServiceView();
            View.Controls.Clear();
            View.Controls.Add(Service);
            Service.AutoScroll = false;
            Service.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var Edu = new Views.EducationView();
            View.Controls.Clear();
            View.Controls.Add(Edu);
            Edu.AutoScroll = false;
            Edu.Show();
        }

        private void btnHours_Click(object sender, EventArgs e)
        {
            var Hours = new Views.HourView();
            View.Controls.Clear();
            View.Controls.Add(Hours);
            Hours.AutoScroll = false;
            Hours.Show();
        }

        private void btnUR_Click(object sender, EventArgs e)
        {
            var watch = new Views.Watch();
            View.Controls.Clear();
            View.Controls.Add(watch);
            watch.AutoScroll = false;
            watch.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Service.Init.CreateDummies();
        }
    }
}
