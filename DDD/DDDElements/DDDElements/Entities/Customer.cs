using DDDElements.ValueObjects;

namespace DDDElements.Entities
{
    public class Customer
    {
        private string name;
        public int Id { get; set; }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public Address Address { get; set; }

    }
}
