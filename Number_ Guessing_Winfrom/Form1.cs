namespace WinFormApp
{
    public partial class Form1 : Form
    {
        Random randNumber;
        int secretNumber;
        int life;
        int score;
        public Form1()
        {
            InitializeComponent();
            randNumber = new();
            
            StartGame();
        }

        public void StartGame()
        {
            secretNumber = randNumber.Next(1, 101);
            MessageBox.Show($"{secretNumber}");
            life = 5;
            
            txtInput.Clear();
            lblResult.Text = "";
            lblLife.Text = "";
            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {

            int userGuess;
            if (!int.TryParse(txtInput.Text, out userGuess))
            {
                lblResult.Text = "Please enter a valid number!";
                return;
            }



            if (userGuess > secretNumber)
            {
                lblResult.Text = "High";
                life -= 1;
            }
            else if (userGuess < secretNumber)
            {
                lblResult.Text = "low";
                life -= 1;
            }
            else
            {
                lblResult.Text = "Correct 👏";
                txtInput.ReadOnly = true;
                score += 1;
                lblScore.Text = $"{score}";

                string message = "You won 👏 \n Try again";
                MessageBox.Show(message);
                ResetGame();
                StartGame();

            }
            if (life == 0)
            {
                lblResult.Text = "Game Over";
                txtInput.ReadOnly = true;
                btnInput.Enabled = false;
                ResetGame();
                

               
            }
            else if(life == 1)
            {
                string message = "Last Chance";
                MessageBox.Show(message);
            }

                lblLife.Text = $"{life}";


        }

        public void ResetGame()
        {
            txtInput.ReadOnly = false;
            lblResult.Text = "Let us Start";
            lblLife.Text = $"{life}";
            btnInput.Enabled = true;
        }

        private void brnReset_Click(object sender, EventArgs e)
        {
            StartGame();
            ResetGame();
        }
    }
}
