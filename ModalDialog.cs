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

        public Color GetAliveColor
        {
            get
            {
                return button3Alive.BackColor;
            }
            set
            {
                button3Alive.BackColor = value;
            }
        }

        public Color DeadColor
        {
            get
            {
                return button1Dead.BackColor;
            }
            set
            {
                button1Dead.BackColor = value;
            }
        }

        public Color GridColor
        {
            get
            {
                return button1GridColor.BackColor;
            }
            set
            {
                button1GridColor.BackColor = value;
            }
        }

        public bool Finite
        {
            get
            {
                return rb_Finite.Checked;
            }
            set
            {
                rb_Finite.Checked = value;
            }
        }

        public bool Toroidal
        {
            get
            {
                return rb_Toroidal.Checked;
            }
            set
            {
                rb_Toroidal.Checked = value;
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

        private void button3Alive_Click(object sender, EventArgs e)
        {
            ColorDialog dlgTextColor = new ColorDialog();

            dlgTextColor.Color = button3Alive.BackColor;

            if (DialogResult.OK == dlgTextColor.ShowDialog())
            {
                button3Alive.BackColor = dlgTextColor.Color;
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

        private void button1Dead_Click(object sender, EventArgs e)
        {
            ColorDialog dlgTextColor = new ColorDialog();

            dlgTextColor.Color = button1Dead.BackColor;

            if (DialogResult.OK == dlgTextColor.ShowDialog())
            {
                button1Dead.BackColor = dlgTextColor.Color;
            }

        }

        private void button1GridColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlgGridColor = new ColorDialog();

            dlgGridColor.Color = button1GridColor.BackColor;

            if (DialogResult.OK == dlgGridColor.ShowDialog())
            {
                button1GridColor.BackColor = dlgGridColor.Color;
            }
        }
    }
}
