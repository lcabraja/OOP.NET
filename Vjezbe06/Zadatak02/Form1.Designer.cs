
namespace Zadatak02
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
            this.contextMenuForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createPanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllPanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnCanvas = new System.Windows.Forms.Panel();
            this.contextMenuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuForm
            // 
            this.contextMenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPanelsToolStripMenuItem,
            this.deleteAllPanelsToolStripMenuItem});
            this.contextMenuForm.Name = "contextMenuStrip1";
            this.contextMenuForm.Size = new System.Drawing.Size(160, 48);
            // 
            // createPanelsToolStripMenuItem
            // 
            this.createPanelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.createPanelsToolStripMenuItem.Name = "createPanelsToolStripMenuItem";
            this.createPanelsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.createPanelsToolStripMenuItem.Text = "Create Panels";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.CreatePanel_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "5";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.CreatePanel_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "10";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.CreatePanel_Click);
            // 
            // deleteAllPanelsToolStripMenuItem
            // 
            this.deleteAllPanelsToolStripMenuItem.Name = "deleteAllPanelsToolStripMenuItem";
            this.deleteAllPanelsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.deleteAllPanelsToolStripMenuItem.Text = "Delete all panels";
            this.deleteAllPanelsToolStripMenuItem.Click += new System.EventHandler(this.DeleteAllPanels_Click);
            // 
            // pnCanvas
            // 
            this.pnCanvas.AllowDrop = true;
            this.pnCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnCanvas.Name = "pnCanvas";
            this.pnCanvas.Size = new System.Drawing.Size(984, 761);
            this.pnCanvas.TabIndex = 1;
            this.pnCanvas.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnCanvas_DragDrop);
            this.pnCanvas.DragOver += new System.Windows.Forms.DragEventHandler(this.pnCanvas_DragOver);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.ContextMenuStrip = this.contextMenuForm;
            this.Controls.Add(this.pnCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuForm;
        private System.Windows.Forms.ToolStripMenuItem createPanelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteAllPanelsToolStripMenuItem;
        private System.Windows.Forms.Panel pnCanvas;
    }
}

