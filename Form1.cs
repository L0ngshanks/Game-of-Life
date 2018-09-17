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
    public partial class Form1 : Form
    {

        // The universe array
        bool[,] universe = new bool[20, 20];

        bool[,] storage;

        //Universe Dimensions
        int universalX;
        int universalY;

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;
        Color BrushColor = Color.Black;


        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        // The neighbor count
        int neighbors = 0;

        public Form1()
        {
            InitializeComponent();

            //Setup Timer
            timer.Enabled = false;
            timer.Interval = 5;
            timer.Tick += Timer_Tick;

            //Settings Load
            CellColor = Properties.Settings.Default.CellColor;
            BGColor = Properties.Settings.Default.BGColor;
            TextColor = Properties.Settings.Default.TextColor;
            universalX = Properties.Settings.Default.UniverseX;
            universalY = Properties.Settings.Default.UniverseY;

            universe = new bool[universalX, universalY];
        }
        //GetSet for Cell Color
        public Color CellColor
        {
            get
            {
                return cellColor;
            }
            set
            {
                cellColor = value;
            }
        }
        //GetSet for Background Color
        public Color BGColor
        {
            set
            {
                graphicsPanel1.BackColor = value;
            }
            get
            {
                return graphicsPanel1.BackColor;
            }
        }
        //GetSet for Neighbor count brush
        public Color TextColor
        {
            get
            {
                return BrushColor;
            }
            set
            {
                BrushColor = value;
            }
        }

        //Resize the Universe

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private int NeighborCount(int x, int y)
        {
            //Cycle threw the available neighors
            int neighborCount = 0;

            if (x == 0 && y == 0)
            {
                for (int k = 0; k <= 1; ++k)
                {
                    for (int j = 0; j <= 1; ++j)
                    {
                        if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                            neighborCount += 1;
                    }
                }
            }
            else if (x == universe.GetLength(0) - 1 && y == 0)
            {
                for (int k = 0; k <= 1; ++k)
                {
                    for (int j = -1; j <= 0; ++j)
                    {
                        if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                            neighborCount += 1;

                    }
                }
            }
            else if (x == 0 && y == universe.GetLength(1) - 1)
            {
                for (int k = -1; k <= 0; ++k)
                {
                    for (int j = 0; j <= 1; ++j)
                    {
                        if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                            neighborCount += 1;

                    }
                }
            }
            else if (x == universe.GetLength(0) - 1 && y == universe.GetLength(1) - 1)
            {
                for (int k = -1; k <= 0; ++k)
                {
                    for (int j = -1; j <= 0; ++j)
                    {
                        if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                            neighborCount += 1;

                    }
                }
            }
            else if ((x < universe.GetLength(0) - 1 && y == 0))
            {
                for (int k = 0; k <= 1; ++k)
                {
                    for (int j = -1; j <= 1; ++j)
                    {
                        if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                            neighborCount += 1;

                    }
                }
            }
            else if (x == 0 && y < universe.GetLength(1) - 1)
            {
                for (int k = -1; k <= 1; ++k)
                {
                    for (int j = 0; j <= 1; ++j)
                    {
                        if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                            neighborCount += 1;

                    }
                }
            }
            else if (x == universe.GetLength(0) - 1 && y < universe.GetLength(1) - 1)
            {
                for (int k = -1; k <= 1; ++k)
                {
                    for (int j = -1; j <= 0; ++j)
                    {
                        if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                            neighborCount += 1;

                    }
                }
            }
            else if (x > 0 && y == universe.GetLength(1) - 1)
            {
                for (int k = -1; k <= 0; ++k)
                {
                    for (int j = -1; j <= 1; ++j)
                    {
                        if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                            neighborCount += 1;

                    }
                }
            }
            else if (x < universe.GetLength(0) - 1 && y < universe.GetLength(1) - 1)
            {
                for (int k = -1; k <= 1; ++k)
                {
                    for (int j = -1; j <= 1; ++j)
                    {
                        if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                            neighborCount += 1;

                    }
                }
            }

            return neighborCount;
        }

        private bool[,] Rules(int x, int y, bool[,] ruleStorage, int counter)
        {
            if (universe[x, y] && counter < 2)
                ruleStorage[x, y] = false;
            else if (universe[x, y] && counter > 3)
                ruleStorage[x, y] = false;
            else if (universe[x, y] && (counter == 2 || counter == 3))
                ruleStorage[x, y] = true;
            else if (!(universe[x, y]) && counter == 3)
                ruleStorage[x, y] = true;

            return ruleStorage;
        }

        private void NextGeneration()
        {
            universalX = universe.GetLength(0);
            universalY = universe.GetLength(1);
            storage = new bool[universalX, universalY];

            //Find Cells
            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    neighbors = NeighborCount(x, y);
                    storage = Rules(x, y, storage, neighbors);

                    //Console.WriteLine("Cell: " + x + "," + y + " has " + neighbors + " neighbors");
                }
            }

            //Calc next generation Universe
            generations++;

            bool[,] temp = universe;
            universe = storage;
            storage = temp;

            graphicsPanel1.Invalidate();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Print Neighbors
            int printNeighbors = 0;

            // The width and height of each cell in pixels
            // Convert to Floats
            float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush
            Brush cellBrush = new SolidBrush(cellColor);

            //Text Brush
            SolidBrush txtBrush = new SolidBrush(BrushColor);


            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    // RectangleF Floats...
                    RectangleF cellRect = Rectangle.Empty;
                    cellRect.X = (float)x * cellWidth;
                    cellRect.Y = (float)y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush
                    if (universe[x, y])
                        e.Graphics.FillRectangle(cellBrush, cellRect);

                    // Print neighbor count to rectangle
                    Font font = new Font("Arial", (cellWidth / 2) - 5);

                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;

                    //Rectangle rect = new Rectangle(0, 0, 100, 100);
                    printNeighbors = NeighborCount(x, y);

                    e.Graphics.DrawString(printNeighbors.ToString(), font, txtBrush, cellRect, stringFormat);


                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                }
            }

            toolStripStatusGenerations.Text = "Generations = " + generations.ToString();

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Change to Floats
                // Width and Height of each cell in pixels
                float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
                float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

                float x = e.X / cellWidth;
                float y = e.Y / cellHeight;

                universe[(int)x, (int)y] = !universe[(int)x, (int)y];

                graphicsPanel1.Invalidate();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }

            generations = 0;
            graphicsPanel1.Invalidate();
        }

        private void toolStripButtonPlay_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void toolStripButtonPause_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            NextGeneration();
            graphicsPanel1.Invalidate();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Modal Settings form
            ModalDialog settingsForm = new ModalDialog();

            //Get Data for Modal Form
            settingsForm.GetCellColor = CellColor;
            settingsForm.GetBGColor = graphicsPanel1.BackColor;
            settingsForm.GetTextColor = BrushColor;
            settingsForm.GetUniverseX = universalX;
            settingsForm.GetUniverseY = universalY;
            
            DialogResult result = settingsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Program Color's
                CellColor = settingsForm.GetCellColor;
                graphicsPanel1.BackColor = settingsForm.GetBGColor;
                BrushColor = settingsForm.GetTextColor;
                // Universe Dimensions
                universalX = settingsForm.GetUniverseX;
                universalY = settingsForm.GetUniverseY;

                universe = new bool[universalX, universalY];
                

                //Push data to Settings
                Properties.Settings.Default.CellColor = settingsForm.GetCellColor;
                Properties.Settings.Default.BGColor = settingsForm.GetBGColor;
                Properties.Settings.Default.TextColor = settingsForm.GetTextColor;
                Properties.Settings.Default.UniverseX = settingsForm.GetUniverseX;
                Properties.Settings.Default.UniverseY = settingsForm.GetUniverseY;

                //Save Settings
                Properties.Settings.Default.Save();
            }
            graphicsPanel1.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}