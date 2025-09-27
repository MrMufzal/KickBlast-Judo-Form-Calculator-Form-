using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using System.Configuration;
namespace KickBlast_Judo_Form //sources
{
    public partial class Judo_form : Form
    {
        public Judo_form()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Checking for empty fields
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the athlete's name.");
                return;
            }

            if (cmbPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a training plan.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Please enter the current weight.");
                return;
            }
            string name = txtName.Text;
            string? plan = cmbPlan.SelectedItem?.ToString();
            double weight;
            if (!double.TryParse(txtWeight.Text, out weight))
            {
                MessageBox.Show("Please enter a valid weight.");
                return;
            }

            int competitions = (int)numCompetitions.Value;
            int privateHours = (int)numPrivate.Value;
            if (privateHours > 5)
            {
                MessageBox.Show("Private coaching cannot exceed 5 hours per week.");
                return;
            }

            if (plan == "Beginner")
            {
                competitions = 0;
            }

            // Pricing
            double weeklyFee = plan switch
            {
                "Beginner" => 250.0,
                "Intermediate" => 300.0,
                "Advanced" => 350.0,
                _ => 0
            };
            double monthlyFee = weeklyFee * 4;
            double coachingCost = privateHours * 90.50 * 4;
            double competitionCost = competitions * 220.00;
            double total = monthlyFee + coachingCost + competitionCost;

            // Weight Category
            string category = "";
            double categoryLimit = 0;
            if (weight > 100) { category = "Heavyweight"; categoryLimit = weight; }
            else if (weight > 90) { category = "Light-Heavyweight"; categoryLimit = 100; }
            else if (weight > 81) { category = "Middleweight"; categoryLimit = 90; }
            else if (weight > 73) { category = "Light-Middleweight"; categoryLimit = 81; }
            else if (weight > 66) { category = "Lightweight"; categoryLimit = 73; }
            else { category = "Flyweight"; categoryLimit = 66; }

            double difference = weight - categoryLimit;
            string weightMsg = difference == 0 ? $"At competition weight ({category})." :
                difference > 0 ? $"Over by {difference:0.00} kg ({category})." :
                $"Under by {Math.Abs(difference):0.00} kg ({category}).";

            string eligibilityMsg = plan switch
            {
                "Beginner" => "Unfortunately, you are unable to enter this monthly competition.",
                "Intermediate" or "Advanced" => "You are eligible to enter this monthly competition.",
                _ => ""
            };

            // Output text
            string resultText = $"Athlete: {name}\r\n" +
                                $"Training Plan: {plan} (Rs. {monthlyFee:0.00})\r\n" +
                                $"Private Coaching: Rs. {coachingCost:0.00}\r\n" +
                                $"Competition Cost: Rs. {competitionCost:0.00}\r\n" +
                                $"Total Monthly Cost: Rs. {total:0.00}\r\n" +
                                $"Weight Category: {category}\r\n" +
                                $"{weightMsg}\r\n\r\n" +
                                $"{eligibilityMsg}";


            // Show the result in a new popup window
            ResultForm resultForm = new ResultForm(resultText);
            resultForm.ShowDialog();
           
            // Saving to database
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["JudoDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Athletes 
                         (Name, [Plan], Weight, WeightCategory, PrivateCoachingHours, Competitions, MonthlyFee, CoachingCost, CompetitionCost, TotalCost, Eligibility)
                         VALUES 
                         (@Name, @Plan, @Weight, @Category, @PrivateHours, @Competitions, @MonthlyFee, @CoachingCost, @CompetitionCost, @Total, @Eligibility)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Plan", plan);
                        cmd.Parameters.AddWithValue("@Weight", weight);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@PrivateHours", privateHours);
                        cmd.Parameters.AddWithValue("@Competitions", competitions);
                        cmd.Parameters.AddWithValue("@MonthlyFee", monthlyFee);
                        cmd.Parameters.AddWithValue("@CoachingCost", coachingCost);
                        cmd.Parameters.AddWithValue("@CompetitionCost", competitionCost);
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@Eligibility", eligibilityMsg);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to database: " + ex.Message);
            }

        }
        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to prevent the user from selecting the number of competitions for the beginner plan
            string? plan = cmbPlan.SelectedItem?.ToString();
            numCompetitions.Enabled = (plan == "Intermediate" || plan == "Advanced");
        }
        

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            // to clean off the form
            txtName.Text = string.Empty;
            cmbPlan.SelectedIndex = -1;
            txtWeight.Text = string.Empty;
            numCompetitions.Value = 0;
            numPrivate.Value = 0;
        }
        ,
        
    }
}
