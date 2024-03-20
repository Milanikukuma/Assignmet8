using GymGear.Models;
using GymGear.ViewModels;


namespace GymGear
{
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            BindingContext = new CartPageViewModel();
        }
    }
}
