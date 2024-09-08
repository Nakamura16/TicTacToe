
using System.Security.Cryptography.Xml;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private const string defauntButtonIcon = "?";
        private const char cross = 'X';
        private const char circle = 'O';

        private char currentPlayer = circle; 

        private int playerOneNumberOfWins;
        private int playerTwoNumberOfWins;

        public Form1()
        {
            InitializeComponent();
        }

        private void PlayerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (currentPlayer is circle)
            {
                PlayerOnePlays(button);
            }
            else 
            {
                PlayerTwoPlays(button);
            }

            CheckGame();
            NextTurn();
        }

        private void CheckGame()
        {

        }

        private void NextTurn()
        {
            if (currentPlayer == circle)
            {
                currentPlayer = cross;
            }
            else 
            {
                currentPlayer = circle;
            }
        }

        private void RestartGame(object sender, EventArgs e)
        {
            var buttons = GetAllButtons();
            foreach (var button in buttons)
            {
                button.Enabled = true;
                button.BackColor = default;
                button.Text = defauntButtonIcon;
            }
        }

        private void PlayerOnePlays(Button button)
        {
            button.Enabled = false;
            button.Text = currentPlayer.ToString();
            button.BackColor = Color.LightBlue;
        }

        private void PlayerTwoPlays(Button button)
        {
            button.Enabled = false;
            button.Text = currentPlayer.ToString();
            button.BackColor = Color.LightGoldenrodYellow;
        }

        private IReadOnlyList<Button> GetAllButtons()
        {
            return new List<Button>()
            {
                button1, 
                button2, 
                button3,
                button4, 
                button5, 
                button6,
                button7,
                button8,
                button9
            };
        }
    }
}
