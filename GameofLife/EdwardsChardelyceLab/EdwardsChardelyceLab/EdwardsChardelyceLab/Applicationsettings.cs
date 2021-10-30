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
        public int peterpan;//for the select
        public int f, g;//tinks frieds
        public int tinkerbell;//big menu stuff
        public int hook,lostboys;//form1 helpers

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

        
        #region the color part 

        public Color a, b, c;
        int number = 100;
        
        #region timer 
        private void timerthing_ValueChanged(object sender, EventArgs e)
        {
            Applicationsettings hotdog = new Applicationsettings();
            hotdog.value = number;
            if (DialogResult.OK == hotdog.ShowDialog())
            {
                number = hotdog.value;
                
            }
        }

        private void Width_ValueChanged(object sender, EventArgs e)
        {
            value = 2;
        }

        private void height_ValueChanged(object sender, EventArgs e)
        {
            value = 2;
        }

        public int value
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
        #endregion
       
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

        //toroidals  or else 





        //hud 

       

        








    }
}
