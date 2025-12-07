using System;
using System.Collections.Generic;
using System.Linq;

namespace project_mvc.Models
{
    public class CartItemViewModel
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }

        public decimal Subtotal => Price * Quantity;
    }

    public class CartViewModel
    {
        public CartViewModel()
        {
            Items = new List<CartItemViewModel>();
        }

        public IList<CartItemViewModel> Items { get; set; }
        public DateTime? LastUpdated { get; set; }

        public decimal Total => Items?.Sum(i => i.Subtotal) ?? 0;
        public int TotalQuantity => Items?.Sum(i => i.Quantity) ?? 0;
    }
}
