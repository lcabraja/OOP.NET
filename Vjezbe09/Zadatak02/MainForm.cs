using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak02
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
        private async void btStart_Click(object sender, EventArgs e)
        {
            long n = long.Parse(tbInput.Text);

            tbInput.Enabled = false;
            btStart.Enabled = false;
            lbTooltip.Text = "Calculating...";

            long result = await CalculateAsync(n);
            
            lbTooltip.Text = result.ToString("#,###");

            tbInput.Enabled = true;
            btStart.Enabled = true;
        }

        private Task<long> CalculateAsync(long n)
        {
            return Task.Run(() => 
            {
                long sum = 0;
                int lastProgress = 0;

                for (int i = 1; i <= n; i++)
                {
                    sum += n;
                }
                return sum;
            });
        }
    }
}
