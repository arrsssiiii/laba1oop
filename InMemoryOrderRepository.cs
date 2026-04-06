using System.Collections.Generic;

public class InMemoryOrderRepository : IOrderRepository
{
    private List<Order> orders = new List<Order>();

    public void Add(Order order)
    {
        orders.Add(order);
    }

    public List<Order> GetAll()
    {
        return new List<Order>(orders);
    }
}