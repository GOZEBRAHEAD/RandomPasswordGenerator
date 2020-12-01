using System;
using System.Text;
using System.Windows.Forms;

namespace RandomPasswordGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private const String passwordNumbers = "0123456789";
        private const String passwordLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const String passwordSpecials = "#$&!*+";

        private int numbersLength = (passwordNumbers.Length - 1);
        private int lettersLength = (passwordLetters.Length - 1);
        private int specialsLength = (passwordSpecials.Length - 1);

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (txt_TotalCombinations.Text.Trim() == "") {

                MessageBox.Show("Please, write something before generate a random password.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int totalNum = 0;

            if (!int.TryParse(txt_TotalCombinations.Text, out totalNum)) {

                MessageBox.Show("The password length should be only numbers.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (totalNum < 1 || totalNum > 10) {

                MessageBox.Show("The password length should be between 1 and 10 characters.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            StringBuilder newPassword = new StringBuilder();

            int i = 0;

            char randomNumber, randomLetter, randomSpecial;

            Random random = new Random();

            while (i < totalNum) {

                randomNumber = passwordNumbers[random.Next(0, numbersLength)];

                randomLetter = passwordLetters[random.Next(0, lettersLength)];

                randomSpecial = passwordSpecials[random.Next(0, specialsLength)];

                newPassword.Append(randomNumber);
                newPassword.Append(randomLetter);
                newPassword.Append(randomSpecial);

                i++;
            }

            txt_RandomPassword.Text = newPassword.ToString();

            return;
        }
    }
}
