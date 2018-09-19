using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        //isAlive
        uint isAlive = 0;

        //Timer Interval
        int timerInterval = 5;

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

        //Current Seed
        int seed;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        // The neighbor count
        int neighbors = 0;

        public Form1()
        {
            InitializeComponent();

            //Settings Load
            CellColor = Properties.Settings.Default.CellColor;
            BGColor = Properties.Settings.Default.BGColor;
            TextColor = Properties.Settings.Default.TextColor;
            universalX = Properties.Settings.Default.UniverseX;
            universalY = Properties.Settings.Default.UniverseY;
            timerInterval = Properties.Settings.Default.TimerInterval;
            seed = Properties.Settings.Default.CurrentSeed;
            gridVisibleToolStripMenuItem.Checked = Properties.Settings.Default.GridVisible;
            tsmi_NeighborCountVisible.Checked = Properties.Settings.Default.NCVisible;

            //Setup Timer
            timer.Enabled = false;
            timer.Interval = timerInterval;
            timer.Tick += Timer_Tick;

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

        private void LivingCellCout()
        {
            isAlive = 0;

            for (int y = 0; y < universe.GetLength(1); ++y)
            {
                for (int x = 0; x < universe.GetLength(0); ++x)
                {
                    if (universe[x, y])
                        isAlive++;
                }
            }

            toolStripStatusLabel1isAlive.Text = "Alive = " + isAlive.ToString();
        }

        private void PrintNeighborCount(object sender, PaintEventArgs e)
        {

            //Text Brush
            SolidBrush txtBrush = new SolidBrush(BrushColor);

            // The width and height of each cell in pixels
            // Convert to Floats
            float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);


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

                    if (tsmi_NeighborCountVisible.Checked)
                    {
                        cellRect.Width = cellWidth;
                        cellRect.Height = cellHeight;

                        // Print neighbor count to rectangle
                        Font font = new Font("Arial", (cellWidth / 2) - 2);

                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        //Rectangle rect = new Rectangle(0, 0, 100, 100);
                        printNeighbors = NeighborCount(x, y);
                        if (printNeighbors != 0)
                            e.Graphics.DrawString(printNeighbors.ToString(), font, txtBrush, cellRect, stringFormat);
                    }


                    // Outline the cell with a pen
                    if (gridVisibleToolStripMenuItem.Checked)
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                    //Get Alive Cell count
                    if (universe[x, y])
                        isAlive++;
                }
            }

            LivingCellCout();

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
            settingsForm.TimerInterval = timerInterval;

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

                //Timer Interval
                timerInterval = settingsForm.TimerInterval;

                //Push data to Settings
                Properties.Settings.Default.CellColor = settingsForm.GetCellColor;
                Properties.Settings.Default.BGColor = settingsForm.GetBGColor;
                Properties.Settings.Default.TextColor = settingsForm.GetTextColor;
                Properties.Settings.Default.UniverseX = settingsForm.GetUniverseX;
                Properties.Settings.Default.UniverseY = settingsForm.GetUniverseY;
                Properties.Settings.Default.TimerInterval = settingsForm.TimerInterval;

                //Save Settings
                Properties.Settings.Default.Save();
            }
            graphicsPanel1.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2; dlg.DefaultExt = "cells";


            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                // Write any comments you want to include first.
                // Prefix all comment strings with an exclamation point.
                // Use WriteLine to write the strings to the file. 
                // It appends a CRLF for you.
                writer.WriteLine("!This is my comment.");

                // Iterate through the universe one row at a time.
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    // Create a string to represent the current row.
                    String currentRow = string.Empty;

                    // Iterate through the current row one cell at a time.
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        // If the universe[x,y] is alive then append 'O' (capital O)
                        // to the row string.
                        if (universe[x, y])
                            writer.Write("O");
                        // Else if the universe[x,y] is dead then append '.' (period)
                        // to the row string.
                        else
                            writer.Write(".");
                    }

                    // Once the current row has been read through and the 
                    // string constructed then write it to the file using WriteLine.
                    writer.WriteLine();
                }

                // After all rows and columns have been written then close the file.
                writer.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);
                int y = 0;
                // Create a couple variables to calculate the width and height
                // of the data in the file.
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored.

                    if (row[0] == '!')
                        continue;
                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    else
                        maxHeight++;
                    // Get the length of the current row string
                    // and adjust the maxWidth variable if necessary.
                    maxWidth = row.Length;
                }

                // Resize the current universe and scratchPad
                // to the width and height of the file calculated above.
                universe = new bool[maxWidth, maxHeight];

                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                // Iterate through the file again, this time reading in the cells.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then
                    // it is a comment and should be ignored.
                    if (row[0] == '!')
                        continue;

                    // If the row is not a comment then 
                    // it is a row of cells and needs to be iterated through.
                    for (int xPos = 0; xPos < row.Length; xPos++)
                    {
                        // If row[xPos] is a 'O' (capital O) then
                        // set the corresponding cell in the universe to alive.
                        if (row[xPos] == 'O')
                            universe[xPos, y] = true;
                        // If row[xPos] is a '.' (period) then
                        // set the corresponding cell in the universe to dead.
                        else if (row[xPos] == '.')
                            universe[xPos, y] = false;
                    }
                    y++;
                }

                // Close the file.
                reader.Close();
            }

            graphicsPanel1.Invalidate();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            seed = random.Next();
            random = new Random(seed);

            toolStripTextBox1_currentSeed.Text = seed.ToString();

            for (int y = 0; y < universe.GetLength(1); ++y)
            {
                for (int x = 0; x < universe.GetLength(0); ++x)
                {
                    int randSeed = random.Next() % 3;

                    if (randSeed == 1)
                        universe[x, y] = true;
                    else
                        universe[x, y] = false;
                }
            }

            generations = 0;
            graphicsPanel1.Invalidate();
        }

        private void currentSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seed = Int32.Parse(toolStripTextBox1_currentSeed.Text);
            Random random = new Random(seed);

            for (int y = 0; y < universe.GetLength(1); ++y)
            {
                for (int x = 0; x < universe.GetLength(0); ++x)
                {
                    if (random.Next() % 3 == 1)
                        universe[x, y] = true;
                    else
                        universe[x, y] = false;
                }
            }

            generations = 0;
            graphicsPanel1.Invalidate();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            seed = Int32.Parse(toolStripTextBox1_currentSeed.Text);
            Random random = new Random(seed);

            //toolStripTextBox1_currentSeed.Text = seed.ToString();

            for (int y = 0; y < universe.GetLength(1); ++y)
            {
                for (int x = 0; x < universe.GetLength(0); ++x)
                {
                    if (random.Next() % 3 == 1)
                        universe[x, y] = true;
                    else
                        universe[x, y] = false;
                }
            }

            generations = 0;
            graphicsPanel1.Invalidate();
        }

        private void newSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 NewSeed = new Form2();

            DialogResult result = NewSeed.ShowDialog();
            if (result == DialogResult.OK)
            {
                Random random = new Random(Int32.Parse(NewSeed.GetNewSeed));
                seed = Int32.Parse(NewSeed.GetNewSeed);
                for (int y = 0; y < universe.GetLength(1); ++y)
                {
                    for (int x = 0; x < universe.GetLength(0); ++x)
                    {
                        if (random.Next() % 3 == 1)
                            universe[x, y] = true;
                        else
                            universe[x, y] = false;
                    }
                }
                toolStripTextBox1_currentSeed.Text = NewSeed.GetNewSeed;
                generations = 0;
                graphicsPanel1.Invalidate();
            }
        }
    }
}