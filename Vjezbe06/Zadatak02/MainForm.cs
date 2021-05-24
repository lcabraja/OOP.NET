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
        private Random r = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private Point mouseDownStartPoint = Point.Empty;

        private void CreatePanel_Click(object sender, EventArgs e)
        {
            ToolStripItem toolStripItem = sender as ToolStripItem;
            int panelNumber = int.Parse(toolStripItem.Text);
            for (int i = 0; i < panelNumber; i++)
            {
                createPanel();
            }
        }

        private Color RandomColor()
        {
            return Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        private Point RandomPointInParent(Control parent, Control child)
        {
            int maxX = parent.Width - child.Width;
            int maxY = parent.Height - child.Height;

            return new Point(r.Next(maxX), r.Next(maxY));
        }

        private Size RandomSize(int min, int max)
        {
            int randomSize = r.Next(min, max);
            return new Size(randomSize, randomSize);
        }

        private void createPanel()
        {
            Panel p = new Panel
            {
                Size = RandomSize(20, 70),
                BackColor = RandomColor()
            };
            p.Location = RandomPointInParent(pnCanvas, p);
            p.MouseDown += P_MouseDown;

            pnCanvas.Controls.Add(p);
        }

        private void P_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
            MarkPanel(panel);
            mouseDownStartPoint = panel.PointToScreen(e.Location);
            panel.DoDragDrop(panel, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void MarkPanel(Panel panel)
        {
            foreach (Panel pp in pnCanvas.Controls)
            {
                pp.BorderStyle = BorderStyle.None;
            }
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BringToFront();
        }

        private void DeleteAllPanels_Click(object sender, EventArgs e)
        {
            pnCanvas.Controls.Clear();
        }

        private void pnCanvas_DragDrop(object sender, DragEventArgs e)
        {
            Panel panel = e.Data.GetData(typeof(Panel)) as Panel;

            int deltaX = mouseDownStartPoint.X - e.X;
            int deltaY = mouseDownStartPoint.Y - e.Y;
            Point newPos = new Point
            {
                X = panel.Location.X - deltaX,
                Y = panel.Location.Y - deltaY
            };

            if (e.Effect == DragDropEffects.Move)
            {
                panel.Location = newPos;
            }
            else if (e.Effect == DragDropEffects.Copy) {
                CopyPanel(panel, newPos);
            }
        }

        private void CopyPanel(Panel panel, Point newPos)
        {
            Panel p = new Panel
            {
                Size = panel.Size,
                BackColor = panel.BackColor
            };
            p.Location = newPos;
            p.MouseDown += P_MouseDown;

            pnCanvas.Controls.Add(p);
        }

        private void pnCanvas_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            } else if (e.KeyState == 2)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
