using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeShop.Shared.Models
{
    public class Order
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
    }

    public class OrderDto
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal UnitPrice { get; set; }
        public int CountPerItem { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal TotalPricePerItem { get; set; }
        public string ItemName { get; set; }
    }
}
