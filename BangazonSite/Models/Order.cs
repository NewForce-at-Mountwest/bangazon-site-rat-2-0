using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonSite.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int PaymentTypeId { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
        public PaymentType PaymentType { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

    }
}
