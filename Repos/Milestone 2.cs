public class InventoryItem
{
    private static int lastAssignedId = 0;

    private int id;
    private string name;
    private int quantity;
    private float price;

    public int Id
    {
        get { return id; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public float Price
    {
        get { return price; }
        set { price = value; }
    }

    public InventoryItem()
    {
        lastAssignedId++;
        id = lastAssignedId;
    }
}

class Program
{
    static void Main(string[] args)
    {
        InventoryItem item = new InventoryItem();

        item.Name = "Nike Dunk Low's";
        item.Quantity = 10;
        item.Price = 145.00f;

        Console.WriteLine("Item Details:");
        Console.WriteLine("ID: " + item.Id);
        Console.WriteLine("Name: " + item.Name);
        Console.WriteLine("Quantity: " + item.Quantity);
        Console.WriteLine("Price: " + item.Price);

        Console.ReadLine();
    }
}