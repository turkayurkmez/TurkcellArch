using DDDElements.ValueObjects;

namespace DDDElements.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Money Money { get; set; }
    }
}
