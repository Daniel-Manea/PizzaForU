using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForU.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulFilled { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> OrdersDetails { get; set; }
    }
}
