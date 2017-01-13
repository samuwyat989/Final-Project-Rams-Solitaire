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

        Random cardDeal = new Random();

        List<string> startPile = new List<string>();

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

        private void loadButton_Click(object sender, EventArgs e)
        {
            startPile.Add("HA");
            startPile.Add("DA");
            startPile.Add("SA");
            startPile.Add("CA");
            startPile.Add("H2");
            startPile.Add("D2");
            startPile.Add("S2");
            startPile.Add("C2");
            startPile.Add("H3");
            startPile.Add("D3");
            startPile.Add("S3");
            startPile.Add("C3");
            startPile.Add("H4");
            startPile.Add("D4");
            startPile.Add("S4");
            startPile.Add("C4");
            startPile.Add("H5");
            startPile.Add("D5");
            startPile.Add("S5");
            startPile.Add("C5");
            startPile.Add("H6");
            startPile.Add("D6");
            startPile.Add("S6");
            startPile.Add("C6");
            startPile.Add("H7");
            startPile.Add("D7");
            startPile.Add("S7");
            startPile.Add("C7");
            startPile.Add("H8");
            startPile.Add("D8");
            startPile.Add("S8");
            startPile.Add("C8");
            startPile.Add("H9");
            startPile.Add("D9");
            startPile.Add("S9");
            startPile.Add("C9");
            startPile.Add("H10");
            startPile.Add("D10");
            startPile.Add("S10");
            startPile.Add("C10");
            startPile.Add("HJ");
            startPile.Add("DJ");
            startPile.Add("SJ");
            startPile.Add("CJ");
            startPile.Add("HQ");
            startPile.Add("DQ");
            startPile.Add("SQ");
            startPile.Add("CQ");
            startPile.Add("HK");
            startPile.Add("DK");
            startPile.Add("SK");
            startPile.Add("CK");

            #region random 5 cards
            const int CARDS = 52;
            int[] card = new int[CARDS];
            int i, deck_cards;

            for (i=0; i < CARDS; i++)
            
                card[i] = i;
                deck_cards = CARDS;
            
            for (i = 0; i <= 5; i++)
            {
                int r = cardDeal.Next(0, deck_cards+1);

                int temp = card[r];
                card[r] = card[deck_cards - 1];
                card[deck_cards - 1] = temp;

                deck_cards--;
            }

            for (i = 0; i <= 5; i++)
            {
                OnPaint("extracted card[%d]=%d\n", i, card[deck_cards + i]);
                //printf("extracted card[%d]=%d\n", i, card[deck_cards + i]);
            }

            for (i = 0; i < 5; i++)
            {
                // r is the newly extracted card index
                int r = cardDeal.Next(CARDS - i);
                // swap card[r] with card[CARDS-1-i]
                int temp = card[r];
                card[r] = card[CARDS - 1 - i];
                card[CARDS - 1 - i] = temp;
            }
            #endregion

            lineOne.Add("KingH");
            lineOne.Add("QueenC");
            lineTwo.Add("KingS");
            lineThree.Add("KingD");

            listBox1.Items.Add(lineOne[0] + Environment.NewLine);
            listBox1.Items.Add(lineOne[1]);
            listBox2.Items.Add(lineTwo[0]);
            listBox3.Items.Add(lineThree[0]);
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
                lineTwo.Add(lineOne[1]);
                lineOne.Remove(lineOne[1]);
                listBox3.Items.Add(lineTwo[1] + Environment.NewLine);
                listBox1.Items.Remove(lineTwo[1]);               
            }

            Thread.Sleep(1000);
            Refresh();

            if (lineThree[0] == "KingH" || lineThree[0] == "KingD")
            {
                lineThree.Add(lineOne[1]);
                lineOne.Remove(lineOne[1]);
                listBox3.Items.Add(lineThree[1] + Environment.NewLine);
                listBox1.Items.Remove(lineThree[1]);
                
                //textBox3.Location = Point point{ 400,200];
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

        private void listBox1_Click(object sender, EventArgs e)
        {
            cardUp = true;
            suit = 2;
            MoveCard(suit);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
