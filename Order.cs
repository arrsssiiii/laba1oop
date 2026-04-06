public class Order
{
    public int Id { get; }
    public string ProductName { get; }
    public int Quantity { get; }

    public Order(int id, string productName, int quantity)
    {
        Id = id;
        ProductName = productName;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return Id + " | " + ProductName + " | " + Quantity;
    }
}