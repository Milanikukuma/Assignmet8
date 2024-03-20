using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GymGear.Models;
using GymGear.Services;

namespace GymGear.ViewModels
{
    public class CartPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Equipments> _cartItems;
        public ObservableCollection<Equipments> CartItems
        {
            get { return _cartItems; }
            set
            {
                _cartItems = value;
                OnPropertyChanged();
            }
        }

        public CartPageViewModel()
        {
            // Initialize the CartItems collection
            CartItems = new ObservableCollection<Equipments>();

            // Populate the collection with items from the cart
            PopulateCartItems();
        }
        private void PopulateCartItems()
        {
            // Assuming you have a reference to your database class EquipmentDatabase
            var database = new EquipmentDatabase("path_to_your_database_file");

            // Retrieve the cart items from the database
            var cartItems = database.GetCartItems();

            // Clear the existing items in the collection
            CartItems.Clear();

            // Add the retrieved cart items to the CartItems collection
            foreach (var item in cartItems)
            {
                CartItems.Add((Equipments)item);
            }
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
