using System.Collections.ObjectModel;
using GymGear.Models;

namespace GymGear
{
    public class Cart
    {
        public ObservableCollection<Equipments> Items { get; }

        public Cart()
        {
            Items = new ObservableCollection<Equipments>();
        }

        public void AddToCart(Equipments equipment)
        {
            Items.Add(equipment);
        }

        public void RemoveFromCart(Equipments equipment)
        {
            Items.Remove(equipment);
        }
    }
}
