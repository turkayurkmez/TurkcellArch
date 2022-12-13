/*
 * Bir nesne gelişime AÇIK değişime KAPALI olmalı
 * 
 * 
 
 */

Customer customer = new Customer { CustomerInfo = new Plus5Year() };
Order order = new Order { Customer = customer };

order.GetDiscountedPrice(1000);

public class CustomerInfo
{
    public int RegisteredYear { get; set; }
    public virtual decimal GetDiscountForRegisteredYear(decimal price)
    {
        var totalYear = DateTime.Now.Year - RegisteredYear;
        if (totalYear < 2)
        {
            return price * .95m;
        }
        return price;
    }
}

public class Plus5Year : CustomerInfo
{
    public override decimal GetDiscountForRegisteredYear(decimal price)
    {
        var totalYear = DateTime.Now.Year - RegisteredYear;
        if (totalYear > 5)
        {
            return price * .5m;
        }
        return base.GetDiscountForRegisteredYear(price);
    }

}

public class Customer
{
    public CustomerInfo CustomerInfo { get; set; }
}
public class Order
{
    public Customer Customer { get; set; }
    public decimal GetDiscountedPrice(decimal price)
    {
        /*
         * 1 yıl %5
         * 3     %10
         * 5     %15
         */
        return Customer.CustomerInfo.GetDiscountForRegisteredYear(price);
    }
}

