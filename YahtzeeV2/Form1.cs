using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeV2
{
    public partial class Form1 : Form
    {

        //declarations
        Image[] diceImg;
        int[] diceValue;
        int[] rollResults;
        Random rngeesus;
        //declarations

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    // loading images into the image array
            diceImg = new Image[8];
            diceImg[0] = Properties.Resources.dice1_6;
            diceImg[1] = Properties.Resources.dice1;
            diceImg[2] = Properties.Resources.dice2;
            diceImg[3] = Properties.Resources.dice3;
            diceImg[4] = Properties.Resources.dice4;
            diceImg[5] = Properties.Resources.dice5;
            diceImg[6] = Properties.Resources.dice6;
            diceImg[7] = Properties.Resources.rollDice;

                    //setting up the integer array with no values
            diceValue = new int[5] { 0, 0, 0, 0, 0 };
                    
            rngeesus = new Random();
                    //setting up the integer array that will hold the results
            rollResults = new int[6] { 0, 0, 0, 0, 0, 0 };
        }

        private void diceRoll()
        {
            for (int i = 0; i < diceValue.Length; i++)
            {
                diceValue[i] = rngeesus.Next(1, 7); // 7 not included, its 1,2,3,4,5,6.
                dice1.Image = diceImg[diceValue[0]];
                dice2.Image = diceImg[diceValue[1]];
                dice3.Image = diceImg[diceValue[2]];
                dice4.Image = diceImg[diceValue[3]];
                dice5.Image = diceImg[diceValue[4]];

                switch (diceValue[i])
                {
                    case 1:
                        rollResults[0]++;
                        break;
                    case 2:
                        rollResults[1]++;
                        break;
                    case 3:
                        rollResults[2]++;
                        break;
                    case 4:
                        rollResults[3]++;
                        break;
                    case 5:
                        rollResults[4]++;
                        break;
                    case 6:
                        rollResults[5]++;
                        break;

                }
            }

        }
        
        private void GetResult()
        {
            bool onePair, twoPair, threeOfKind, fullHouse, straight, highStraight, fourOfKind, fiveOfKind, six, five, four, three, two, one = false;
            for (int i = 0; i < rollResults.Length; i ++)
            {
                if (rollResults[i] == 5)
                    fiveOfKind = true;
                else if (rollResults[i] == 4)
                    fourOfKind = true;
                else if (rollResults[i] == 3)
                {
                    threeOfKind = true;
                    if (rollResults[i] == 2)
                    {
                        fullHouse = true;
                        threeOfKind = false;

                    }
                }
                else if (rollResults[0] == 1 && rollResults[1] == 1 && rollResults[2] == 1 && rollResults[3] == 1 && rollResults[4] == 1)
                {
                    straight = true;
                }
                else if (rollResults[5] == 1 && rollResults[1] == 1 && rollResults[2] == 1 && rollResults[3] == 1 && rollResults[4] == 1)
                {
                    highStraight = true;
                }
                else if (rollResults[i] == 2)
                {
                    onePair = true;
                    for (int j = i+1; j < rollResults.Length; i++)
                    {
                        if (rollResults[j] == 2)
                            twoPair = true;
                    }
                }


            
            }
        }

        private void ResultReset()
        {

        }

        private void rollDiceBtn_Click(object sender, EventArgs e)
        {
            diceRoll();
            GetResult();
            ResultReset();
        }
    }
}
