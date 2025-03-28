// HealthSurveyForm.cs
using System;
using System.Windows.Forms;
using System.Text;

namespace HealthSurveyApp
{
    public partial class HealthSurveyForm : Form
    {
        public HealthSurveyForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || 
                string.IsNullOrWhiteSpace(txtLastName.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in required fields (Name, Email).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate birthdate
            if (dtpBirthdate.Value > DateTime.Today)
            {
                MessageBox.Show("Please select a valid birthdate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate BMI fields
            if (string.IsNullOrWhiteSpace(txtCurrentBMI.Text) || !double.TryParse(txtCurrentBMI.Text, out _))
            {
                MessageBox.Show("Please enter a valid BMI value for Current BMI.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTargetBMI.Text) || !double.TryParse(txtTargetBMI.Text, out _))
            {
                MessageBox.Show("Please enter a valid BMI value for Target BMI.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate summary of submitted data
            StringBuilder summary = new StringBuilder();
            summary.AppendLine("Health Survey Submission Summary");
            summary.AppendLine("-----------------------------");
            
            // Personal Information
            summary.AppendLine($"Name: {txtFirstName.Text} {txtLastName.Text}");
            summary.AppendLine($"Email: {txtEmail.Text}");
            summary.AppendLine($"Phone: {txtPhone.Text}");
            summary.AppendLine($"Address: {txtAddress.Text}");
            summary.AppendLine($"Birthdate: {dtpBirthdate.Value.ToShortDateString()}");
            summary.AppendLine($"Age: {CalculateAge(dtpBirthdate.Value)}");
            summary.AppendLine($"Gender: {cboGender.SelectedItem}");

            // Medical Information
            summary.AppendLine("\nMedical Conditions:");
            foreach (var item in chkMedicalConditions.CheckedItems)
            {
                summary.AppendLine($"- {item}");
            }

            summary.AppendLine("\nMedications:");
            foreach (var item in chkMedications.CheckedItems)
            {
                summary.AppendLine($"- {item}");
            }

            summary.AppendLine($"\nNursing: {(rbNursingYes.Checked ? "Yes" : "No")}");
            summary.AppendLine($"Food Allergies: {(rbFoodAllergiesYes.Checked ? "Yes" : "No")}");

            // BMI Information
            summary.AppendLine($"\nHeight: {txtHeight.Text}");
            summary.AppendLine($"Weight: {txtWeight.Text}");
            summary.AppendLine($"Current BMI: {txtCurrentBMI.Text}");
            summary.AppendLine($"Target BMI: {txtTargetBMI.Text}");

            // Sleep Information
            summary.AppendLine($"\nBedtime: {txtBedtime.Text}");
            summary.AppendLine($"Wake-up Time: {txtWakeUpTime.Text}");
            summary.AppendLine($"Sleep Hours: {txtSleepHours.Text}");
            summary.AppendLine($"Feeling Rested: {(rbRestedYes.Checked ? "Yes" : "No")}");
            summary.AppendLine($"Sleep Quality: {txtSleepQuality.Text}");

            // Stress Information
            summary.AppendLine($"\nWork: {txtWork.Text}");
            summary.AppendLine($"Enjoys Work: {(rbEnjoyWorkYes.Checked ? "Yes" : "No")}");
            summary.AppendLine($"Other Stress: {txtOtherStress.Text}");
            summary.AppendLine($"Stress Level: {trackStressLevel.Value}");

            // Eating Habits
            summary.AppendLine($"\nFirst Meal: {txtFirstMeal.Text}");
            summary.AppendLine($"Last Meal: {txtLastMeal.Text}");
            summary.AppendLine($"Meals Per Day: {txtMealsPerDay.Text}");
            summary.AppendLine($"Snacking: {txtSnacks.Text}");
            summary.AppendLine($"Eating Out Frequency: {cboEatingOut.SelectedItem}");

            // Weight and Exercise
            summary.AppendLine($"\nCurrent Weight: {txtCurrentWeight.Text}");
            summary.AppendLine($"Goal Weight: {txtGoalWeight.Text}");
            summary.AppendLine($"Previous Weight Loss Attempts: {(rbWeightLossYes.Checked ? "Yes" : "No")}");
            summary.AppendLine($"Weight Loss Challenges: {txtWeightLossChallenges.Text}");
            summary.AppendLine($"Smoking: {cboSmoking.SelectedItem}");
            summary.AppendLine($"Exercise Frequency: {cboExercise.SelectedItem}");
            summary.AppendLine($"Sleep Duration: {cboSleepDuration.SelectedItem}");

            // Display summary
            MessageBox.Show(summary.ToString(), "Survey Submission Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int CalculateAge(DateTime birthdate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
