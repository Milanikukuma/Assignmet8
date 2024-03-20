using SQLite;

namespace GymGear.Models
{
    public class Equipments
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsInCart { get; set; } // Add the IsInCart property

        public Equipments() { }

        public Equipments(string name, decimal price)
        {
            Name = name;
            Price = price;
            IsInCart = false; // Initialize IsInCart to false by default
        }
    }
}
