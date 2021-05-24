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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetButtons();
        }

        private void SetButtons()
        {
            button2.BackColor = button3.BackColor = button4.BackColor =
                initBackColor;
        }

        private Color initForeColor = Color.Black;
        private Color initBackColor = Color.Yellow;
        private Button btDraggedfrom;
        private bool dndSuccessful;
        private void ColorActive(Button bt)
        {
            //bt.BackColor = 
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            startDnD(sender as Button);
        }

        private void startDnD(Button button)
        {
            if (button.BackColor == initBackColor)
            {
                return;
            }
            btDraggedfrom = button;
            dndSuccessful = false;
            lbInfo.Text = "Drag and drop started...";

            button.DoDragDrop(new DragData
            {
                BackColor = button.BackColor,
                ForeColor = button.ForeColor
            }, DragDropEffects.Move);

            if (dndSuccessful)
            {
                button.BackColor = initBackColor;
                button.ForeColor = initForeColor;
                btDraggedfrom = null;
                lbInfo.Text = string.Empty;
            }
        }

        private void buttons_DragEnter(object sender, DragEventArgs e)
        {
            Button buttonDrop = sender as Button;
            if (buttonDrop == btDraggedfrom)
            {
                return;
            }
            e.Effect = DragDropEffects.Move;
            lbInfo.Text = "Drag and drop above posible target...";
        }

        private void buttons_DragLeave(object sender, EventArgs e)
        {
            Button buttonDrop = sender as Button;
            if (buttonDrop == btDraggedfrom)
            {
                return;
            }
            lbInfo.Text = "Drag and drop left posible target...";
        }

        private void buttons_DragDrop(object sender, DragEventArgs e)
        {
            Button buttonDrop = sender as Button;
            DragData dragData = e.Data.GetData(typeof(DragData)) as DragData;
            buttonDrop.BackColor = dragData.BackColor;
            buttonDrop.ForeColor = dragData.ForeColor;
            dndSuccessful = true;
        }

    }
}
