// HealthSurveyForm.Designer.cs
using System;
using System.Windows.Forms;
using System.Drawing;

namespace HealthSurveyApp
{
    partial class HealthSurveyForm
    {
        private void InitializeComponent()
        {
            // Set form properties
            this.Text = "Health Survey";
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(600, 900);

            // Personal Information Controls
            Label lblFirstName = new Label { Text = "First Name:", Location = new Point(20, 20) };
            txtFirstName = new TextBox { Location = new Point(200, 20), Width = 300 };

            Label lblLastName = new Label { Text = "Last Name:", Location = new Point(20, 60) };
            txtLastName = new TextBox { Location = new Point(200, 60), Width = 300 };

            Label lblEmail = new Label { Text = "Email:", Location = new Point(20, 100) };
            txtEmail = new TextBox { Location = new Point(200, 100), Width = 300 };

            Label lblPhone = new Label { Text = "Phone Number:", Location = new Point(20, 140) };
            txtPhone = new TextBox { Location = new Point(200, 140), Width = 300 };

            Label lblAddress = new Label { Text = "Address:", Location = new Point(20, 180) };
            txtAddress = new TextBox { Location = new Point(200, 180), Width = 300, Multiline = true, Height = 50 };

            Label lblBirthdate = new Label { Text = "Birthdate:", Location = new Point(20, 240) };
            dtpBirthdate = new DateTimePicker { Location = new Point(200, 240), Width = 300 };

            Label lblGender = new Label { Text = "Gender:", Location = new Point(20, 280) };
            cboGender = new ComboBox { 
                Location = new Point(200, 280), 
                Width = 300,
                Items = { "Male", "Female", "Non-Binary", "Prefer Not to Say" }
            };

            // Medical Conditions CheckedListBox
            Label lblMedicalConditions = new Label { 
                Text = "Medical Conditions:", 
                Location = new Point(20, 320) 
            };
            chkMedicalConditions = new CheckedListBox {
                Location = new Point(200, 320),
                Width = 300,
                Items = { 
                    "High Blood Pressure", 
                    "Diabetes - Type 1", 
                    "Diabetes - Type 2", 
                    "Gout" 
                }
            };

            // Medications CheckedListBox
            Label lblMedications = new Label { 
                Text = "Medications:", 
                Location = new Point(20, 420) 
            };
            chkMedications = new CheckedListBox {
                Location = new Point(200, 420),
                Width = 300,
                Items = { 
                    "Diabetes", 
                    "High Blood Pressure", 
                    "High Cholesterol", 
                    "Thyroid", 
                    "Lithium", 
                    "Coumadin (Warfarin)" 
                }
            };

            // Nursing RadioButtons
            Label lblNursing = new Label { Text = "Are you nursing?", Location = new Point(20, 520) };
            rbNursingYes = new RadioButton { 
                Text = "Yes", 
                Location = new Point(200, 520) 
            };
            rbNursingNo = new RadioButton { 
                Text = "No", 
                Location = new Point(300, 520) 
            };

            // Food Allergies RadioButtons
            Label lblFoodAllergies = new Label { 
                Text = "Do you have food allergies?", 
                Location = new Point(20, 560) 
            };
            rbFoodAllergiesYes = new RadioButton { 
                Text = "Yes", 
                Location = new Point(200, 560) 
            };
            rbFoodAllergiesNo = new RadioButton { 
                Text = "No", 
                Location = new Point(300, 560) 
            };

            // Sleep Information
            Label lblSleepBedtime = new Label { Text = "Bedtime:", Location = new Point(20, 600) };
            txtBedtime = new TextBox { Location = new Point(200, 600), Width = 300 };

            Label lblSleepWakeUp = new Label { Text = "Wake-up Time:", Location = new Point(20, 640) };
            txtWakeUpTime = new TextBox { Location = new Point(200, 640), Width = 300 };

            Label lblSleepHours = new Label { Text = "Sleep Hours:", Location = new Point(20, 680) };
            txtSleepHours = new TextBox { Location = new Point(200, 680), Width = 300 };

            Label lblFeelingRested = new Label { Text = "Do you wake up feeling rested?", Location = new Point(20, 720) };
            rbRestedYes = new RadioButton { Text = "Yes", Location = new Point(200, 720) };
            rbRestedNo = new RadioButton { Text = "No", Location = new Point(300, 720) };

            Label lblSleepQuality = new Label { Text = "How is the quality of your sleep?", Location = new Point(20, 760) };
            txtSleepQuality = new TextBox { Location = new Point(200, 760), Width = 300 };

            // Stress Information
            Label lblWork = new Label { Text = "What do you do for work?", Location = new Point(20, 800) };
            txtWork = new TextBox { Location = new Point(200, 800), Width = 300 };

            Label lblEnjoyWork = new Label { Text = "Do you enjoy what you do?", Location = new Point(20, 840) };
            rbEnjoyWorkYes = new RadioButton { Text = "Yes", Location = new Point(200, 840) };
            rbEnjoyWorkNo = new RadioButton { Text = "No", Location = new Point(300, 840) };

            Label lblOtherStress = new Label { Text = "Are there any other stress in your life?", Location = new Point(20, 880) };
            txtOtherStress = new TextBox { Location = new Point(200, 880), Width = 300 };

            Label lblStressLevel = new Label { Text = "Rate your overall stress level (1 to 5):", Location = new Point(20, 920) };
            trackStressLevel = new TrackBar { Location = new Point(200, 920), Width = 300, Minimum = 1, Maximum = 5 };

            // Eating Habits
            Label lblFirstMeal = new Label { Text = "First Meal:", Location = new Point(20, 960) };
            txtFirstMeal = new TextBox { Location = new Point(200, 960), Width = 300 };

            Label lblLastMeal = new Label { Text = "Last Meal:", Location = new Point(20, 1000) };
            txtLastMeal = new TextBox { Location = new Point(200, 1000), Width = 300 };

            Label lblMealsPerDay = new Label { Text = "Meals Per Day:", Location = new Point(20, 1040) };
            txtMealsPerDay = new TextBox { Location = new Point(200, 1040), Width = 300 };

            Label lblSnacks = new Label { Text = "Do you snack? If yes, what?", Location = new Point(20, 1080) };
            txtSnacks = new TextBox { Location = new Point(200, 1080), Width = 300 };

            Label lblEatingOut = new Label { Text = "Eating Out Frequency:", Location = new Point(20, 1120) };
            cboEatingOut = new ComboBox { 
                Location = new Point(200, 1120), 
                Width = 300, 
                Items = { "Always", "Usually", "Sometimes", "Rarely", "Never", "Other" }
            };

            // Weight and Exercise
            Label lblCurrentWeight = new Label { Text = "Current Weight:", Location = new Point(20, 1160) };
            txtCurrentWeight = new TextBox { Location = new Point(200, 1160), Width = 300 };

            Label lblGoalWeight = new Label { Text = "Goal Weight:", Location = new Point(20, 1200) };
            txtGoalWeight = new TextBox { Location = new Point(200, 1200), Width = 300 };

            Label lblWeightLossAttempts = new Label { Text = "Have you tried to lose weight before?", Location = new Point(20, 1240) };
            rbWeightLossYes = new RadioButton { Text = "Yes", Location = new Point(200, 1240) };
            rbWeightLossNo = new RadioButton { Text = "No", Location = new Point(300, 1240) };

            Label lblWeightLossChallenges = new Label { Text = "What has been difficult about losing weight?", Location = new Point(20, 1280) };
            txtWeightLossChallenges = new TextBox { Location = new Point(200, 1280), Width = 300 };

            Label lblSmoking = new Label { Text = "Do you smoke?", Location = new Point(20, 1320) };
            cboSmoking = new ComboBox { 
                Location = new Point(200, 1320), 
                Width = 300, 
                Items = { "1 Pack/day", "2 Packs/day", "+3 Packs/day", "No" }
            };

            Label lblExercise = new Label { Text = "Do you do any exercise?", Location = new Point(20, 1360) };
            cboExercise = new ComboBox { 
                Location = new Point(200, 1360), 
                Width = 300, 
                Items = { "1-3 a week", "3-5 a week", "Everyday", "Never" }
            };

            Label lblSleepDuration = new Label { Text = "How many hours do you sleep?", Location = new Point(20, 1400) };
            cboSleepDuration = new ComboBox { 
                Location = new Point(200, 1400), 
                Width = 300, 
                Items = { "Less than 5 hours", "5-6 hours", "7-8 hours", "9-10 hours", "More than 10 hours" }
            };

            // Submit Button
            btnSubmit = new Button {
                Text = "Submit Survey", 
                Location = new Point(200, 1440), 
                Width = 300
            };
            btnSubmit.Click += btnSubmit_Click;

            // Add controls to form
            this.Controls.AddRange(new Control[] {
                // Add all the controls here...
                btnSubmit
            });
        }

        // Declare controls as private fields
        private TextBox txtFirstName, txtLastName, txtEmail, txtPhone, txtAddress, txtBedtime, txtWakeUpTime, txtSleepHours,
                       txtSleepQuality, txtWork, txtOtherStress, txtFirstMeal, txtLastMeal, txtMealsPerDay, txtSnacks, 
                       txtCurrentWeight, txtGoalWeight, txtWeightLossChallenges;
        private DateTimePicker dtpBirthdate;
        private ComboBox cboGender, cboEatingOut, cboSmoking, cboExercise, cboSleepDuration;
        private RadioButton rbNursingYes, rbNursingNo, rbFoodAllergiesYes, rbFoodAllergiesNo, rbRestedYes, rbRestedNo, 
                           rbEnjoyWorkYes, rbEnjoyWorkNo, rbWeightLossYes, rbWeightLossNo;
        private CheckedListBox chkMedicalConditions, chkMedications;
        private TrackBar trackStressLevel;
        private Button btnSubmit;
    }
}
