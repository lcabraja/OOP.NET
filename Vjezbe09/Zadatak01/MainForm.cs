using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void ShowTime()
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void tmTimer_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            long n = long.Parse(tbInput.Text);

            tbInput.Enabled = false;
            btStart.Enabled = false;
            btStop.Enabled = true;
            lbTooltip.Text = "Calculating...";

            bwWorker.RunWorkerAsync(n);
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            bwWorker.CancelAsync();
            resetButtons();
        }

        private void resetButtons()
        {
            tbInput.Enabled = true;
            btStart.Enabled = true;
            btStop.Enabled = false;
        }

        // runs in background thread
        private void bwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            long n = (long)e.Argument;
            long sum = 0;
            int lastProgress = 0;
            
            for (int i = 1; i <= n; i++)
            {
                if(bwWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                int curProgress = (int)(((double) i / n) * 100);
                if(curProgress > lastProgress)
                {
                    bwWorker.ReportProgress(curProgress);
                    lastProgress = curProgress;
                }
                sum += n;
            }

            e.Result = sum;
        }

        // runs in main thread
        private void bwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProgress.Value = e.ProgressPercentage;
            lbPercent.Text = $"{e.ProgressPercentage}%";
        }

        // runs in main thread
        private void bwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbTooltip.Text = "Calculation aborted...";
                return;
            }
            lbTooltip.Text = ((long)e.Result).ToString("#,###");
            resetButtons();
        }

    }
}
