using System;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class OrderItem
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = quantity * product.Price;
        }

        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Product.Title}";
        }
    }
}
