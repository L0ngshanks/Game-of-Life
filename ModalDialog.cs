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
    public partial class ModalDialog : Form
    {
        public ModalDialog()
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

        public int GetUniverseX
        {
            get
            {
                return (int)numericUpDown1UniversalX.Value;
            }
            set
            {
                numericUpDown1UniversalX.Value = value;
            }
        }
        public int GetUniverseY
        {
            get
            {
                return (int)numericUpDown2UniversalY.Value;
            }
            set
            {
                numericUpDown2UniversalY.Value = value;
            }
        }

        public int TimerInterval
        {
            get
            {
                return (int)nud_TimerInterval.Value;
            }
            set
            {
                nud_TimerInterval.Value = value;
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

        private void button2Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkBox1syncXY_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1syncXY.Checked)
            {
                GetUniverseX = GetUniverseY;
                GetUniverseY = GetUniverseX;
            }
        }

        private void numericUpDown1UniversalX_ValueChanged(object sender, EventArgs e)
        {
            if(checkBox1syncXY.Checked)
            {
                GetUniverseY = GetUniverseX;
            }
        }

        private void numericUpDown2UniversalY_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1syncXY.Checked)
            {
                GetUniverseX = GetUniverseY;
            }
        }
    }
}
