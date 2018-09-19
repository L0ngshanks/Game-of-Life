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
        //Universe Type
        bool finite = true;
        bool toroidal = false;

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
        Color AliveColor = Color.Green;
        Color DeadColor = Color.Red;

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
            AliveColor = Properties.Settings.Default.AliveColor;
            DeadColor = Properties.Settings.Default.DeadColor;
            gridColor = Properties.Settings.Default.GridColor;
            universalX = Properties.Settings.Default.UniverseX;
            universalY = Properties.Settings.Default.UniverseY;
            timerInterval = Properties.Settings.Default.TimerInterval;
            seed = Properties.Settings.Default.CurrentSeed;
            gridVisibleToolStripMenuItem.Checked = Properties.Settings.Default.GridVisible;
            CountVisible = Properties.Settings.Default.NCVisible;
            finite = Properties.Settings.Default.Finite;
            toroidal = Properties.Settings.Default.Toroidal;

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

        public bool CountVisible
        {
            get
            {
                return tsmi_NeighborCountVisible.Checked;
            }
            set
            {
                tsmi_NeighborCountVisible.Checked = value;
            }
        }

        public bool GridVisible
        {
            get
            {
                return gridVisibleToolStripMenuItem.Checked;
            }
            set
            {
                gridVisibleToolStripMenuItem.Checked = value;
            }
        }

        public bool HeadsUpVisible
        {
            get
            {
                return headsUpToolStripMenuItem.Checked;
            }
            set
            {
                headsUpToolStripMenuItem.Checked = value;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private int NeighborCount(int x, int y)
        {
            int count = 0;
            if (finite)
            {
                if (x == 0 && y == 0)
                {
                    for (int k = 0; k <= 1; ++k)
                    {
                        for (int j = 0; j <= 1; ++j)
                        {
                            if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                                count += 1;
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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

                        }
                    }
                }
            }
            else if (toroidal)
            {
                // Toroidal Universe code
                if (x == 0 && y == 0)
                {
                    for (int k = 0; k <= 1; ++k)
                    {
                        for (int j = 0; j <= 1; ++j)
                        {
                            if (universe[x + j, y + k] && !(x + j == x && y + k == y))
                                count += 1;
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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

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
                                count += 1;

                        }
                    }
                }

            }
            return count;
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
            //Pen seperatorGridPen = new Pen(gridColor, 2);

            // A Brush
            Brush cellBrush = new SolidBrush(cellColor);

            //Text Brush
            SolidBrush AliveBrush = new SolidBrush(AliveColor);
            SolidBrush DeadBrush = new SolidBrush(DeadColor);

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

                    // Outline the cell with a pen
                    if (GridVisible)
                    {
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                        //if ((cellRect.X % 10 == 0) && (cellRect.Y % 10 == 0))
                        //    e.Graphics.DrawRectangle(seperatorGridPen, cellRect.X, cellRect.Y, cellRect.Width * 10, cellRect.Height * 10);
                    }

                    // Print Neighbors
                    if (CountVisible)
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
                            if (universe[x, y])
                                e.Graphics.DrawString(printNeighbors.ToString(), font, AliveBrush, cellRect, stringFormat);
                            else
                                e.Graphics.DrawString(printNeighbors.ToString(), font, DeadBrush, cellRect, stringFormat);
                    }
                }
            }

            LivingCellCout();

            if (HeadsUpVisible)
            {
                //HeadsUp Brush
                SolidBrush headsUpBrush = new SolidBrush(Color.DimGray);
                RectangleF headsUp = Rectangle.Empty;
                headsUp.X = 0;
                headsUp.Y = 0;
                headsUp.Width = 250;
                headsUp.Height = 80;

                //Generations Cell
                RectangleF genCell = Rectangle.Empty;
                genCell.X = 0;
                genCell.Y = 0;
                genCell.Width = 250;
                genCell.Height = 20;

                //Alive Cell
                RectangleF aliveCell = Rectangle.Empty;
                aliveCell.X = 0;
                aliveCell.Y = 20;
                aliveCell.Width = 250;
                aliveCell.Height = 20;

                //Boundary Cell
                RectangleF boundaryCell = Rectangle.Empty;
                boundaryCell.X = 0;
                boundaryCell.Y = 40;
                boundaryCell.Width = 250;
                boundaryCell.Height = 20;

                //Universe Dimensions Cell
                RectangleF udCell = Rectangle.Empty;
                udCell.X = 0;
                udCell.Y = 60;
                udCell.Width = 250;
                udCell.Height = 20;

                Font font = new Font("Arial", 14, GraphicsUnit.Pixel);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Near;
                stringFormat.LineAlignment = StringAlignment.Center;

                PointF genPoint = new PointF(1, 1);


                string generation = "Generation: " + generations;
                string aliveCount = "Alive: " + isAlive;
                string boundaryType = "";
                if (finite)
                    boundaryType = "Boundary Type: Finite";
                else if (toroidal)
                    boundaryType = "Boundary Type: Toroidal";
                string universeSize = "{Width = " + universalX + ", Height = " + universalY + "}";

                e.Graphics.DrawString(generation, font, headsUpBrush, genCell, stringFormat);
                e.Graphics.DrawString(aliveCount, font, headsUpBrush, aliveCell, stringFormat);
                e.Graphics.DrawString(boundaryType, font, headsUpBrush, boundaryCell, stringFormat);
                e.Graphics.DrawString(universeSize, font, headsUpBrush, udCell, stringFormat);

            }


            toolStripStatusLabel1isAlive.Text = "Alive = " + isAlive.ToString();
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
            settingsForm.GetAliveColor = AliveColor;
            settingsForm.DeadColor = DeadColor;
            settingsForm.GetUniverseX = universalX;
            settingsForm.GetUniverseY = universalY;
            settingsForm.TimerInterval = timerInterval;
            settingsForm.Finite = finite;
            settingsForm.Toroidal = toroidal;
            settingsForm.GridColor = gridColor;

            DialogResult result = settingsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Program Color's
                CellColor = settingsForm.GetCellColor;
                graphicsPanel1.BackColor = settingsForm.GetBGColor;
                AliveColor = settingsForm.GetAliveColor;
                DeadColor = settingsForm.DeadColor;
                gridColor = settingsForm.GridColor;

                // Universe Dimensions
                universalX = settingsForm.GetUniverseX;
                universalY = settingsForm.GetUniverseY;

                universe = new bool[universalX, universalY];

                //Timer Interval
                timerInterval = settingsForm.TimerInterval;

                //universe Type
                finite = settingsForm.Finite;
                toroidal = settingsForm.Toroidal;

                //Push data to Settings
                Properties.Settings.Default.CellColor = settingsForm.GetCellColor;
                Properties.Settings.Default.BGColor = settingsForm.GetBGColor;
                Properties.Settings.Default.AliveColor = settingsForm.GetAliveColor;
                Properties.Settings.Default.DeadColor = settingsForm.DeadColor;
                Properties.Settings.Default.GridColor = settingsForm.GridColor;
                Properties.Settings.Default.UniverseX = settingsForm.GetUniverseX;
                Properties.Settings.Default.UniverseY = settingsForm.GetUniverseY;
                Properties.Settings.Default.TimerInterval = settingsForm.TimerInterval;
                Properties.Settings.Default.Finite = settingsForm.Finite;
                Properties.Settings.Default.Toroidal = settingsForm.Toroidal;

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

        private void gridVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicsPanel1.Refresh();
        }

        private void tsmi_NeighborCountVisible_Click(object sender, EventArgs e)
        {
            graphicsPanel1.Refresh();
        }

        private void headsUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicsPanel1.Refresh();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            //Settings Load
            CellColor = Properties.Settings.Default.CellColor;
            BGColor = Properties.Settings.Default.BGColor;
            AliveColor = Properties.Settings.Default.AliveColor;
            DeadColor = Properties.Settings.Default.DeadColor;
            gridColor = Properties.Settings.Default.GridColor;
            universalX = Properties.Settings.Default.UniverseX;
            universalY = Properties.Settings.Default.UniverseY;
            timerInterval = Properties.Settings.Default.TimerInterval;
            seed = Properties.Settings.Default.CurrentSeed;
            gridVisibleToolStripMenuItem.Checked = Properties.Settings.Default.GridVisible;
            CountVisible = Properties.Settings.Default.NCVisible;
            finite = Properties.Settings.Default.Finite;
            toroidal = Properties.Settings.Default.Toroidal;

            //Universe Relaod
            universe = new bool[universalX, universalY];

            graphicsPanel1.Refresh();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();

            //Settings Load
            CellColor = Properties.Settings.Default.CellColor;
            BGColor = Properties.Settings.Default.BGColor;
            AliveColor = Properties.Settings.Default.AliveColor;
            DeadColor = Properties.Settings.Default.DeadColor;
            gridColor = Properties.Settings.Default.GridColor;
            universalX = Properties.Settings.Default.UniverseX;
            universalY = Properties.Settings.Default.UniverseY;
            timerInterval = Properties.Settings.Default.TimerInterval;
            seed = Properties.Settings.Default.CurrentSeed;
            gridVisibleToolStripMenuItem.Checked = Properties.Settings.Default.GridVisible;
            CountVisible = Properties.Settings.Default.NCVisible;
            finite = Properties.Settings.Default.Finite;
            toroidal = Properties.Settings.Default.Toroidal;

            //Universe Relaod
            universe = new bool[universalX, universalY];

            graphicsPanel1.Refresh();
        }
    }
}