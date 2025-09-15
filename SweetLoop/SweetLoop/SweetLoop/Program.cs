using System.Text.Json.Nodes;

class Menu
{
    List<Product> menuItems;
    public Menu()
    {
        menuItems = new List<Product>();
    }

    public void AddNewItem(Product newProduct)
    {
        for (int i = 0; i < menuItems.Count; i++)
        {
            if (menuItems[i].ProductName == newProduct.ProductName)
            {
                Console.WriteLine("Product Already exists");
                return;
            }
        }
        menuItems.Add(newProduct);
    }

    public void RemoveItem(int id)
    {
        for (int i = 0; i < menuItems.Count; i++)
        {
            if (menuItems[i].ProductId == id)
            {
                menuItems.Remove(menuItems[i]);
                Console.WriteLine("Product with id " + id + " successfully removed");
                return;
            }
        }

        Console.WriteLine("Product with id " + id + " doesn't exists...");
    }

    public void UpdateItem(int id, string name, int price)
    {
        for (int i = 0; i < menuItems.Count; i++)
        {
            if (menuItems[i].ProductId == id)
            {
                menuItems[i].ProductName = name;
                menuItems[i].ProductPrice = price;

                Console.WriteLine("Product with id " + id + " updated successfully");
                menuItems[i].Display();
                return;
            }
        }
        Console.WriteLine("Product with id " + id + " doesn't exists...");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("\n\n\n\t\t Sweet Loop Menu \n\n\n");
        for (int i = 0; i < menuItems.Count; i++)
        {
            menuItems[i].Display();
        }

    }
}

abstract class Person
{
    private string _name;
    private int _id; 

    public Person(string name,int id)
    {
        PersonName = name;
        PersonId = id;
    }

    public int PersonId { get => _id; set => _id = value; }
    public string PersonName { get => _name; set => _name = value; }

}

class StoreKeeper : Person
{
    public StoreKeeper(string name,int id) : base(name, id) { }

    public void AddItem(Menu menu,Product product) { }
    public void RemoveItem(Menu menu,int id) { }
    public void UpdateItem(Menu menu,int id,string name,int price) { }

}

class Customer : Person
{
    public Customer(string name, int id) : base(name, id) { }

    
}

class Product
{
    private int _product_id;
    private string _product_name;
    private int _price;
    public Product(string name,int id,int price)
    {
        ProductId = id;
        ProductName = name;
        ProductPrice = price;
        
    }
    public int ProductId { get => _product_id; set => _product_id = value; }
    public string ProductName { get => _product_name; set => _product_name = value; }
    public int ProductPrice { get => _price; set => _price = value; }

    public void Display()
    {
        Console.WriteLine("\n\nProduct Id: "+ProductId);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Product Price: " + ProductPrice + "$");
    }
}



class OrderItem
{
    private Product _product;
    private int _quantity;

    public OrderItem(Product P,int number)
    {
        product = P;
        Quantity = number;
    }

    public Product product { get => _product; set => _product = value; }
    public int Quantity { get => _quantity; set => _quantity = value; }
}

class Order
{
    private int _OrderId;
    List<OrderItem> OrderItems;
    private int _TotalCost;

    public Order(int id,List<OrderItem> ItemList)
    {

        OrderItems = ItemList;
        for(int i = 0; i < OrderItems.Count; i++)
        {
            TotalCost += OrderItems[i].product.ProductPrice * OrderItems[i].Quantity;
        }
       
    }

    public int OrderId { get => _OrderId; set => _OrderId = value; }
    public int TotalCost { get => _TotalCost; set => _TotalCost = value; }

    public void DisplayOrder()
    {
        Console.WriteLine("\n\nOrder Id: " + OrderId);
        Console.WriteLine("Item Details: ");
        Console.WriteLine("Name\t\t Unit Price\t\t Quantity");
        for(int i = 0; i < OrderItems.Count; i++)
        {
            Console.WriteLine("\n" + OrderItems[i].product.ProductName + "\t\t" + OrderItems[i].product.ProductPrice + "\t\t" + OrderItems[i].Quantity);
        }
        Console.WriteLine("\nTotal Cost: " + TotalCost + "$");

    }

}


class SweetLoop
{
    static void Main()
    {
      
       
    }
}