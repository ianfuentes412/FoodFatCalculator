using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Program accepts 2 number inputs from the user then outputs the percentage between the 2 numbers. Use can tick a checkbox to output if the product is "low fat"
namespace FatPercentCalc
{
    public partial class FatPercentageCalculator : Form
    {
        public FatPercentageCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                // Resets the Label that prints the results
                CheckLowFatL.Text = " ";
                // gramsFat stores the weight of fat before conversion, gramsTotal holds the food's total amount of calories and gramsCal holds the amount of fat converted into calories
                double gramsCal = 0;
                double gramsTotal = 0;
                double gramsFat = 0;
                // Boolean that turns true if the inputs fit within the parameters of the program
                bool validInput = false;

            // Checks if the input can be parsed into a double
            if (double.TryParse(TotalGrams.Text, out gramsTotal) && double.TryParse(FatGrams.Text, out gramsFat))
            {
                //Converts the weight of fat into grams
                gramsCal = gramsFat * 9;

                //Checks the values if valid
                validInput = CheckInputs(gramsCal, gramsTotal);

                if (validInput == true)
                {
                    //Displays the fat percentage of the food
                    CalcAndDisplayOutput(gramsCal, gramsTotal);
                }
            }
            else
                {
                //Appears when user dosent enter a number in either of the textboxes
                MessageBox.Show("Error: Only numbers are accepted");
                }
        }


        private bool CheckInputs(double gramsCal, double gramsTotal)
        {

            //if statements display an error message if either value is less than or equal to zero
            if (gramsTotal <= 0)
            {
                MessageBox.Show("Error: Total Calories cannot be equal or less than zero");
                return false;
            }
            //It is specified which value is less than or equal to zero as per textbook instructions
            else if (gramsCal <= 0)
            {
                MessageBox.Show("Error: Fat cannot be equal or less than zero");
                return false;
            }

            //The Calories in fat cannot be more than the total calories of the product
            else if (gramsCal > gramsTotal)
            {
                MessageBox.Show("Error: Fat cannot have more calories than the total");
                return false;
            }
            else
            {
                //The rest of the program will only continue when input passes all if statements
                return true;
            }
        }

        private void CalcAndDisplayOutput(double gramsCal, double gramsTotal)
        {
            const int hundred = 100;
            const int lowfat = 30;
            
            //Converts the ratio of fat and total calories into a percentage
            double percentages = gramsCal / gramsTotal * hundred;
            //Displays the percentage in a label
            outputLabel.Text = Convert.ToString(percentages) + "%";

            //Checks if the checkbox is checked
            if (FatCheck.Checked == true)
            {
                //Checks if the calculated percent is lesser or equal to 30
                if (percentages <= lowfat)
                {
                    //Displays message in a anonther label
                    CheckLowFatL.Text = "The product is low fat.";
                }

                else
                {
                    
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
