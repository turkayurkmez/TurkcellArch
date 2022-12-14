using DDDElements.Entities;

namespace DDDElements.Aggregates
{
    public class Order
    {
        public Customer Customer { get; set; }
        private List<Product> orderLines = new List<Product>();

        public void AddProductToOrder(Product product)
        {
            orderLines.Add(product);
        }
    }
}
