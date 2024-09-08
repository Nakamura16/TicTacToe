using TicTacToe.Model;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Player player1;
        private Player player2;
        private int PlayerOneNumberOfWins;
        private int PlayerTwoNumberOfWins;

        public Form1()
        {
            InitializeComponent();
        }

        private void PlayerClick(object sender, EventArgs e)
        {
            var button = (Button) sender;

            button.Enabled = false;
            button.Text = "X";
            button.BackColor = Color.Blue;

            CheckGame();
        }

        private void CheckGame()
        {

        }
    }
}
