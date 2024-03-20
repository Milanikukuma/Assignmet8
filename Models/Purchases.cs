using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGear.Models
{
    public class Purchases
    {
        public int PurchaseId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
