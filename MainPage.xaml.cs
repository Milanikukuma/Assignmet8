using GymGear.Models;
using GymGear.ViewModels;

namespace GymGear
{
    public partial class MainPage : ContentPage
    {
        // Define a property to hold the currently selected equipment
        private Equipments currentEquipment;

        public MainPage()
        {
            InitializeComponent();

            var viewModel = new MainPageViewModel();
            BindingContext = viewModel;
        }

        private void OnEquipmentItemSelected(object sender, EventArgs e)
        {
            // Assuming sender is the control (e.g., ListView) that triggered the event
            var selectedEquipment = ((ListView)sender).SelectedItem as Equipments;

            // Set the currentEquipment variable to the selected equipment
            currentEquipment = selectedEquipment;
        }

        private async void OnOptionsButtonClicked(object sender, EventArgs e)
        {
            string selectedAction = await DisplayActionSheet("Choose Action", "Cancel", null, "Add to Cart", "Purchase");

            if (selectedAction == "Add to Cart")
            {
                var cart = new Cart();
                cart.AddToCart(currentEquipment);
                await DisplayAlert("Success", "Item added to cart.", "OK");

                // Navigate to the cart page
                await Navigation.PushAsync(new CartPage());
            }
            else if (selectedAction == "Purchase")
            {
                await Navigation.PushAsync(new ProfilePage());
            }
        }
    }
}
