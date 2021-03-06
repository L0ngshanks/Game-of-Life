﻿using System;
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

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

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

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private int NeighborCount(int x, int y)
        {
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
            bool[,] storage = new bool[20, 20];

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

                    e.Graphics.DrawString(printNeighbors.ToString(), font, Brushes.Black, cellRect, stringFormat);


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
    }
}