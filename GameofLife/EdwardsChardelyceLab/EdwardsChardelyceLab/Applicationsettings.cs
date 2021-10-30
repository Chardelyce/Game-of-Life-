using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EdwardsChardelyceLab
{
    public partial class Applicationsettings : Form
    {

        public int peterpan = 100;
        public int f, g;//tinks frieds
        public int tinkerbell;//big menu stuff
        public int hook,lostboys;//form1 helpers
        bool[,] universe = new bool[20, 20];
        public Applicationsettings()
        {
            InitializeComponent();
        }
       



        private void Apply_Click(object sender, EventArgs e)
        {
            tinkerbell = (int)timerthing.Value;
            hook = (int)Width.Value;
            lostboys = (int)height.Value;
        }

        
      
      
      
       

        private void Width_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void height_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timerthing_ValueChanged(object sender, EventArgs e)
        {

        }
        public int neverland
        {
            get
            {
                return (int)hook;
            }
            set
            {
                Width.Value = 100;
            }
        }
        public int secondstar
        {
            get
            {
                return (int)hook;
            }
            set
            {
                height.Value = 100;
            }
        }

        public int Number
        {
            get
            {
                return (int)timerthing.Value;
            }
            set
            {
                timerthing.Value = value;
            }
        }
        #region the color part / and the finite 

        public Color a, b, c;

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                tinkerbell = (int)timerthing.Value;
                hook = (int)Width.Value;
                lostboys = (int)height.Value;

            

            int Countneighsfinite(int x, int y)
            {
                int count = 0;
                int xlen = universe.GetLength(0);
                int ylen = universe.GetLength(1);

                for (int yOffset = -1; yOffset <= 1; yOffset++)
                {
                    for (int xOffset = -1; xOffset <= 1; xOffset++)
                    {
                        int xCheck = x + xOffset;

                        int yCheck = y + yOffset;

                        if (xOffset == 0)
                        {
                            continue;
                        }
                        if (yOffset == 0)
                        {
                            continue;
                        }
                        if (xCheck < 0)
                        {
                            continue;
                        }
                        if (yCheck < 0)
                        {
                            continue;
                        }
                        if (xCheck >= xlen)
                        {
                            continue;
                        }
                        if (yCheck >= ylen)
                        {
                            continue;
                        }
                        if (universe[xCheck, yCheck] == true) count++;
                    }
                }
                return count;
            }
        }


       
        private void cellclr_Click(object sender, EventArgs e)
        {
            ColorDialog ribbit = new ColorDialog();
            if (DialogResult.OK == ribbit.ShowDialog())
            {
                c = ribbit.Color;
            }
        }

        private void grd_Click(object sender, EventArgs e)
        {
            ColorDialog ribbit = new ColorDialog();
            if (DialogResult.OK == ribbit.ShowDialog())
            {
                b = ribbit.Color;
            }
        }

        private void bckgrnd_Click(object sender, EventArgs e)
        {
            ColorDialog ribbit = new ColorDialog();
            if ( DialogResult.OK == ribbit.ShowDialog())
            {
                a = ribbit.Color;
            }
        }
        #endregion

        





        
       

        








    }
}
