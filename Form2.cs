using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Color GetCellColor
        {
            set
            {
                button1CellColor.BackColor = value;
            }
            get
            {
                return button1CellColor.BackColor;
            }
        }

        public Color GetBGColor
        {
            set
            {
                button2BGColor.BackColor = value;
            }
            get
            {
                return button2BGColor.BackColor;
            }
        }

        public Color GetTextColor
        {
            get
            {
                return button3TextColor.BackColor;
            }
            set
            {
                button3TextColor.BackColor = value;
            }
        }
        private void button1CellColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlgCell = new ColorDialog();

            dlgCell.Color = button1CellColor.BackColor;

            if (DialogResult.OK == dlgCell.ShowDialog())
            {
                button1CellColor.BackColor = dlgCell.Color;
            }
        }

        private void button2BGColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlgBGColor = new ColorDialog();

            dlgBGColor.Color = button2BGColor.BackColor;

            if (DialogResult.OK == dlgBGColor.ShowDialog())
            {
                button2BGColor.BackColor = dlgBGColor.Color;
            }
        }

        private void button3TextColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlgTextColor = new ColorDialog();

            dlgTextColor.Color = button3TextColor.BackColor;

            if (DialogResult.OK == dlgTextColor.ShowDialog())
            {
                button3TextColor.BackColor = dlgTextColor.Color;
            }
        }

        private void button4OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button5Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
