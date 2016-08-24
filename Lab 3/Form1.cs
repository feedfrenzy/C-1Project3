using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        Game myGame = new Game();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int guessNumber;
            
            bool isInt = int.TryParse(txtUserEntry.Text, out guessNumber);

            if (isInt)
            {
                    guessNumber = Convert.ToInt32(txtUserEntry.Text);

                    if (guessNumber < 1 || guessNumber > 100)
                    {
                        MessageBox.Show("Please enter an interger between 1 to 100");
                    }

                    lblGuessAnswer.Text = Convert.ToString(myGame.getCount());
                    lblWinAnswer.Text = Convert.ToString(myGame.storeWin());
                    lblLoserAnswer.Text = Convert.ToString(myGame.storeLose());



                    int returnNumber = myGame.logic(guessNumber);


                    if (returnNumber == 0)
                    {
                        lblDisplay.Text = "You are corrected!";

                        DialogResult answer = MessageBox.Show("You want to start a new game?", "", MessageBoxButtons.YesNo);

                        if (answer == DialogResult.Yes)
                        {
                            txtUserEntry.Text = "";
                            lblDisplay.Text = "New game started!\n Please enter an interger between 1 to 100 ";
                            myGame.newGame();

                            lblGuessAnswer.Text = Convert.ToString(myGame.getCount());
                            lblWinAnswer.Text = Convert.ToString(myGame.storeWin());
                            lblLoserAnswer.Text = Convert.ToString(myGame.storeLose());
                        }
                        else
                        {
                            txtUserEntry.Text = "";
                            //myGame.reset();

                            lblGuessAnswer.Text = Convert.ToString(myGame.getCount());
                            lblWinAnswer.Text = Convert.ToString(myGame.storeWin());
                            lblLoserAnswer.Text = Convert.ToString(myGame.storeLose());
                        }
                    }
                    else if (returnNumber == -1)
                    {
                        lblDisplay.Text = "The number is too small.";
                    }
                    else if (returnNumber == 1)
                    {
                        lblDisplay.Text = "The number is too big";
                    }
                    else
                    {
                        lblDisplay.Text = "You lose the game!";

                        DialogResult answer = MessageBox.Show("You want to start a new game?" , "",MessageBoxButtons.YesNo);

                        if (answer == DialogResult.Yes)
                        {
                            txtUserEntry.Text = "";
                            lblDisplay.Text = "New game started!\n Please enter an interger between 1 to 100 ";
                            myGame.newGame();

                            lblGuessAnswer.Text = Convert.ToString(myGame.getCount());
                            lblWinAnswer.Text = Convert.ToString(myGame.storeWin());
                            lblLoserAnswer.Text = Convert.ToString(myGame.storeLose());
                        }
                        else
                        {
                            txtUserEntry.Text = "";
                            //myGame.reset();

                            lblGuessAnswer.Text = Convert.ToString(myGame.getCount());
                            lblWinAnswer.Text = Convert.ToString(myGame.storeWin());
                            lblLoserAnswer.Text = Convert.ToString(myGame.storeLose());
                        }

                    } 
            }
            else
            {
                MessageBox.Show("Please enter an interger.");
            }
        }


        private void btnCheat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The number is : " + Convert.ToString(myGame.returnRandom()));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            myGame.newGame();
            myGame.reset();

            txtUserEntry.Text = "";
            lblDisplay.Text = "Guess a number from 1 to 100.";

            string countNumber = Convert.ToString(myGame.getCount());
            string winNumber = Convert.ToString(myGame.storeWin());
            string loseNumber = Convert.ToString(myGame.storeLose());

            lblGuessAnswer.Text = countNumber;
            lblWinAnswer.Text = winNumber;
            lblLoserAnswer.Text = loseNumber;
        }



        //private void btnCheckInfo_Click(object sender, EventArgs e)
        //{
            
        //    int count = myGame.getCount();
        //    int win = myGame.storeWin();
        //    int lose = myGame.storeLose();


        //    if (count == 1)
        //    {
        //        MessageBox.Show("You have only " + count + " guess left for this round!\nTotal Win: "
        //            + win + "\nTotal Lose: " + lose);
        //    }
        //    else
        //    {
        //        MessageBox.Show("You have " + count + " guesses left for this round.\nTotal Win: "
        //            + win + "\nTotal Lose: " + lose);
        //    }
        //}



    }
}
