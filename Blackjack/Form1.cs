using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        /* http://patorjk.com/software/taag/
         
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

        List<Card> cardList = new List<Card>()
        {
            new Card() { Value  = 0, Name = "null", Image = "null" }
        };
        
        int cardSum = 0;
        Random random = new Random();
        List<int> usedCards = new List<int>();
        
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

         private void dealButton_Click(object sender, EventArgs e)
        {
            if (cardSum > 0)
            {
                    resultLabel.Text = String.Format
                    ("Click Reset");
            }

            else
            {
                displayCardBack(pictureBox3);
                
                cardSum = 0;
                int randomCard1 = selectRandomCard();
                Card card1 = deck[randomCard1];
                usedCards.Add(randomCard1);
                int randomCard2 = selectRandomCard();

                if (randomCard1 == randomCard2) selectRandomCard();
                else randomCard2 = 1 * randomCard2;
                
                Card card2 = deck[randomCard2];
                usedCards.Add(randomCard2);

                cardList.Add(card1);
                cardList.Add(card2);
                
                pictureBox1.ImageLocation = card1.Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                
                pictureBox2.ImageLocation = card2.Image;
                pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;

                sumCards();
                if (cardSum > 21)
                {
                    resultLabel.Text = String.Format
                        ("The sum of the cards is: {0}, you lose! Click Reset", cardSum);
                }

                else if (cardSum == 21)
                {
                    resultLabel.Text = String.Format("The sum of the cards is: {0}, you win!",
                   cardSum);
                }
                else
                    resultLabel.Text = String.Format("The sum of the cards is: {0}",
                       cardSum);
            }
        }

        private int selectRandomCard()
        {
            int randomCard;
            randomCard = random.Next(0, deck.Count);
            return randomCard;
        }

        private int sumCards()
        {

            for (int i = 0; i < cardList.Count; i++)
            {
                cardSum += cardList[i].Value;
            }
            return cardSum;
        }

        private void hitMeButton_Click(object sender, EventArgs e)
        {
            if (cardSum == 0)
            {
                resultLabel.Text = "Click the Deal button...";
                displayCardBack(pictureBox3);
            }

            else
            {
                if (cardSum > 100)
                {
                    resetGame();
                    resultLabel.Text = "Resetting game... Click Deal when ready";
                }

                else
                {
                    cardSum = 0;
                    int randomCard = selectRandomCard();
                    Card card = deck[randomCard];
                    usedCards.Add(randomCard);

                    if (usedCards.Contains(randomCard)) randomCard = selectRandomCard();
                    else randomCard = 1 * randomCard;

                    pictureBox3.ImageLocation = card.Image;
                    pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
                    cardList.Add(card);
                    cardSum = sumCards();
                    if (cardSum > 21)
                    {
                        resultLabel.Text = String.Format
                            ("The sum of the cards is: {0}, you lose! Click Reset", cardSum);
                    }

                    else if (cardSum == 21)
                    {
                        resultLabel.Text = String.Format
                            ("The sum of the cards is: {0}, you win!", cardSum);
                    }
                    else
                        resultLabel.Text = String.Format
                            ("The sum of the cards is: {0}", cardSum);
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
            displayCardBack(pictureBox3);
            
            cardSum = 0;
            cardList.Clear();
            usedCards.Clear();
            resultLabel.Text = "Click Deal when ready";
        }

        private void displayCardBack(PictureBox picturebox)
        {
            picturebox.ImageLocation = "b1fv.png";
            picturebox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
