using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Final_Project_Rams_Solitaire
{
    public partial class Form1 : Form
    {
        bool cardUp;
        int suit;
        string suitWord;
        int cardValue;

        int moveCount;
        int playTimeSec;
        int playTimeMin;

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
            gameTimer.Start();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            lineOne.Add("KingH");
            lineOne.Add("QueenC");
            lineTwo.Add("KingS");
            lineThree.Add("KingD");

            textBox1.Text = lineOne[0] + Environment.NewLine;
            textBox1.Text += lineOne[1];
            textBox2.Text = lineTwo[0];
            textBox3.Text = lineThree[0];

            cardUp = true;
            suit = 2;
            MoveCard(suit);
        }

        public void MoveCard(int suit)
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

            Thread.Sleep(1000);
            Refresh();

            if(lineTwo[0] == "KingH" || lineTwo[0] == "KingD")
            {
                textBox1.Text = lineOne[0];
                textBox2.Text = lineTwo[0] + Environment.NewLine;
                textBox2.Text += lineOne[1];
                lineTwo.Add(lineOne[1]);
                lineOne.Remove(lineOne[1]);
            }

            Thread.Sleep(1000);
            Refresh();

            if (lineThree[0] == "KingH" || lineThree[0] == "KingD")
            {
                textBox1.Text = lineOne[0];
                textBox3.Text = lineThree[0] + Environment.NewLine;
                textBox3.Text += lineOne[1];
                lineThree.Add(lineOne[1]);
                lineOne.Remove(lineOne[1]);
            }
            else
            {
                MessageBox.Show("This card can not move to line three");
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            playTimeSec++;

            if (playTimeSec == 60)
            {
                playTimeMin++;
                playTimeSec = 0;
            }

            secLabel.Text = playTimeSec.ToString(":00");
            minLabel.Text = playTimeMin + "";
        }
    }
}
