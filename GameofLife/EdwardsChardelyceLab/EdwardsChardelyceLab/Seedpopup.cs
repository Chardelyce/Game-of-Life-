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
    public partial class Seedpopup : Form
    {
       public int userschoice1;
        int userschoice2;
        public int noodles;
        public Seedpopup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random moof = new Random();
            numericUpDown1.Value = moof.Next(1, 999999);
        }
      
       
        public void googlybear()
        {
           
            userschoice1 = noodles;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            userschoice1 = (int)numericUpDown1.Value;
            userschoice1 = userschoice2;
        }
    }
}
