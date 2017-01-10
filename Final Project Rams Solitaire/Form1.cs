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
        bool cardUp;
        int suit;
        string suitWord;
        int cardValue;

        int moveCount;
        int playTime;

        List<string> drawPile = new List<string>();
        List<string> playPile = new List<string>();

        List<string> goalPileH = new List<string>();
        List<string> goalPileC = new List<string>();
        List<string> goalPileD = new List<string>();
        List<string> goalPileS = new List<string>();

        List<string> lineOne = new List<string>();
        List<string> lineTwo = new List<string>();
        List<string> lineThree = new List<string>();
        List<string> lineFour = new List<string>();
        List<string> lineFive = new List<string>();
        List<string> lineSix = new List<string>();
        List<string> lineSeven = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            lineOne.Add("KingH");
            lineOne.Add("QueenC");
            lineTwo.Add("KingS");
            lineThree.Add("KingD");
            cardUp = true;
            suit = 2;
            MoveCard(suit); 
        }

        public void MoveCard(int cardType)
        {
            if (cardUp)
            {
                switch (suit)
                {
                    case 1:
                        suitWord = "Hearts";
                        break;
                    case 2:
                        suitWord = "Clubs";
                        break;
                    case 3:
                        suitWord = "Diamonds";
                        break;
                    case 4:
                        suitWord = "Spades";
                        break;

                }
                MessageBox.Show(lineOne[1] + " is the suit " + suitWord);
            }
          else
            {
                MessageBox.Show("Sorry that card can not be acessed currently");
            }

            if(lineTwo[0] == "KingH" || lineTwo[0] == "KingD")
            {
                MessageBox.Show("This card can move");
            } 
        }
    }
}
