using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderModel
    {
        public int order_id { get; set; }

        public int customer_id { get; set;}

        public DateTime order_date { get; set; }

        public decimal total_amount { get; set; }
    }
}
