using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GymGear.Models;


namespace GymGear.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Equipments> _equipments;
        public ObservableCollection<Equipments> Equipments
        {
            get { return _equipments; }
            set
            {
                _equipments = value;
                OnPropertyChanged();
            }
        }

        private Cart _cart;
        public Cart Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddToCartCommand { get; }

        public MainPageViewModel()
        {
            Equipments = new ObservableCollection<Equipments>(GetEquipmentsFromDatabase());
            Cart = new Cart();
            AddToCartCommand = new Command<Equipments>(AddToCart);
        }

        private List<Equipments> GetEquipmentsFromDatabase()
        {
            return new List<Equipments>
            {
                new Equipments("Treadmill", 2000),
                new Equipments("Dumbbells", 500),
                new Equipments("Bench Press", 1000),
                new Equipments("Stationary Bike", 1500),
                new Equipments("Leg Press Machine", 1800),
                new Equipments("Pull-up Bar", 600),
                new Equipments("Rowing Machine", 1700),
                new Equipments("Barbell", 800),
                new Equipments("Elliptical Trainer", 1900),
                new Equipments("Cable Machine", 1200),
                new Equipments("Smith Machine", 1400),
                new Equipments("Kettlebells", 700),
                new Equipments("Medicine Ball", 300),
                new Equipments("Resistance Bands", 400),
                new Equipments("Ab Roller", 450),
                new Equipments("Jump Rope", 200),
                new Equipments("Battle Ropes", 850),
                new Equipments("Punching Bag", 1300),
                new Equipments("TRX Suspension Trainer", 1600),
                new Equipments("Yoga Mat", 250)
            };
        }

        private void AddToCart(Equipments equipment)
        {
            Cart.AddToCart(equipment);
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
