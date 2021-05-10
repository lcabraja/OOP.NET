
namespace Zadatak01
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbComputeTooltip = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.lbPercent = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.tmTimer = new System.Windows.Forms.Timer(this.components);
            this.bwWorker = new System.ComponentModel.BackgroundWorker();
            this.lbTooltip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time since start:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(107, 9);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(12, 15);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "-";
            // 
            // lbComputeTooltip
            // 
            this.lbComputeTooltip.AutoSize = true;
            this.lbComputeTooltip.Location = new System.Drawing.Point(12, 34);
            this.lbComputeTooltip.Name = "lbComputeTooltip";
            this.lbComputeTooltip.Size = new System.Drawing.Size(127, 15);
            this.lbComputeTooltip.TabIndex = 2;
            this.lbComputeTooltip.Text = "Ammount to compute";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(157, 31);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(129, 23);
            this.tbInput.TabIndex = 3;
            this.tbInput.Text = "500000000";
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 60);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(139, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Calculate";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(157, 60);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(129, 23);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "Abort";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPercent.Location = new System.Drawing.Point(263, 97);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(24, 15);
            this.lbPercent.TabIndex = 6;
            this.lbPercent.Text = "0%";
            this.lbPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(12, 89);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(230, 23);
            this.pbProgress.TabIndex = 7;
            // 
            // tmTimer
            // 
            this.tmTimer.Interval = 1000;
            this.tmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
            // 
            // bwWorker
            // 
            this.bwWorker.WorkerReportsProgress = true;
            this.bwWorker.WorkerSupportsCancellation = true;
            this.bwWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwWorker_DoWork);
            this.bwWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwWorker_ProgressChanged);
            this.bwWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwWorker_RunWorkerCompleted);
            // 
            // lbTooltip
            // 
            this.lbTooltip.AutoSize = true;
            this.lbTooltip.Location = new System.Drawing.Point(12, 115);
            this.lbTooltip.Name = "lbTooltip";
            this.lbTooltip.Size = new System.Drawing.Size(133, 15);
            this.lbTooltip.TabIndex = 8;
            this.lbTooltip.Text = "Press Calculate to begin";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 168);
            this.Controls.Add(this.lbTooltip);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbComputeTooltip);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbComputeTooltip;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Timer tmTimer;
        private System.ComponentModel.BackgroundWorker bwWorker;
        private System.Windows.Forms.Label lbTooltip;
    }
}