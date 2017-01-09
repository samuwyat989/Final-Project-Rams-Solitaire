using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Rams_Solitaire
{
    public partial class Form1 : Form
    {
        List<string> lineOne = new List<string>();
        List<string> lineTwo = new List<string>();
        List<string> lineThree = new List<string>();
        List<string> lineFour = new List<string>();
        List<string> lineFive = new List<string>();

        public Form1()
        {
            InitializeComponent();
            lineOne.Add("KingH");
            lineOne.Add("QueenC");

            lineTwo.Add("KingC");
            lineThree.Add("KingS");
            lineFour.Add("KingD");
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            line1.Text = lineOne[];
        }
    }
}
