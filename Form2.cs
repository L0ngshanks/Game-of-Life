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

        public string GetNewSeed
        {
            get
            {
                return numericUpDown1_NewSeed.Text;
            }
            set
            {
                numericUpDown1_NewSeed.Text = value;
            }
        }

        private void button1NewSeed_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int newSeed = random.Next();

            numericUpDown1_NewSeed.Text = newSeed.ToString();
        }

        private void button2Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
