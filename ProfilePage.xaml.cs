using GymGear.Services;
using GymGear.Models;

namespace GymGear
{
    public partial class ProfilePage : ContentPage
    {
        private EquipmentDatabase _dbconnection;
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void OnContinueClicked(object sender, EventArgs e)
        {
            // Create a new UserProfile object with details from input fields
            UserProfile userProfile = new UserProfile
            {
                Name = NameEntry.Text,
                LastName = LastNameEntry.Text,
                Email = EmailEntry.Text,
                PhoneNumber = PhoneNumberEntry.Text,
                Address = AddressEntry.Text
            };

            // Save the user profile to the database
            _dbconnection.SaveUserProfile(userProfile);

            // Display a message indicating success
            DisplayAlert("Success", "Profile saved successfully! Ready to purchase", "OK");

            // Navigate back to the previous page or any other page as needed
            Navigation.PopAsync(); // Example: Navigate back to the previous page
        }
    }
}
