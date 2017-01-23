﻿using System;
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
        string chosenCard;

        int moveLine;
        int currentLine;

        int suit;
        int suitNeed;

        int cardValue;
        int needValue;

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
            drawCardButton.Enabled = false;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            #region Add start cards
            startPile.Add("AceH");
            startPile.Add("AceD");
            startPile.Add("AceS");
            startPile.Add("AceC");
            startPile.Add("TwoH");
            startPile.Add("TwoD");
            startPile.Add("TwoS");
            startPile.Add("TwoC");
            startPile.Add("ThreeH");
            startPile.Add("ThreeD");
            startPile.Add("ThreeS");
            startPile.Add("ThreeC");
            startPile.Add("FourH");
            startPile.Add("FourD");
            startPile.Add("FourS");
            startPile.Add("FourC");
            startPile.Add("FiveH");
            startPile.Add("FiveD");
            startPile.Add("FiveS");
            startPile.Add("FiveC");
            startPile.Add("SixH");
            startPile.Add("SixD");
            startPile.Add("SixS");
            startPile.Add("SixC");
            startPile.Add("SevenH");
            startPile.Add("SevenD");
            startPile.Add("SevenS");
            startPile.Add("SevenC");
            startPile.Add("EightH");
            startPile.Add("EightD");
            startPile.Add("EightS");
            startPile.Add("EightC");
            startPile.Add("NineH");
            startPile.Add("NineD");
            startPile.Add("NineS");
            startPile.Add("NineC");
            startPile.Add("TenH");
            startPile.Add("TenD");
            startPile.Add("TenS");
            startPile.Add("TenC");
            startPile.Add("JackH");
            startPile.Add("JackD");
            startPile.Add("JackS");
            startPile.Add("JackC");
            startPile.Add("QueenH");
            startPile.Add("QueenD");
            startPile.Add("QueenS");
            startPile.Add("QueenC");
            startPile.Add("KingH");
            startPile.Add("KingD");
            startPile.Add("KingS");
            startPile.Add("KingC");
            #endregion

            #region Deal Random Cards
            int r = cardDeal.Next(startPile.Count);

            lineOne.Add((string)startPile[r]);
            lineBox1.Items.Add((string)startPile[r]);
            startPile.Remove((string)startPile[r]);

            for (int i = 0; i < 2; i++)
            {
                r = cardDeal.Next(startPile.Count);
                lineTwo.Add((string)startPile[r]);
                lineBox2.Items.Add((string)startPile[r]);
                startPile.Remove((string)startPile[r]);
            }
            
            for (int i = 0; i<3; i++)
            {
                r = cardDeal.Next(startPile.Count);
                lineThree.Add((string)startPile[r]);
                lineBox3.Items.Add((string)startPile[r]);
                startPile.Remove((string)startPile[r]);
            }
            

            for (int i = 0; i < 4; i++)
            {
                r = cardDeal.Next(startPile.Count);
                lineFour.Add((string)startPile[r]);
                lineBox4.Items.Add((string)startPile[r]);
                startPile.Remove((string)startPile[r]);
            }
            

            for (int i = 0; i < 5; i++)
            {
                r = cardDeal.Next(startPile.Count);
                lineFive.Add((string)startPile[r]);
                lineBox5.Items.Add((string)startPile[r]);
                startPile.Remove((string)startPile[r]);
            }
            
            for (int i = 0; i < 6; i++)
            {
                r = cardDeal.Next(startPile.Count);
                lineSix.Add((string)startPile[r]);
                lineBox6.Items.Add((string)startPile[r]);
                startPile.Remove((string)startPile[r]);
            }
            

            for (int i = 0; i < 7; i++)
            {
                r = cardDeal.Next(startPile.Count);
                lineSeven.Add((string)startPile[r]);
                lineBox7.Items.Add((string)startPile[r]);
                startPile.Remove((string)startPile[r]);
            }  
            for (int i = 0; i <24; i++)
            {
                r = cardDeal.Next(startPile.Count);
                drawPile.Add((string)startPile[r]);
                startPile.Remove((string)startPile[r]);
            }        
            #endregion

            //drawPile.AddRange(startPile);
            //goalPileC.Add("T");
            //goalPileH.Add("T");
            //goalPileD.Add("T");
            //goalPileS.Add("T");
            drawCardButton.Enabled = true;
            loadButton.Enabled = false;
        }

        public void MoveCard(int suit, int cardValue, int suitNeed, int needValue, int moveLine, int currentLine)
        {
            if (cardUp)
            {

                //MessageBox.Show("Card Info: " + suit + " " + cardValue + " " + suitNeed + " " + needValue);

                #region Move card in list and on screen
                if (moveLine == 1 && moveLine != currentLine)
                {
                    lineOne.Add(chosenCard);
                    lineBox1.Items.Add(chosenCard);
                }
                else if (moveLine == 2 && moveLine != currentLine)
                {
                    lineTwo.Add(chosenCard);
                    lineBox2.Items.Add(chosenCard);
                }
                else if (moveLine == 3 && moveLine != currentLine)
                {
                    lineThree.Add(chosenCard);
                    lineBox3.Items.Add(chosenCard);
                }
                else if (moveLine == 4 && moveLine != currentLine)
                {
                    lineFour.Add(chosenCard);
                    lineBox4.Items.Add(chosenCard);
                }
                else if (moveLine == 5 && moveLine != currentLine)
                {
                    lineFive.Add(chosenCard);
                    lineBox5.Items.Add(chosenCard);
                }
                else if (moveLine == 6 && moveLine != currentLine)
                {
                    lineSix.Add(chosenCard);
                    lineBox6.Items.Add(chosenCard);
                }
                else if (moveLine == 7 && moveLine != currentLine)
                {
                    lineSeven.Add(chosenCard);
                    lineBox7.Items.Add(chosenCard);
                }
                else if (moveLine == 10 && moveLine != currentLine)
                {
                    goalPileH.Add(chosenCard);
                    heartsBox.Items.Add(chosenCard);
                }
                #endregion

                #region Remove card in list and on screen
                if(currentLine == 0)
                {
                    playPile.Remove(chosenCard);
                    playCardBox.Items.Remove(chosenCard);
                }
                if (currentLine == 1 && currentLine != moveLine)
                {
                    lineOne.Remove(chosenCard);
                    lineBox1.Items.Remove(chosenCard);
                }
                else if (currentLine == 2 && currentLine != moveLine)
                {
                    lineTwo.Remove(chosenCard);
                    lineBox2.Items.Remove(chosenCard);
                }
                else if (currentLine == 3 && currentLine != moveLine)
                {
                    lineThree.Remove(chosenCard);
                    lineBox3.Items.Remove(chosenCard);
                }
                else if (currentLine == 4 && currentLine != moveLine)
                {
                    lineFour.Remove(chosenCard);
                    lineBox4.Items.Remove(chosenCard);
                }
                else if (currentLine == 5 && currentLine != moveLine)
                {
                    lineFive.Remove(chosenCard);
                    lineBox5.Items.Remove(chosenCard);
                }
                else if (currentLine == 6 && currentLine != moveLine)
                {
                    lineSix.Remove(chosenCard);
                    lineBox6.Items.Remove(chosenCard);
                }
                else if (currentLine == 7 && currentLine != moveLine)
                {
                    lineSeven.Remove(chosenCard);
                    lineBox7.Items.Remove(chosenCard);
                }
                #endregion
                //if (heartsBox.SelectedIndex != -1 && clubsBox.SelectedIndex != -1 && diamondsBox.SelectedIndex != -1 && spadesBox.SelectedIndex != -1)
                //{
                //    if (goalPileC.Last().StartsWith("K") && goalPileH.Last().StartsWith("K") && goalPileS.Last().StartsWith("K") && goalPileD.Last().StartsWith("K"))
                //    {
                //        WinScreen();
                //    }
                //}
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

        public void CheckLines(int suit, int cardValue, int currentLine)
        {
            try
            {
                #region Find Last Line 1 Suit Values
                if (lineOne.Last().EndsWith("H"))
                {
                    suitNeed = 1;
                }
                else if (lineOne.Last().EndsWith("D"))
                {
                    suitNeed = 2;
                }
                else if (lineOne.Last().EndsWith("C"))
                {
                    suitNeed = 3;
                }
                else if (lineOne.Last().EndsWith("S"))
                {
                    suitNeed = 4;
                }
                #endregion
                #region Find Last Line 1 Card Values
                if (lineOne.Last().StartsWith("K"))
                {
                    needValue = 13;
                }

                else if (lineOne.Last().StartsWith("Q"))
                {
                    needValue = 12;
                }

                else if (lineOne.Last().StartsWith("J"))
                {
                    needValue = 11;
                }

                else if (lineOne.Last().StartsWith("Te"))
                {
                    needValue = 10;
                }

                else if (lineOne.Last().StartsWith("N"))
                {
                    needValue = 9;
                }

                else if (lineOne.Last().StartsWith("E"))
                {
                    needValue = 8;
                }

                else if (lineOne.Last().StartsWith("Se"))
                {
                    needValue = 7;
                }

                else if (lineOne.Last().StartsWith("Si"))
                {
                    needValue = 6;
                }

                else if (lineOne.Last().StartsWith("Fi"))
                {
                    needValue = 5;
                }

                else if (lineOne.Last().StartsWith("Fo"))
                {
                    needValue = 4;
                }

                else if (lineOne.Last().StartsWith("Th"))
                {
                    needValue = 3;
                }

                else if (lineOne.Last().StartsWith("Tw"))
                {
                    needValue = 2;
                }

                else if (lineOne.Last().StartsWith("A"))
                {
                    needValue = 1;
                }
                #endregion
                moveLine = 1;
            }
            catch
            {
                suitNeed = 0;
                needValue = 0;
            }
            if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue || suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue)
            {
                MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
            }
            else
            {
                try
                {
                    #region Find Last Line 2 Suit Values
                    if (lineTwo.Last().EndsWith("H"))
                    {
                        suitNeed = 1;
                    }
                    else if (lineTwo.Last().EndsWith("D"))
                    {
                        suitNeed = 2;
                    }
                    else if (lineTwo.Last().EndsWith("C"))
                    {
                        suitNeed = 3;
                    }
                    else if (lineTwo.Last().EndsWith("S"))
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

                    else if (lineTwo.Last().StartsWith("Tw"))
                    {
                        needValue = 2;
                    }

                    else if (lineTwo.Last().StartsWith("A"))
                    {
                        needValue = 1;
                    }
                    #endregion
                    moveLine = 2;
                }
                catch
                {
                    suitNeed = 0;
                    needValue = 0;
                }
                if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue || suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue)
                {
                    MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
                }
                else
                {
                    try
                    {
                        #region Find Last Line 3 Suit Values
                        if (lineThree.Last().EndsWith("H"))
                        {
                            suitNeed = 1;
                        }
                        else if (lineThree.Last().EndsWith("D"))
                        {
                            suitNeed = 2;
                        }
                        else if (lineThree.Last().EndsWith("C"))
                        {
                            suitNeed = 3;
                        }
                        else if (lineThree.Last().EndsWith("S"))
                        {
                            suitNeed = 4;
                        }
                        #endregion
                        #region Find Last Line 3 Card Values
                        if (lineThree.Last().StartsWith("K"))
                        {
                            needValue = 13;
                        }

                        else if (lineThree.Last().StartsWith("Q"))
                        {
                            needValue = 12;
                        }

                        else if (lineThree.Last().StartsWith("J"))
                        {
                            needValue = 11;
                        }

                        else if (lineThree.Last().StartsWith("Te"))
                        {
                            needValue = 10;
                        }

                        else if (lineThree.Last().StartsWith("N"))
                        {
                            needValue = 9;
                        }

                        else if (lineThree.Last().StartsWith("E"))
                        {
                            needValue = 8;
                        }

                        else if (lineThree.Last().StartsWith("Se"))
                        {
                            needValue = 7;
                        }

                        else if (lineThree.Last().StartsWith("Si"))
                        {
                            needValue = 6;
                        }

                        else if (lineThree.Last().StartsWith("Fi"))
                        {
                            needValue = 5;
                        }

                        else if (lineThree.Last().StartsWith("Fo"))
                        {
                            needValue = 4;
                        }

                        else if (lineThree.Last().StartsWith("Th"))
                        {
                            needValue = 3;
                        }

                        else if (lineThree.Last().StartsWith("Tw"))
                        {
                            needValue = 2;
                        }

                        else if (lineThree.Last().StartsWith("A"))
                        {
                            needValue = 1;
                        }
                        #endregion
                        moveLine = 3;
                    }
                    catch
                    {
                        suitNeed = 0;
                        needValue = 0;
                    }
                    if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue || suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue)
                    {
                        MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
                    }
                    else
                    {
                        try
                        {
                            #region Find Last Line 4 Suit Values
                            if (lineFour.Last().EndsWith("H"))
                            {
                                suitNeed = 1;
                            }
                            else if (lineFour.Last().EndsWith("D"))
                            {
                                suitNeed = 2;
                            }
                            else if (lineFour.Last().EndsWith("C"))
                            {
                                suitNeed = 3;
                            }
                            else if (lineFour.Last().EndsWith("S"))
                            {
                                suitNeed = 4;
                            }
                            #endregion
                            #region Find Last Line 4 Card Values
                            if (lineFour.Last().StartsWith("K"))
                            {
                                needValue = 13;
                            }

                            else if (lineFour.Last().StartsWith("Q"))
                            {
                                needValue = 12;
                            }

                            else if (lineFour.Last().StartsWith("J"))
                            {
                                needValue = 11;
                            }

                            else if (lineFour.Last().StartsWith("Te"))
                            {
                                needValue = 10;
                            }

                            else if (lineFour.Last().StartsWith("N"))
                            {
                                needValue = 9;
                            }

                            else if (lineFour.Last().StartsWith("E"))
                            {
                                needValue = 8;
                            }

                            else if (lineFour.Last().StartsWith("Se"))
                            {
                                needValue = 7;
                            }

                            else if (lineFour.Last().StartsWith("Si"))
                            {
                                needValue = 6;
                            }

                            else if (lineFour.Last().StartsWith("Fi"))
                            {
                                needValue = 5;
                            }

                            else if (lineFour.Last().StartsWith("Fo"))
                            {
                                needValue = 4;
                            }

                            else if (lineFour.Last().StartsWith("Th"))
                            {
                                needValue = 3;
                            }

                            else if (lineFour.Last().StartsWith("Tw"))
                            {
                                needValue = 2;
                            }

                            else if (lineFour.Last().StartsWith("A"))
                            {
                                needValue = 1;
                            }
                            #endregion
                            moveLine = 4;
                        }
                        catch
                        {
                            suitNeed = 0;
                            needValue = 0;
                        }

                        if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue || suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue)
                        {
                            MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
                        }
                        else
                        {
                            try
                            {
                                #region Find Last Line 5 Suit Values
                                if (lineFive.Last().EndsWith("H"))
                                {
                                    suitNeed = 1;
                                }
                                else if (lineFive.Last().EndsWith("D"))
                                {
                                    suitNeed = 2;
                                }
                                else if (lineFive.Last().EndsWith("C"))
                                {
                                    suitNeed = 3;
                                }
                                else if (lineFive.Last().EndsWith("S"))
                                {
                                    suitNeed = 4;
                                }
                                #endregion
                                #region Find Last Line 5 Card Values
                                if (lineFive.Last().StartsWith("K"))
                                {
                                    needValue = 13;
                                }

                                else if (lineFive.Last().StartsWith("Q"))
                                {
                                    needValue = 12;
                                }

                                else if (lineFive.Last().StartsWith("J"))
                                {
                                    needValue = 11;
                                }

                                else if (lineFive.Last().StartsWith("Te"))
                                {
                                    needValue = 10;
                                }

                                else if (lineFive.Last().StartsWith("N"))
                                {
                                    needValue = 9;
                                }

                                else if (lineFive.Last().StartsWith("E"))
                                {
                                    needValue = 8;
                                }

                                else if (lineFive.Last().StartsWith("Se"))
                                {
                                    needValue = 7;
                                }

                                else if (lineFive.Last().StartsWith("Si"))
                                {
                                    needValue = 6;
                                }

                                else if (lineFive.Last().StartsWith("Fi"))
                                {
                                    needValue = 5;
                                }

                                else if (lineFive.Last().StartsWith("Fo"))
                                {
                                    needValue = 4;
                                }

                                else if (lineFive.Last().StartsWith("Th"))
                                {
                                    needValue = 3;
                                }

                                else if (lineFive.Last().StartsWith("Tw"))
                                {
                                    needValue = 2;
                                }

                                else if (lineFive.Last().StartsWith("A"))
                                {
                                    needValue = 1;
                                }
                                #endregion
                                moveLine = 5;
                            }
                            catch
                            {
                                suitNeed = 0;
                                needValue = 0;
                            }

                            if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue || suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue)
                            {
                                MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
                            }
                            else
                            {
                                try
                                {
                                    #region Find Last Line 6 Suit Values
                                    if (lineSix.Last().EndsWith("H"))
                                    {
                                        suitNeed = 1;
                                    }
                                    else if (lineSix.Last().EndsWith("D"))
                                    {
                                        suitNeed = 2;
                                    }
                                    else if (lineSix.Last().EndsWith("C"))
                                    {
                                        suitNeed = 3;
                                    }
                                    else if (lineSix.Last().EndsWith("S"))
                                    {
                                        suitNeed = 4;
                                    }
                                    #endregion
                                    #region Find Last Line 6 Card Values
                                    if (lineSix.Last().StartsWith("K"))
                                    {
                                        needValue = 13;
                                    }

                                    else if (lineSix.Last().StartsWith("Q"))
                                    {
                                        needValue = 12;
                                    }

                                    else if (lineSix.Last().StartsWith("J"))
                                    {
                                        needValue = 11;
                                    }

                                    else if (lineSix.Last().StartsWith("Te"))
                                    {
                                        needValue = 10;
                                    }

                                    else if (lineSix.Last().StartsWith("N"))
                                    {
                                        needValue = 9;
                                    }

                                    else if (lineSix.Last().StartsWith("E"))
                                    {
                                        needValue = 8;
                                    }

                                    else if (lineSix.Last().StartsWith("Se"))
                                    {
                                        needValue = 7;
                                    }

                                    else if (lineSix.Last().StartsWith("Si"))
                                    {
                                        needValue = 6;
                                    }

                                    else if (lineSix.Last().StartsWith("Fi"))
                                    {
                                        needValue = 5;
                                    }

                                    else if (lineSix.Last().StartsWith("Fo"))
                                    {
                                        needValue = 4;
                                    }

                                    else if (lineSix.Last().StartsWith("Th"))
                                    {
                                        needValue = 3;
                                    }

                                    else if (lineSix.Last().StartsWith("Tw"))
                                    {
                                        needValue = 2;
                                    }

                                    else if (lineSix.Last().StartsWith("A"))
                                    {
                                        needValue = 1;
                                    }
                                    #endregion
                                    moveLine = 6;
                                }
                                catch
                                {
                                    suitNeed = 0;
                                    needValue = 0;
                                }
                                if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue || suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue)
                                {
                                    MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
                                }
                                else
                                {
                                    try
                                    {

                                        #region Find Last Line 7 Suit Values
                                        if (lineSeven.Last().EndsWith("H"))
                                        {
                                            suitNeed = 1;
                                        }
                                        else if (lineSeven.Last().EndsWith("D"))
                                        {
                                            suitNeed = 2;
                                        }
                                        else if (lineSeven.Last().EndsWith("C"))
                                        {
                                            suitNeed = 3;
                                        }
                                        else if (lineSeven.Last().EndsWith("S"))
                                        {
                                            suitNeed = 4;
                                        }
                                        #endregion
                                        #region Find Last Line 7 Card Values
                                        if (lineSeven.Last().StartsWith("K"))
                                        {
                                            needValue = 13;
                                        }

                                        else if (lineSeven.Last().StartsWith("Q"))
                                        {
                                            needValue = 12;
                                        }

                                        else if (lineSeven.Last().StartsWith("J"))
                                        {
                                            needValue = 11;
                                        }

                                        else if (lineSeven.Last().StartsWith("Te"))
                                        {
                                            needValue = 10;
                                        }

                                        else if (lineSeven.Last().StartsWith("N"))
                                        {
                                            needValue = 9;
                                        }

                                        else if (lineSeven.Last().StartsWith("E"))
                                        {
                                            needValue = 8;
                                        }

                                        else if (lineSeven.Last().StartsWith("Se"))
                                        {
                                            needValue = 7;
                                        }

                                        else if (lineSeven.Last().StartsWith("Si"))
                                        {
                                            needValue = 6;
                                        }

                                        else if (lineSeven.Last().StartsWith("Fi"))
                                        {
                                            needValue = 5;
                                        }

                                        else if (lineSeven.Last().StartsWith("Fo"))
                                        {
                                            needValue = 4;
                                        }

                                        else if (lineSeven.Last().StartsWith("Th"))
                                        {
                                            needValue = 3;
                                        }

                                        else if (lineSeven.Last().StartsWith("Tw"))
                                        {
                                            needValue = 2;
                                        }

                                        else if (lineSeven.Last().StartsWith("A"))
                                        {
                                            needValue = 1;
                                        }
                                        #endregion
                                        moveLine = 7;
                                    }
                                    catch
                                    {
                                        suitNeed = 0;
                                        needValue = 0;
                                    }
                                    if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue || suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue)
                                    {
                                        MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
                                    }
                                    else
                                    {
                                        #region Find Last Hearts Pile Card Values
                                        suitNeed = 3;
                                        if (heartsBox.SelectedIndex != -1)
                                        {
                                            if (goalPileH.Last().StartsWith("K"))
                                            {
                                                needValue = 13;
                                            }

                                            else if (goalPileH.Last().StartsWith("Q"))
                                            {
                                                needValue = 12;
                                            }

                                            else if (goalPileH.Last().StartsWith("J"))
                                            {
                                                needValue = 11;
                                            }

                                            else if (goalPileH.Last().StartsWith("Te"))
                                            {
                                                needValue = 10;
                                            }

                                            else if (goalPileH.Last().StartsWith("N"))
                                            {
                                                needValue = 9;
                                            }

                                            else if (goalPileH.Last().StartsWith("E"))
                                            {
                                                needValue = 8;
                                            }

                                            else if (goalPileH.Last().StartsWith("Se"))
                                            {
                                                needValue = 7;
                                            }

                                            else if (goalPileH.Last().StartsWith("Si"))
                                            {
                                                needValue = 6;
                                            }

                                            else if (goalPileH.Last().StartsWith("Fi"))
                                            {
                                                needValue = 5;
                                            }

                                            else if (goalPileH.Last().StartsWith("Fo"))
                                            {
                                                needValue = 4;
                                            }

                                            else if (goalPileH.Last().StartsWith("Th"))
                                            {
                                                needValue = 3;
                                            }

                                            else if (goalPileH.Last().StartsWith("Tw"))
                                            {
                                                needValue = 2;
                                            }

                                            else if (goalPileH.Last().StartsWith("A"))
                                            {
                                                needValue = 1;
                                            }
                                            #endregion
                                        }
                                        else
                                        {
                                            needValue = 1;
                                            moveLine = 10;
                                            if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue ||
                                                suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue ||
                                                suit <= 2 && suitNeed >= 3 && cardValue == needValue)
                                            {
                                                MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
                                            }
                                            else
                                            {
                                                #region Find Last Diamonds Pile Card Values
                                                suitNeed = 2;
                                                if (diamondsBox.SelectedIndex != -1)
                                                {
                                                    if (goalPileD.Last().StartsWith("K"))
                                                    {
                                                        needValue = 13;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("Q"))
                                                    {
                                                        needValue = 12;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("J"))
                                                    {
                                                        needValue = 11;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("Te"))
                                                    {
                                                        needValue = 10;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("N"))
                                                    {
                                                        needValue = 9;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("E"))
                                                    {
                                                        needValue = 8;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("Se"))
                                                    {
                                                        needValue = 7;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("Si"))
                                                    {
                                                        needValue = 6;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("Fi"))
                                                    {
                                                        needValue = 5;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("Fo"))
                                                    {
                                                        needValue = 4;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("Th"))
                                                    {
                                                        needValue = 3;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("Tw"))
                                                    {
                                                        needValue = 2;
                                                    }

                                                    else if (goalPileD.Last().StartsWith("A"))
                                                    {
                                                        needValue = 1;
                                                    }

                                                    #endregion
                                                    moveLine = 11;
                                                    if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue ||
                                                        suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue ||
                                                        suit <= 2 && suitNeed >= 3 && cardValue == 1 && goalPileD.Count() == -1 ||
                                                        suit <= 2 && suitNeed >= 3 && cardValue == 1 && goalPileD.Count() == -1)
                                                    {
                                                        MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
                                                    }
                                                    else
                                                    {
                                                        #region Find Last Clubs Pile Card Values
                                                        suitNeed = 3;
                                                        if (clubsBox.SelectedIndex != -1)
                                                        {
                                                            if (goalPileC.Last().StartsWith("K"))
                                                            {
                                                                needValue = 13;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("Q"))
                                                            {
                                                                needValue = 12;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("J"))
                                                            {
                                                                needValue = 11;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("Te"))
                                                            {
                                                                needValue = 10;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("N"))
                                                            {
                                                                needValue = 9;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("E"))
                                                            {
                                                                needValue = 8;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("Se"))
                                                            {
                                                                needValue = 7;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("Si"))
                                                            {
                                                                needValue = 6;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("Fi"))
                                                            {
                                                                needValue = 5;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("Fo"))
                                                            {
                                                                needValue = 4;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("Th"))
                                                            {
                                                                needValue = 3;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("Tw"))
                                                            {
                                                                needValue = 2;
                                                            }

                                                            else if (goalPileC.Last().StartsWith("A"))
                                                            {
                                                                needValue = 1;
                                                            }
                                                            #endregion
                                                            moveLine = 12;
                                                            if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue ||
                                                                suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue ||
                                                                suit <= 2 && suitNeed >= 3 && cardValue == 1 && goalPileC.Count() == -1 ||
                                                                suit <= 2 && suitNeed >= 3 && cardValue == 1 && goalPileC.Count() == -1)
                                                            {
                                                                MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
                                                            }
                                                            else
                                                            {
                                                                #region Find Last Spades Pile Card Values
                                                                suitNeed = 4;
                                                                if (spadesBox.SelectedIndex != -1)
                                                                {
                                                                    if (goalPileS.Last().StartsWith("K"))
                                                                    {
                                                                        needValue = 13;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("Q"))
                                                                    {
                                                                        needValue = 12;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("J"))
                                                                    {
                                                                        needValue = 11;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("Te"))
                                                                    {
                                                                        needValue = 10;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("N"))
                                                                    {
                                                                        needValue = 9;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("E"))
                                                                    {
                                                                        needValue = 8;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("Se"))
                                                                    {
                                                                        needValue = 7;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("Si"))
                                                                    {
                                                                        needValue = 6;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("Fi"))
                                                                    {
                                                                        needValue = 5;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("Fo"))
                                                                    {
                                                                        needValue = 4;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("Th"))
                                                                    {
                                                                        needValue = 3;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("Tw"))
                                                                    {
                                                                        needValue = 2;
                                                                    }

                                                                    else if (goalPileS.Last().StartsWith("A"))
                                                                    {
                                                                        needValue = 1;
                                                                    }

                                                                    #endregion
                                                                    moveLine = 13;
                                                                    if (suit <= 2 && suitNeed >= 3 && cardValue + 1 == needValue ||
                                                                        suit >= 3 && suitNeed <= 2 && cardValue + 1 == needValue ||
                                                                        suit <= 2 && suitNeed >= 3 && cardValue == 1 && goalPileS.Count() == -1 ||
                                                                        suit <= 2 && suitNeed >= 3 && cardValue == 1 && goalPileS.Count() == -1)
                                                                    {
                                                                        MoveCard(suit, cardValue, suitNeed, needValue, moveLine, currentLine);
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("This card can not be moved");
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #region Click Methods for all Playing Lines
        private void listBox1_Click(object sender, EventArgs e)
        {
            moveCount++;
            movesNumber.Text = "MOVES: " + moveCount;
            if (lineBox1.SelectedIndex != -1)
            {
                cardUp = true;
                chosenCard = lineBox1.SelectedItem.ToString();

                if (cardUp)
                {
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

                    else if (chosenCard.StartsWith("Tw"))
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

                    currentLine = 1;
                    CheckLines(suit, cardValue, currentLine);
                }
                else
                {
                    MessageBox.Show("This card is not uncovered, you can not move it");
                }
            }
            else
            {
                MessageBox.Show("This line has no cards.");
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            moveCount++;
            movesNumber.Text = "MOVES: " + moveCount;
            if (lineBox2.SelectedIndex != -1)
            {
                cardUp = true;
                chosenCard = lineBox2.SelectedItem.ToString();

                if (cardUp)
                {
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

                    else if (chosenCard.StartsWith("Tw"))
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

                    currentLine = 2;
                    CheckLines(suit, cardValue, currentLine);
                }
                else
                {
                    MessageBox.Show("This card is not uncovered, you can not move it");
                }
            }
            else
            {
                MessageBox.Show("This line has no cards.");
            }
        }

        private void listBox3_Click(object sender, EventArgs e)
        {
            moveCount++;
            movesNumber.Text = "MOVES: " + moveCount;
            if (lineBox3.SelectedIndex != -1)
            {
                cardUp = true;
                chosenCard = lineBox3.SelectedItem.ToString();

                if (cardUp)
                {
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

                    else if (chosenCard.StartsWith("Tw"))
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

                    currentLine = 3;
                    CheckLines(suit, cardValue, currentLine);
                }
                else
                {
                    MessageBox.Show("This card is not uncovered, you can not move it");
                }
            }
            else
            {
                MessageBox.Show("This line has no cards.");
            }
        }

        private void listBox4_Click(object sender, EventArgs e)
        {
            moveCount++;
            movesNumber.Text = "MOVES: " + moveCount;
            if (lineBox4.SelectedIndex != -1)
            {
                cardUp = true;
                chosenCard = lineBox4.SelectedItem.ToString();

                if (cardUp)
                {
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

                    else if (chosenCard.StartsWith("Tw"))
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

                    currentLine = 4;
                    CheckLines(suit, cardValue, currentLine);
                }
                else
                {
                    MessageBox.Show("This card is not uncovered, you can not move it");
                }
            }
            else
            {
                MessageBox.Show("This line has no cards.");
            }
        }

        private void listBox5_Click(object sender, EventArgs e)
        {
            moveCount++;
            movesNumber.Text = "MOVES: " + moveCount;
            if (lineBox5.SelectedIndex != -1)
            {
                cardUp = true;
                chosenCard = lineBox5.SelectedItem.ToString();

                if (cardUp)
                {
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

                    else if (chosenCard.StartsWith("Tw"))
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

                    currentLine = 5;
                    CheckLines(suit, cardValue, currentLine);
                }
                else
                {
                    MessageBox.Show("This card is not uncovered, you can not move it");
                }
            }
            else
            {
                MessageBox.Show("This line has no cards.");
            }
        }

        private void listBox6_Click(object sender, EventArgs e)
        {
            moveCount++;
            movesNumber.Text = "MOVES: " + moveCount;
            if (lineBox6.SelectedIndex != -1)
            {
                cardUp = true;
                chosenCard = lineBox6.SelectedItem.ToString();
                if (cardUp)
                {
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

                    else if (chosenCard.StartsWith("Tw"))
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

                    currentLine = 6;
                    CheckLines(suit, cardValue, currentLine);
                }
                else
                {
                    MessageBox.Show("This card is not uncovered, you can not move it");
                }
            }
            else
            {
                MessageBox.Show("This line has no cards.");
            }
        }

        private void listBox7_Click(object sender, EventArgs e)
        {
            moveCount++;
            movesNumber.Text = "MOVES: " + moveCount;
            if (lineBox7.SelectedIndex != -1)
            {
                cardUp = true;
                chosenCard = lineBox7.SelectedItem.ToString();
                if (cardUp)
                {
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

                    else if (chosenCard.StartsWith("Tw"))
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

                    currentLine = 7;
                    CheckLines(suit, cardValue, currentLine);
                }
                else
                {
                    MessageBox.Show("This card is not uncovered, you can not move it");
                }
            }
            else
            {
                MessageBox.Show("This line has no cards.");
            }
        }
        #endregion

        private void drawCardButton_Click(object sender, EventArgs e)
        {
            moveCount++;
            movesNumber.Text = "MOVES: " + moveCount;

            if(drawPile.Count() != 0)
            {
                playPile.Add(drawPile[0]);
                drawPile.Remove(drawPile[0]);
                playCardBox.Items.Insert(0, playPile.Last());
            }
            else
            {
                drawPile.AddRange(playPile);
                playPile.Clear();
                playCardBox.Items.Clear();
            }
        }

        private void playCardBox_Click(object sender, EventArgs e)
        {
            moveCount++;
            movesNumber.Text = "MOVES: " + moveCount;
            if (playCardBox.SelectedIndex != -1)
            {
                chosenCard = playCardBox.SelectedItem.ToString();

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

                else if (chosenCard.StartsWith("Tw"))
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
                currentLine = 0;
                CheckLines(suit, cardValue, currentLine);
            }
            else
            {
                MessageBox.Show("There are no cards, click the DRAW CARD or DEAL button.");
            }
        }
        public void WinScreen()
        {
            loadButton.Dispose();
            drawCardButton.Visible = false;
            playCardBox.Visible = false;
            heartsBox.Visible = false;
            clubsBox.Visible = false;
            diamondsBox.Visible = false;
            spadesBox.Visible = false;
            heartsLabel.Visible = false;
            spadesLabel.Visible = false;
            clubsLabel.Visible = false;
            diamondsLabel.Visible = false;
            lineBox1.Visible = false;
            lineBox2.Visible = false;
            lineBox3.Visible = false;
            lineBox4.Visible = false;
            lineBox5.Visible = false;
            lineBox6.Visible = false;
            lineBox7.Visible = false;

            Graphics g = this.CreateGraphics();
            Pen winPen = new Pen(Color.Blue);
            SolidBrush winBrush = new SolidBrush(Color.White);
            g.FillRectangle(winBrush, 0, 0, 300, 300);
            minLabel.Location = new Point(300, 200);
            minLabel.ForeColor = Color.Blue;

            
            MessageBox.Show("Congratulations, you win!");
        }
    }
}

