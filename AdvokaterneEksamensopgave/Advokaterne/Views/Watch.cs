using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Threading;

namespace Advokaterne.Views
{
    public partial class Watch : UserControl
    {
        public Watch()
        {

            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblTimerSan_Click(object sender, EventArgs e)
        {
        }

        private void Watch_Load(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(KbhTime));
            Thread t2 = new Thread(new ThreadStart(SanFranTime));
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            KbhTime();
            SanFranTime();
        }

        public void KbhTime()
        {
            if (lblTime.InvokeRequired)
                lblTime.Invoke((MethodInvoker)delegate ()
                {
                    KbhTime();
                });
            else lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void SanFranTime()
        {
            if (lblTimerSan.InvokeRequired)
                lblTimerSan.Invoke((MethodInvoker)delegate ()
                {

                    SanFranTime();
                });
            else lblTimerSan.Text = TimeZoneFran();

        }

        public string TimeZoneFran()
        {
            var info = TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            DateTimeOffset localTime = TimeZoneInfo.ConvertTime(localServerTime, info);
            lblTimerSan.Text = Convert.ToString(localTime.ToString("HH:mm:ss"));
            return lblTimerSan.Text;

        }
    }
}
