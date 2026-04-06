using System.Collections.Generic;

public interface IOrderRepository
{
    void Add(Order order);
    List<Order> GetAll();
}