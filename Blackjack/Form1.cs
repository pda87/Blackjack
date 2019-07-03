using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        /* http://patorjk.com/software/taag/
        //https://github.com/pda87/Blackjack
         
 ________  ___       ________  ________  ___  __          ___  ________  ________  ___  __       
|\   __  \|\  \     |\   __  \|\   ____\|\  \|\  \       |\  \|\   __  \|\   ____\|\  \|\  \     
\ \  \|\ /\ \  \    \ \  \|\  \ \  \___|\ \  \/  /|_     \ \  \ \  \|\  \ \  \___|\ \  \/  /|_   
 \ \   __  \ \  \    \ \   __  \ \  \    \ \   ___  \  __ \ \  \ \   __  \ \  \    \ \   ___  \  
  \ \  \|\  \ \  \____\ \  \ \  \ \  \____\ \  \\ \  \|\  \\_\  \ \  \ \  \ \  \____\ \  \\ \  \ 
   \ \_______\ \_______\ \__\ \__\ \_______\ \__\\ \__\ \________\ \__\ \__\ \_______\ \__\\ \__\
    \|_______|\|_______|\|__|\|__|\|_______|\|__| \|__|\|________|\|__|\|__|\|_______|\|__| \|__|
          
         */

        /////////////////////////////////////////////////////////////////////////////////
        ////// A C# WINDOWS FORM APP SIMULATING A GAME OF THE CARD GAME 'BLACKJACK' /////
        /////////////////////// AUTHOR: PETER ARDEN /////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////

        //CHANGE THE VALUE OF ALL FACE CARDS TO 10, AND THE ACE TO 11

        List<Card> playercardList = new List<Card>()
        {
            new Card() { Value  = 0, Name = "null", Image = "null" }
        };

        List<Card> bankercardList = new List<Card>()
        {
            new Card() { Value  = 0, Name = "null", Image = "null" }
        };

        int playercardSum = 0;
        int bankercardSum = 0;
        Random random = new Random();
        List<int> usedCards = new List<int>();
        List<PictureBox> bankerbox = new List<PictureBox>();
        List<PictureBox> playerbox = new List<PictureBox>();


        #region creationof52carddeck

        List<Card> deck = new List<Card>()
            {
                #region spades

                new Card() { Value  = 2, Name = "Two Spades", Image = "2S.png" },
                new Card() { Value = 3, Name = "Three Spades", Image = "3S.png"},
                new Card() { Value = 4, Name =  "Four Spades", Image = "4S.png"},
                new Card() { Value = 5, Name = "Five Spades", Image = "5S.png" },
                new Card() { Value = 6, Name = "Six Spades", Image = "6S.png" },
                new Card() { Value = 7, Name = "Seven Spades", Image = "7S.png" },
                new Card() { Value = 8, Name = "Eight Spades", Image = "8S.png" },
                new Card() { Value = 9, Name = "Nine Spades", Image = "9S.png" },
                new Card() { Value = 10, Name = "Ten Spades", Image = "10S.png" },
                new Card() { Value = 10, Name = "Jack Spades", Image = "JS.png" },
                new Card() { Value = 10, Name = "Queen Spades", Image = "QS.png" },
                new Card(){ Value = 10, Name = "King Spades", Image = "KS.png" },
                new Card(){ Value = 11, Name = "Ace Spades", Image = "AS.png" },

                #endregion

                #region diamonds

                new Card() { Value  = 2, Name = "Two Diamonds", Image = "2D.png" },
                new Card() { Value = 3, Name = "Three Diamonds", Image = "3D.png" },
                new Card() { Value = 4, Name =  "Four Diamonds", Image = "4D.png"},
                new Card() { Value = 5, Name = "Five Diamonds", Image = "5D.png" },
                new Card() { Value = 6, Name = "Six Diamonds", Image = "6D.png" },
                new Card(){ Value = 7, Name = "Seven Diamonds", Image = "7D.png" },
                new Card() { Value = 8, Name = "Eight Diamonds", Image = "8D.png" },
                new Card() { Value = 9, Name = "Nine Diamonds", Image = "9D.png" },
                new Card() { Value = 10, Name = "Ten Diamonds", Image = "10D.png" },
                new Card() { Value = 10, Name = "Jack Diamonds", Image = "JD.png" },
                new Card() { Value = 10, Name = "Queen Diamonds", Image = "QD.png" },
                new Card(){ Value = 10, Name = "King Diamonds", Image = "KD.png" },
                new Card(){ Value = 11, Name = "Ace Diamonds", Image = "AD.png" },

                #endregion

                #region clubs

                new Card() { Value  = 2, Name = "Two Clubs", Image = "2C.png" },
                new Card() { Value = 3, Name = "Three Clubs", Image = "3C.png" },
                new Card() { Value = 4, Name =  "Four Clubs", Image = "4C.png"},
                new Card() { Value = 5, Name = "Five Clubs", Image = "5C.png" },
                new Card() { Value = 6, Name = "Six Clubs", Image = "6C.png" },
                new Card(){ Value = 7, Name = "Seven Clubs", Image = "7C.png" },
                new Card() { Value = 8, Name = "Eight Clubs", Image = "8C.png" },
                new Card() { Value = 9, Name = "Nine Clubs", Image= "9C.png" },
                new Card() { Value = 10, Name = "Ten Clubs", Image = "10C.png" },
                new Card() { Value = 10, Name = "Jack Clubs", Image = "JC.png" },
                new Card() { Value = 10, Name = "Queen Clubs", Image = "QC.png" },
                new Card(){ Value = 10, Name = "King Clubs", Image = "KC.png" },
                new Card(){ Value = 11, Name = "Ace Clubs", Image = "AC.png" },

                #endregion

                #region hearts

                new Card() { Value  = 2, Name = "Two Hearts", Image = "2H.png" },
                new Card() { Value = 3, Name = "Three Hearts", Image = "3H.png" },
                new Card() { Value = 4, Name =  "Four Hearts", Image = "4H.png"},
                new Card() { Value = 5, Name = "Five Hearts", Image = "5H.png" },
                new Card() { Value = 6, Name = "Six Hearts", Image = "6H.png" },
                new Card(){ Value = 7, Name = "Seven Hearts", Image = "7H.png" },
                new Card() { Value = 8, Name = "Eight Hearts", Image = "8H.png" },
                new Card() { Value = 9, Name = "Nine Hearts", Image = "9H.png" },
                new Card() { Value = 10, Name = "Ten Hearts", Image = "10H.png" },
                new Card() { Value = 10, Name = "Jack Hearts", Image = "JH.png" },
                new Card() { Value = 10, Name = "Queen Hearts", Image = "QH.png" },
                new Card(){ Value = 10, Name = "King Hearts", Image = "KH.png" },
                new Card(){ Value = 11, Name = "Ace Hearts", Image = "AH.png" }

                #endregion
            };

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetGame();
        }

        //start the game 
         private void startButton_Click(object sender, EventArgs e)
        {
            if (playercardSum > 0)
            {
                    resultLabel.Text = String.Format
                    ("Already started.");
            }

            else
            {
                playercardSum = 0;
                bankercardSum = 0;

                #region init player
                int randomCard1 = selectRandomCard();
                Card card1 = deck[randomCard1];
                usedCards.Add(randomCard1);
                int randomCard2 = selectRandomCard();


                while (usedCards.Contains(randomCard2))
                {
                    randomCard2 = selectRandomCard();
                }
                randomCard2 = 1 * randomCard2;
                
                Card card2 = deck[randomCard2];
                usedCards.Add(randomCard2);

                playercardList.Add(card1);
                playercardList.Add(card2);
                
                pictureBox1.ImageLocation = card1.Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                
                pictureBox2.ImageLocation = card2.Image;
                pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
                #endregion
                #region init banker
                int randomCard3 = selectRandomCard();
                while (usedCards.Contains(randomCard3))
                {
                    randomCard3 = selectRandomCard();
                }
                randomCard3 = 1 * randomCard3;
                Card card3 = deck[randomCard3];
                usedCards.Add(randomCard3);

                bankercardList.Add(card3);

                pictureBox4.ImageLocation = card3.Image;
                pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;

                #endregion

                sumPlayerCards();

                //sumCards();

                if (playercardSum == 21)
                {
                    resultLabel.Text = String.Format
                        ("The sum of your cards is: {0}, you win!", playercardSum);
                    MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resetGame();
                }


            }
        }

        private int selectRandomCard()
        {
            int randomCard;
            randomCard = random.Next(0, deck.Count);
            return randomCard;
        }

        private void sumPlayerCards()
        {
            playercardSum = 0;
            for (int i = 0; i < playercardList.Count; i++)
            {
                playercardSum += playercardList[i].Value;
            }

            if(playercardSum > 21)
            {
                foreach(Card c in playercardList)
                {
                    if(c.Value == 11)
                    {
                        playercardSum -= 10;
                        if(playercardSum <= 21)
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void sumBankerCards()
        {
            bankercardSum = 0;
            for (int i = 0; i < bankercardList.Count; i++)
            {
                bankercardSum += bankercardList[i].Value;
            }
            if (bankercardSum > 21)
            {
                foreach (Card c in bankercardList)
                {
                    if (c.Value == 11)
                    {
                        bankercardSum -= 10;
                        if (bankercardSum <= 21)
                        {
                            break;
                        }
                    }
                }
            }
        }
        // give one card to player
        private void DealButton_Click(object sender, EventArgs e)
        {
            if (playercardSum == 0)
            {
                resultLabel.Text = "Click the Start button...";
                //displayCardBack(pictureBox3);
            }

            else
            {
                if (playercardSum > 100) //to be changed
                {
                    resetGame();
                    resultLabel.Text = "Resetting game...";
                }

                else
                {
                    playercardSum = 0;
                    int randomCard = selectRandomCard();
                    Card card = deck[randomCard];
                    usedCards.Add(randomCard);

                    if (usedCards.Contains(randomCard)) randomCard = selectRandomCard();
                    else randomCard = 1 * randomCard;


                    //player new card
                    PictureBox p3 = new PictureBox();
                    p3.Width = 71;
                    p3.Height = 96;
                    p3.Location = new Point(154 + 77 + playerbox.Count * 77, 137 );
                    p3.ImageLocation = card.Image;
                    p3.SizeMode = PictureBoxSizeMode.AutoSize;
                    this.Controls.Add(p3);

                    playerbox.Add(p3);

                    playercardList.Add(card);
                    sumPlayerCards();
                    if (playercardSum > 21)
                    {
                        resultLabel.Text = String.Format
                            ("The sum of your cards is: {0}, you lose!", playercardSum);
                        MessageBox.Show("You lose!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resetGame();
                    }
                    else if (playercardSum == 21)
                    {
                        resultLabel.Text = String.Format
                            ("The sum of your cards is: {0}, you win!", playercardSum);
                        MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resetGame();
                    }
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void resetGame()
        {
            resultLabel.Text = null;

            displayCardBack(pictureBox1);
            displayCardBack(pictureBox2);
            //displayCardBack(pictureBox3);
            displayCardBack(pictureBox4);
            //displayCardBack(pictureBox6);
            foreach(PictureBox pb in playerbox)
            {
                this.Controls.Remove(pb);
            }
            playerbox = new List<PictureBox>();
            foreach (PictureBox pb in bankerbox)
            {
                this.Controls.Remove(pb);
            }
            bankerbox = new List<PictureBox>();

            playercardSum = 0;
            bankercardSum = 0;
            playercardList.Clear();
            bankercardList.Clear();
            usedCards.Clear();
            resultLabel.Text = "Player choice";
        }

        private void displayCardBack(PictureBox picturebox)
        {
            picturebox.ImageLocation = "b1fv.png";
            picturebox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        // palyer stop move
        private void PlayerStopButton_Click(object sender, EventArgs e)
        {
            if (playercardSum == 0)
            {
                resultLabel.Text = "Click the Start button...";
                return;
            }
            sumBankerCards();

            //banker move
            while (bankercardSum <= 16)
            {
                int randomCard = selectRandomCard();
                Card card = deck[randomCard];
                usedCards.Add(randomCard);

                if (usedCards.Contains(randomCard)) randomCard = selectRandomCard();
                else randomCard = 1 * randomCard;

                PictureBox p4 = new PictureBox();
                p4.Width = 71;
                p4.Height = 96;
                p4.Location = new Point(154 + bankerbox.Count * 77, 12);
                p4.ImageLocation = card.Image;
                p4.SizeMode = PictureBoxSizeMode.AutoSize;
                this.Controls.Add(p4);


                bankerbox.Add(p4);

                bankercardList.Add(card);
                sumBankerCards();
            }

            if (bankercardSum > 21)
            {
                resultLabel.Text = String.Format
                    ("The sum of banker cards is: {0}, you lose!", bankercardSum);
                MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
            else if (playercardSum <= bankercardSum)
            {
                resultLabel.Text = String.Format
                    ("The sum of your cards is: {0}, you lose!", playercardSum);
                MessageBox.Show("You lose!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
            else
            {
                resultLabel.Text = String.Format
                    ("The sum of your cards is: {0}, you win!", playercardSum);
                MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }

        }








        
    }
}
