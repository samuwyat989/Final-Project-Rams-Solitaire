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
        string chosenCard, toCard;

        int suit;
        int suitNeed;

        int cardValue;
        int needValue;

        int colour;

        string suitWord;
        string valWord;


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

            lineOne.Add("KingH");
            lineOne.Add("QueenC");
            lineTwo.Add("KingS");
            lineThree.Add("KingD");
            //lineOne.Insert(0, "KingH");           //adds to top of list

            listBox1.Items.Add(lineOne[0] + Environment.NewLine); // makes new line in a list box
            listBox1.Items.Add(lineOne[1]);
            listBox2.Items.Add(lineTwo[0]);
            listBox3.Items.Add(lineThree[0]);
        }

        public void MoveCard(int suit, int cardValue, int suitNeed, int needValue)
        {
            if (cardUp)
            {
                switch (suit)
                {
                    case 1:
                        suitWord = "Hearts";
                        colour = 1;

                        break;
                    case 2:
                        suitWord = "Clubs";
                        colour = 2;

                        break;
                    case 3:
                        suitWord = "Diamonds";
                        colour = 1;

                        break;
                    case 4:
                        suitWord = "Spades";
                        colour = 2;

                        break;
                }

                switch (cardValue)
                {
                    case 1:
                        valWord = "Ace";
                        break;
                    case 2:
                        valWord = "Two";
                        break;
                    case 3:
                        valWord = "Three";
                        break;
                    case 4:
                        valWord = "Four";
                        break;
                    case 5:
                        valWord = "Five";
                        break;
                    case 6:
                        valWord = "Six";
                        break;
                    case 7:
                        valWord = "Seven";
                        break;
                    case 8:
                        valWord = "Eight";
                        break;
                    case 9:
                        valWord = "Nine";
                        break;
                    case 10:
                        valWord = "Ten";
                        break;
                    case 11:
                        valWord = "Jack";
                        break;
                    case 12:
                        valWord = "Queen";
                        break;
                    case 13:
                        valWord = "King";
                        break;
                }
                MessageBox.Show(chosenCard + " is the suit: " + suitWord + "\nAnd card type: " + valWord);
            }
            else
            {
                MessageBox.Show("This card can not be acessed currently");
            }

            if(suit<=2 && )

            if (lineTwo.Last() == "KingH" || lineTwo.Last() == "KingD")
            {
                lineTwo.Add(lineOne[1]);
                lineOne.Remove(lineOne[1]);
                listBox3.Items.Add(lineTwo[1] + Environment.NewLine);
                listBox1.Items.Remove(lineTwo[1]);
            }

            if (lineThree.Last() == "KingH" || lineThree.Last() == "KingD")
            {
                lineThree.Add(lineOne[1]);
                lineOne.Remove(lineOne[1]);
                listBox3.Items.Add(lineThree[1] + Environment.NewLine);
                listBox1.Items.Remove(lineThree[1]);
            }
            else
            {
                MessageBox.Show("This card can not move");
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

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Click Methods for all Playing Lines
        private void listBox1_Click(object sender, EventArgs e)
        {
            cardUp = true;
            chosenCard = listBox1.SelectedItem.ToString();

            #region Find Card Values 
            if (chosenCard.StartsWith("K"))
            {
                cardValue = 13;
            }

            else if (chosenCard.StartsWith("Q"))
            {
                cardValue = 12;
            }

            else if (chosenCard.StartsWith("J"))
            {
                cardValue = 11;
            }

            else if (chosenCard.StartsWith("Te"))
            {
                cardValue = 10;
            }

            else if (chosenCard.StartsWith("N"))
            {
                cardValue = 9;
            }

            else if (chosenCard.StartsWith("E"))
            {
                cardValue = 8;
            }

            else if (chosenCard.StartsWith("Se"))
            {
                cardValue = 7;
            }

            else if (chosenCard.StartsWith("Si"))
            {
                cardValue = 6;
            }

            else if (chosenCard.StartsWith("Fi"))
            {
                cardValue = 5;
            }

            else if (chosenCard.StartsWith("Fo"))
            {
                cardValue = 4;
            }

            else if (chosenCard.StartsWith("Th"))
            {
                cardValue = 3;
            }

            else if (chosenCard.StartsWith("TW"))
            {
                cardValue = 2;
            }

            else if (chosenCard.StartsWith("A"))
            {
                cardValue = 1;
            }
            #endregion

            #region Find Suit Values
            if (chosenCard.EndsWith("H"))
            {
                suit = 1;
            }
            else if (chosenCard.EndsWith("D"))
            {
                suit = 2;
            }
            else if (chosenCard.EndsWith("C"))
            {
                suit = 3;
            }
            else if (chosenCard.EndsWith("S"))
            {
                suit = 4;
            }
            #endregion

            #region Find Last Line 2 Suit Values
            if (lineTwo.Last().EndsWith("H"))
            {
                suitNeed = 1;
            }
            if (lineTwo.Last().EndsWith("C"))
            {
                suitNeed = 2;
            }
            if (lineTwo.Last().EndsWith("D"))
            {
                suitNeed = 3;
            }
            if (lineTwo.Last().EndsWith("S"))
            {
                suitNeed = 4;
            }
            #endregion

            #region Find Last Line 2 Card Values
            if (lineTwo.Last().StartsWith("K"))
            {
                needValue = 13;
            }

            else if (lineTwo.Last().StartsWith("Q"))
            {
                needValue = 12;
            }

            else if (lineTwo.Last().StartsWith("J"))
            {
                needValue = 11;
            }

            else if (lineTwo.Last().StartsWith("Te"))
            {
                needValue = 10;
            }

            else if (lineTwo.Last().StartsWith("N"))
            {
                needValue = 9;
            }

            else if (lineTwo.Last().StartsWith("E"))
            {
                needValue = 8;
            }

            else if (lineTwo.Last().StartsWith("Se"))
            {
                needValue = 7;
            }

            else if (lineTwo.Last().StartsWith("Si"))
            {
                needValue = 6;
            }

            else if (lineTwo.Last().StartsWith("Fi"))
            {
                needValue = 5;
            }

            else if (lineTwo.Last().StartsWith("Fo"))
            {
                needValue = 4;
            }

            else if (lineTwo.Last().StartsWith("Th"))
            {
                needValue = 3;
            }

            else if (lineTwo.Last().StartsWith("TW"))
            {
                needValue = 2;
            }

            else if (lineTwo.Last().StartsWith("A"))
            {
                needValue = 1;
            }
            #endregion

            MoveCard(suit, cardValue, suitNeed, needValue);
        }
        #endregion
        /*
                private void listBox2_Click(object sender, EventArgs e)
                {
                    cardUp = true;
                    chosenCard = listBox2.SelectedItem.ToString();

                    #region Find Card Values 
                    if (chosenCard.StartsWith("K"))
                    {
                        cardValue = 13;
                    }

                    else if (chosenCard.StartsWith("Q"))
                    {
                        cardValue = 12;
                    }

                    else if (chosenCard.StartsWith("J"))
                    {
                        cardValue = 11;
                    }

                    else if (chosenCard.StartsWith("Te"))
                    {
                        cardValue = 10;
                    }

                    else if (chosenCard.StartsWith("N"))
                    {
                        cardValue = 9;
                    }

                    else if (chosenCard.StartsWith("E"))
                    {
                        cardValue = 8;
                    }

                    else if (chosenCard.StartsWith("Se"))
                    {
                        cardValue = 7;
                    }

                    else if (chosenCard.StartsWith("Si"))
                    {
                        cardValue = 6;
                    }

                    else if (chosenCard.StartsWith("Fi"))
                    {
                        cardValue = 5;
                    }

                    else if (chosenCard.StartsWith("Fo"))
                    {
                        cardValue = 4;
                    }

                    else if (chosenCard.StartsWith("Th"))
                    {
                        cardValue = 3;
                    }

                    else if (chosenCard.StartsWith("TW"))
                    {
                        cardValue = 2;
                    }

                    else if (chosenCard.StartsWith("A"))
                    {
                        cardValue = 1;
                    }
                    #endregion

                    #region Find Suit Values
                    if (chosenCard.EndsWith("H"))
                    {
                        suit = 1;
                    }
                    else if (chosenCard.EndsWith("C"))
                    {
                        suit = 2;
                    }
                    else if (chosenCard.EndsWith("D"))
                    {
                        suit = 3;
                    }
                    else if (chosenCard.EndsWith("S"))
                    {
                        suit = 4;
                    }
                    #endregion

                    MoveCard(suit, cardValue);
                }

                private void listBox3_Click(object sender, EventArgs e)
                {
                    cardUp = true;
                    chosenCard = listBox3.SelectedItem.ToString();

                    #region Find Card Values 
                    if (chosenCard.StartsWith("K"))
                    {
                        cardValue = 13;
                    }

                    else if (chosenCard.StartsWith("Q"))
                    {
                        cardValue = 12;
                    }

                    else if (chosenCard.StartsWith("J"))
                    {
                        cardValue = 11;
                    }

                    else if (chosenCard.StartsWith("Te"))
                    {
                        cardValue = 10;
                    }

                    else if (chosenCard.StartsWith("N"))
                    {
                        cardValue = 9;
                    }

                    else if (chosenCard.StartsWith("E"))
                    {
                        cardValue = 8;
                    }

                    else if (chosenCard.StartsWith("Se"))
                    {
                        cardValue = 7;
                    }

                    else if (chosenCard.StartsWith("Si"))
                    {
                        cardValue = 6;
                    }

                    else if (chosenCard.StartsWith("Fi"))
                    {
                        cardValue = 5;
                    }

                    else if (chosenCard.StartsWith("Fo"))
                    {
                        cardValue = 4;
                    }

                    else if (chosenCard.StartsWith("Th"))
                    {
                        cardValue = 3;
                    }

                    else if (chosenCard.StartsWith("TW"))
                    {
                        cardValue = 2;
                    }

                    else if (chosenCard.StartsWith("A"))
                    {
                        cardValue = 1;
                    }
                    #endregion

                    #region Find Suit Values
                    if (chosenCard.EndsWith("H"))
                    {
                        suit = 1;
                    }
                    else if (chosenCard.EndsWith("C"))
                    {
                        suit = 2;
                    }
                    else if (chosenCard.EndsWith("D"))
                    {
                        suit = 3;
                    }
                    else if (chosenCard.EndsWith("S"))
                    {
                        suit = 4;
                    }
                    #endregion

                    MoveCard(suit, cardValue);
                }

                private void listBox4_Click(object sender, EventArgs e)
                {
                    cardUp = true;
                    chosenCard = listBox4.SelectedItem.ToString();

                    #region Find Card Values 
                    if (chosenCard.StartsWith("K"))
                    {
                        cardValue = 13;
                    }

                    else if (chosenCard.StartsWith("Q"))
                    {
                        cardValue = 12;
                    }

                    else if (chosenCard.StartsWith("J"))
                    {
                        cardValue = 11;
                    }

                    else if (chosenCard.StartsWith("Te"))
                    {
                        cardValue = 10;
                    }

                    else if (chosenCard.StartsWith("N"))
                    {
                        cardValue = 9;
                    }

                    else if (chosenCard.StartsWith("E"))
                    {
                        cardValue = 8;
                    }

                    else if (chosenCard.StartsWith("Se"))
                    {
                        cardValue = 7;
                    }

                    else if (chosenCard.StartsWith("Si"))
                    {
                        cardValue = 6;
                    }

                    else if (chosenCard.StartsWith("Fi"))
                    {
                        cardValue = 5;
                    }

                    else if (chosenCard.StartsWith("Fo"))
                    {
                        cardValue = 4;
                    }

                    else if (chosenCard.StartsWith("Th"))
                    {
                        cardValue = 3;
                    }

                    else if (chosenCard.StartsWith("TW"))
                    {
                        cardValue = 2;
                    }

                    else if (chosenCard.StartsWith("A"))
                    {
                        cardValue = 1;
                    }
                    #endregion

                    #region Find Suit Values
                    if (chosenCard.EndsWith("H"))
                    {
                        suit = 1;
                    }
                    else if (chosenCard.EndsWith("C"))
                    {
                        suit = 2;
                    }
                    else if (chosenCard.EndsWith("D"))
                    {
                        suit = 3;
                    }
                    else if (chosenCard.EndsWith("S"))
                    {
                        suit = 4;
                    }
                    #endregion

                    MoveCard(suit, cardValue);
                }

                private void listBox5_Click(object sender, EventArgs e)
                {
                    cardUp = true;
                    chosenCard = listBox5.SelectedItem.ToString();

                    #region Find Card Values 
                    if (chosenCard.StartsWith("K"))
                    {
                        cardValue = 13;
                    }

                    else if (chosenCard.StartsWith("Q"))
                    {
                        cardValue = 12;
                    }

                    else if (chosenCard.StartsWith("J"))
                    {
                        cardValue = 11;
                    }

                    else if (chosenCard.StartsWith("Te"))
                    {
                        cardValue = 10;
                    }

                    else if (chosenCard.StartsWith("N"))
                    {
                        cardValue = 9;
                    }

                    else if (chosenCard.StartsWith("E"))
                    {
                        cardValue = 8;
                    }

                    else if (chosenCard.StartsWith("Se"))
                    {
                        cardValue = 7;
                    }

                    else if (chosenCard.StartsWith("Si"))
                    {
                        cardValue = 6;
                    }

                    else if (chosenCard.StartsWith("Fi"))
                    {
                        cardValue = 5;
                    }

                    else if (chosenCard.StartsWith("Fo"))
                    {
                        cardValue = 4;
                    }

                    else if (chosenCard.StartsWith("Th"))
                    {
                        cardValue = 3;
                    }

                    else if (chosenCard.StartsWith("TW"))
                    {
                        cardValue = 2;
                    }

                    else if (chosenCard.StartsWith("A"))
                    {
                        cardValue = 1;
                    }
                    #endregion

                    #region Find Suit Values
                    if (chosenCard.EndsWith("H"))
                    {
                        suit = 1;
                    }
                    else if (chosenCard.EndsWith("C"))
                    {
                        suit = 2;
                    }
                    else if (chosenCard.EndsWith("D"))
                    {
                        suit = 3;
                    }
                    else if (chosenCard.EndsWith("S"))
                    {
                        suit = 4;
                    }
                    #endregion

                    MoveCard(suit, cardValue);
                }

                private void listBox6_Click(object sender, EventArgs e)
                {
                    cardUp = true;
                    chosenCard = listBox6.SelectedItem.ToString();

                    #region Find Card Values 
                    if (chosenCard.StartsWith("K"))
                    {
                        cardValue = 13;
                    }

                    else if (chosenCard.StartsWith("Q"))
                    {
                        cardValue = 12;
                    }

                    else if (chosenCard.StartsWith("J"))
                    {
                        cardValue = 11;
                    }

                    else if (chosenCard.StartsWith("Te"))
                    {
                        cardValue = 10;
                    }

                    else if (chosenCard.StartsWith("N"))
                    {
                        cardValue = 9;
                    }

                    else if (chosenCard.StartsWith("E"))
                    {
                        cardValue = 8;
                    }

                    else if (chosenCard.StartsWith("Se"))
                    {
                        cardValue = 7;
                    }

                    else if (chosenCard.StartsWith("Si"))
                    {
                        cardValue = 6;
                    }

                    else if (chosenCard.StartsWith("Fi"))
                    {
                        cardValue = 5;
                    }

                    else if (chosenCard.StartsWith("Fo"))
                    {
                        cardValue = 4;
                    }

                    else if (chosenCard.StartsWith("Th"))
                    {
                        cardValue = 3;
                    }

                    else if (chosenCard.StartsWith("TW"))
                    {
                        cardValue = 2;
                    }

                    else if (chosenCard.StartsWith("A"))
                    {
                        cardValue = 1;
                    }
                    #endregion

                    #region Find Suit Values
                    if (chosenCard.EndsWith("H"))
                    {
                        suit = 1;
                    }
                    else if (chosenCard.EndsWith("C"))
                    {
                        suit = 2;
                    }
                    else if (chosenCard.EndsWith("D"))
                    {
                        suit = 3;
                    }
                    else if (chosenCard.EndsWith("S"))
                    {
                        suit = 4;
                    }
                    #endregion

                    MoveCard(suit, cardValue);
                }

                private void listBox7_Click(object sender, EventArgs e)
                {
                    cardUp = true;
                    chosenCard = listBox7.SelectedItem.ToString();

                    #region Find Card Values 
                    if (chosenCard.StartsWith("K"))
                    {
                        cardValue = 13;
                    }

                    else if (chosenCard.StartsWith("Q"))
                    {
                        cardValue = 12;
                    }

                    else if (chosenCard.StartsWith("J"))
                    {
                        cardValue = 11;
                    }

                    else if (chosenCard.StartsWith("Te"))
                    {
                        cardValue = 10;
                    }

                    else if (chosenCard.StartsWith("N"))
                    {
                        cardValue = 9;
                    }

                    else if (chosenCard.StartsWith("E"))
                    {
                        cardValue = 8;
                    }

                    else if (chosenCard.StartsWith("Se"))
                    {
                        cardValue = 7;
                    }

                    else if (chosenCard.StartsWith("Si"))
                    {
                        cardValue = 6;
                    }

                    else if (chosenCard.StartsWith("Fi"))
                    {
                        cardValue = 5;
                    }

                    else if (chosenCard.StartsWith("Fo"))
                    {
                        cardValue = 4;
                    }

                    else if (chosenCard.StartsWith("Th"))
                    {
                        cardValue = 3;
                    }

                    else if (chosenCard.StartsWith("TW"))
                    {
                        cardValue = 2;
                    }

                    else if (chosenCard.StartsWith("A"))
                    {
                        cardValue = 1;
                    }
                    #endregion

                    #region Find Suit Values
                    if (chosenCard.EndsWith("H"))
                    {
                        suit = 1;
                    }
                    else if (chosenCard.EndsWith("C"))
                    {
                        suit = 2;
                    }
                    else if (chosenCard.EndsWith("D"))
                    {
                        suit = 3;
                    }
                    else if (chosenCard.EndsWith("S"))
                    {
                        suit = 4;
                    }
                    #endregion

                    MoveCard(suit, cardValue);
                }
                #endregion
                */
    }
}

