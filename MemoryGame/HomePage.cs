using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class HomePage : Form
    {
        
        public HomePage(string n)
        {
            InitializeComponent();
            txtPlayerName.Text = n;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Ask the user if they want to exit the game
            DialogResult result = MessageBox.Show("Are you sure you want to exit the game?", "Exit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicked the "Yes" button, exit the application with exit code 0
            if (result == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(0);
            }
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            // Create an object of type GameArea

            GameArea gameArea = new GameArea(txtPlayerName.Text);
            this.Hide(); // Hides the current form
            gameArea.ShowDialog(); // Shows the next form
            this.Close(); // Closes the current form

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Memory Game!\n" +
                       "\nThis game is designed to test your memory and concentration skills. " +
                       "Your goal is to match pairs of cards with the same pictures on them. The more cards you match, the higher your score will be.\n" +
                       "\nTo play the game, simply click on two cards to flip them over. If the cards match, they will stay face up. If they don't match, they will flip back over and you can try again. " +
                       "Keep playing until you match all the cards on the board.\n\nBut be careful, the cards will be shuffled each time, so you'll need to remember the position of each card to make the best matches.\n" +
                       "\nGood luck, and have fun!", "Memory Game Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
