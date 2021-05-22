using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessDLL;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int leftInterval;
        private int rightInterval;
        private bool isFound = false;
        private bool gameStarted = false;
        private int randomNumber;
        


        public Form1()
        {
            InitializeComponent();
        }



        private void lessThanButton_Click(object sender, EventArgs e)
        {
            
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (rightIntervallBox.Text != "" && leftIntervallBox.Text != "") {
                try
                {
                    rightInterval = int.Parse(rightIntervallBox.Text);
                    leftInterval = int.Parse(leftIntervallBox.Text);
                    randomNumber = random.Next(leftInterval, rightInterval);
                    GameStartGui();

                }
                catch (Exception ex) {
                    
                }
            }
            
        }

        private void greaterThanButton_Click(object sender, EventArgs e)
        {

        }

        private void equalsToButton_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void userGuessLabel_Click(object sender, EventArgs e)
        {

        }

        private void GameStartGui() 
        {
            rightIntervallBox.Visible = false;
            leftIntervallBox.Visible = false;
            startGameButton.Visible = false;
            intervallLabel.Visible = false;
            hyphenLabel.Visible = false;
        }
    }
}
