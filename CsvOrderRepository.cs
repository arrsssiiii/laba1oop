using System;
using System.Collections.Generic;
using System.IO;

public class CsvOrderRepository : IOrderRepository
{
    private string filePath;

    public CsvOrderRepository(string path)
    {
        filePath = path;

        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
    }

    public void Add(Order order)
    {
        string line = order.Id + "," + order.ProductName + "," + order.Quantity;
        File.AppendAllLines(filePath, new string[] { line });
    }

    public List<Order> GetAll()
    {
        List<Order> orders = new List<Order>();
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            if (line.Trim() == "")
                continue;

            string[] parts = line.Split(',');

            int id = Convert.ToInt32(parts[0]);
            string productName = parts[1];
            int quantity = Convert.ToInt32(parts[2]);

            Order order = new Order(id, productName, quantity);
            orders.Add(order);
        }

        return orders;
    }
}