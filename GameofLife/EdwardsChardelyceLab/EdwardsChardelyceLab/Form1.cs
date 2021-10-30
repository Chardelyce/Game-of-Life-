using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdwardsChardelyceLab
{
    public partial class Form1 : Form
    {
        // The universe array
       
        bool[,] universe = new bool[20, 20];
        //swiching bool on and off
        bool bHUDvisible = false;
        bool[,] grandma = new bool[20, 20];
        // Drawing colors
        Color gridColor = Color.Red;
        Color cellColor = Color.White;
        Color deadColor = Color.Red;
        Seedpopup ross = new Seedpopup();
        Applicationsettings select = new Applicationsettings();


        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;
        int cellsalive = 0;
        public Form1()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }

        // Calculate the next generation of cells

       public bool[,] grandchildren = new bool[20, 20];
        private void NextGeneration()

        {
             

            // Increment generation count
            for (int y = 0; y < universe.GetLength(0); y++)
            {

                for (int x = 0; x < universe.GetLength(1); x++)
                {


                    var grandpa = universe[x, y];
                    // universe = grandchildren;

                    int ancestors = CountNeighbors(x, y);

                    if (grandpa)
                        if ((ancestors < 2 || (ancestors > 3)))
                        {
                            grandchildren[x, y] = false;
                        }
                        else
                        {
                            grandchildren[x, y] = true;
                        }
                    else
                    {
                        if (ancestors == 3)
                        {
                            grandchildren[x, y] = true;
                        }

                    }

                   

                }
            }
            universe = grandchildren;
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            graphicsPanel1.Invalidate();
        }

        private int CountNeighbors(int x, int y)

        {

            int count = 0;


            int xLen = universe.GetLength(0);

            int yLen = universe.GetLength(1);


            for (int yOffset = -1; yOffset < 2; yOffset++)

            {

                for (int xOffset = -1; xOffset < 2; xOffset++)

                {



                    int cellWidth = (x + yOffset + universe.GetLength(0)) % universe.GetLength(0);

                    int cellHeight = (y + xOffset + universe.GetLength(1)) % universe.GetLength(1);

                    if (universe[cellWidth, cellHeight] == true)
                    {
                        count++;
                    }

                }

            }
            if (universe[x, y])
            {
                count--;
            }

            return count;

        }

        #region updating the cells also to be used  with the hud 
        void howmanycellsleft()
        {
            

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {

                    if (universe[x, y] == true)
                    {
                        cellsalive++;
                    }



                }
            }
            toolStripStatusLabel2.Text = "Cells alive = " + cellsalive.ToString();
        }

        #endregion




        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
            howmanycellsleft();


        }

       
        
        public void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            
            
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
           
            
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);
            //i made a brush for dead cells too 
            Brush deadBrush = new SolidBrush(deadColor);

            
            Font font = new Font("TimesNewRoman", 12f);
           

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;
                    Rectangle huddy = graphicsPanel1.ClientRectangle;
                    Font thefonze = new Font(" TimesNewRoman", 15f);

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }
                    else if (universe[x, y] == false)
                    {
                        e.Graphics.FillRectangle(deadBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                    e.Graphics.DrawString(CountNeighbors(x, y).ToString(), graphicsPanel1.Font, Brushes.Black, cellRect.Location);

#region hud 
                    if (bHUDvisible)
                    {
                        // DRAW HUD HERE
                         e.Graphics.DrawString(("GENERATIONS  = ") + generations.ToString() + (" Cells alive = ") + cellsalive.ToString() + (" Universe size =") + universe.GetLength(1) + universe.GetLength(0), thefonze, Brushes.PaleTurquoise, huddy);

                    }

#endregion






                }

            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
            deadBrush.Dispose();



        }
        


        // color select 
        #region acessing the stuff in app settings

        private void otherSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Applicationsettings select = new Applicationsettings();
           // int peterpan = 100;

            
            //select.Number = peterpan;
           // select.secondstar = Height;
           // select.neverland = Width;
            if (select. ShowDialog() ==DialogResult.OK)
            {
               // peterpan = select.Number;
                gridColor = select.a;
                deadColor = select.b;
                cellColor = select.c;

               // timer.Interval = select.peterpan;
               // select.peterpan = timer.Interval;
                
                //hook,lostboys
                universe = new bool[select.hook , select.lostboys ];
                grandchildren = new bool[select.hook,select.lostboys];
                grandma = new bool[select.hook, select.lostboys];
                

            }
            graphicsPanel1.Invalidate();

        }

        #endregion
        #region tool strip forms basic buttons

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {

               
                cellsalive++;
                toolStripStatusLabel2.Text = "Cells alive = " + cellsalive.ToString();


                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

                // Calculate the cell that was clicked in
                //CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }



        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Cells (*.txt),(*.cells)|*.txt,*.cells|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;


                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Brush cellBrush = new SolidBrush(cellColor);
            Brush deadBrush = new SolidBrush(deadColor);
            cellBrush.Dispose();
            deadBrush.Dispose();
            graphicsPanel1.Invalidate();
            timer.Enabled = false;
            generations = 0;
            cellsalive = 0;
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    universe[x, y] = false;
                    
                }
            }

            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLabel2.Text = "Cells alive = " + cellsalive.ToString();

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
        //next
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            Stream oofStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Cells (*.txt),(*.cells)|*.txt,*.cells|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((oofStream = saveFileDialog1.OpenFile()) != null)
                {

                    oofStream.Close();
                }
            }


        }

     

       

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region tools for the random and time seed
      
        private void seedButRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random randy = new Random();
            int monstersinc;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    monstersinc = randy.Next(0, 2);
                    if (monstersinc == 0)
                    {
                        universe[x, y] = false;
                    }
                    else
                    {
                        universe[x, y] = true;
                    }
                }





            }

            graphicsPanel1.Invalidate();
        }

       

        private void seedButFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ross.ShowDialog() == DialogResult.OK)
            {
                int waterloo;
                Random randy_ = new Random(ross.userschoice1);
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        universe[x, y] = true;
                        waterloo = randy_.Next(0, 2);

                        if (waterloo == 0)
                        {
                            universe[x, y] = false;
                        }

                    }
                }

                graphicsPanel1.Invalidate();

            }

        }





        #endregion

        private void hudOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle huddy = Rectangle.Empty;
            Font thefonze = new Font(" TimesNewRoman", 15f);
            bHUDvisible = !bHUDvisible;
            graphicsPanel1.Invalidate();


        }
    }
}
