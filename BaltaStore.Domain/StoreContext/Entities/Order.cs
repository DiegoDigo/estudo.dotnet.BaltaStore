using System;
using System.Collections.Generic;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Order
    {
        public Customer customer { get; set; }
        public string Number { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }
        public IList<OrderItem> Itens { get; set; }
        public IList<Delivery> Deliveries { get; set; }


        public void Place() { }

    }
}
