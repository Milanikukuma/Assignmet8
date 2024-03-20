using SQLite;
using SQLiteNetExtensions.Attributes;

namespace GymGear.Models
{
    public class UserProfile
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Purchases> Purchases { get; set; } // Corrected class name to Purchases

        
    }
}
