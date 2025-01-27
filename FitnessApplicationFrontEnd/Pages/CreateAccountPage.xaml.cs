using Microsoft.Maui.Controls;

namespace FitnessApplicationFrontEnd.Pages
{
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void OnSignUpClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            // Basic validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                ErrorLabel.Text = "Please fill out all fields.";
                ErrorLabel.IsVisible = true;
            }
            else if (password != confirmPassword)
            {
                ErrorLabel.Text = "Passwords do not match.";
                ErrorLabel.IsVisible = true;
            }
            else
            {
                // Proceed with sign-up (e.g., save data or call an API)
                ErrorLabel.IsVisible = false;
                // Navigate to another page or display success
                DisplayAlert("Success", "Account created successfully!", "OK");
            }
        }
    }
}