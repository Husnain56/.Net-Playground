using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
using System.Xml.Linq;

class Product
{
    private static int _counter = 0;

    private int _product_id;
    private string _product_name;
    private int _price;
    public Product(string name, int price)
    {
        ProductId = ++_counter;
        ProductName = name;
        ProductPrice = price;

    }
    public int ProductId { get => _product_id; set => _product_id = value; }
    public string ProductName { get => _product_name; set => _product_name = value; }
    public int ProductPrice { get => _price; set => _price = value; }

    public void Display()
    {
        Console.WriteLine("\n\nProduct Id: " + ProductId);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Product Price: " + ProductPrice + "$");
    }
}

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
        Console.WriteLine("Item Added to the Menu successfully");
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

    public void PopulateDefaultMenu()
    {
        menuItems.Add(new Product("Sugar Cinnamon Coat", 250));
        menuItems.Add(new Product("Sugar Glaze", 250));
        menuItems.Add(new Product("Color Glaze with Sprinkle", 250));
        menuItems.Add(new Product("Choco Ice Glaze", 250));
        menuItems.Add(new Product("Honey Butter", 250));
        menuItems.Add(new Product("Cookie Crumble", 250));
        menuItems.Add(new Product("Coconut Delight", 250));
        menuItems.Add(new Product("Box of 6 Donuts (Classic)", 1300));

        menuItems.Add(new Product("Pure Chocolate Donut", 300));
        menuItems.Add(new Product("Toasted Nut Donut", 300));
        menuItems.Add(new Product("Box of 6 Donuts (Premium)", 1500));

   
        menuItems.Add(new Product("Whipped Cream Bomboloni", 300));
        menuItems.Add(new Product("Lemon Curd Bomboloni", 300));
        menuItems.Add(new Product("Creamy Vanilla Custard Bomboloni", 300));
        menuItems.Add(new Product("Jam Filling Bomboloni", 300));
        menuItems.Add(new Product("Box of 6 Bomboloni (Classic)", 1500));

        menuItems.Add(new Product("Salted Caramel Bomboloni", 350));
        menuItems.Add(new Product("Chocolate Ganache Bomboloni", 350));
        menuItems.Add(new Product("Lotus Bomboloni", 350));
        menuItems.Add(new Product("Cream Cheese Bomboloni", 350));
        menuItems.Add(new Product("Box of 6 Bomboloni (Premium)", 1750));

        menuItems.Add(new Product("Honey Butter Glaze Roll", 300));
        menuItems.Add(new Product("Box of 6 Cinnamon Roll (Classic)", 1500));

        menuItems.Add(new Product("Cinni Mini (Box of 3)", 550));
        menuItems.Add(new Product("Cinni Mini (Box of 6)", 1050));
        menuItems.Add(new Product("Cinni Mini (Box of 12)", 2000));

        menuItems.Add(new Product("Salted Caramel Roll", 350));
        menuItems.Add(new Product("Toasted Nut (Walnut) Roll", 350));
        menuItems.Add(new Product("Cream Cheese with Caramel Roll", 350));
        menuItems.Add(new Product("Pure Chocolate Roll", 350));
        menuItems.Add(new Product("Box of 6 Cinnamon Roll (Premium)", 1750));

        menuItems.Add(new Product("Cinni Mini Premium (Box of 3)", 650));
        menuItems.Add(new Product("Cinni Mini Premium (Box of 6)", 1250));
        menuItems.Add(new Product("Cinni Mini Premium (Box of 12)", 2400));
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
        Console.WriteLine("\n\n\t\t Sweet Loop Menu \n\n");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine($"{"ID",-5} {"Product Name",-40} {"Price (Rs)",10}");
        Console.WriteLine("------------------------------------------------------------");

        for (int i = 0; i < menuItems.Count; i++)
        {
            Console.WriteLine($"{menuItems[i].ProductId,-5} {menuItems[i].ProductName,-40} {menuItems[i].ProductPrice,10}");
        }

        Console.WriteLine("------------------------------------------------------------");
    }

    public Product ReturnProductInfo(int id)
    {
        for (int i = 0; i < menuItems.Count; i++)
        {
            if (menuItems[i].ProductId == id)
            {
                return menuItems[i];
            }
        }
        Console.WriteLine("Product with id " + id + " doesn't exists...");
        return null;
    }

}

abstract class Person
{
    private string _name;

    public Person(string name)
    {
        PersonName = name;
    }
    public string PersonName { get => _name; set => _name = value; }

}

class StoreKeeper : Person
{
    public StoreKeeper(string name) : base(name) { }
   
    public void AddItem(Menu menu,Product product) {
        menu.AddNewItem(product);
    }
    public void RemoveItem(Menu menu,int id) {
        menu.RemoveItem(id);
    }
    public void UpdateItem(Menu menu,int id,string name,int price) {
        menu.UpdateItem(id, name, price);
    }
    public void ViewMenu(Menu menu)
    {
        menu.DisplayMenu();
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
    List<OrderItem> _orderItems;
    private int _TotalCost;

    public Order(List<OrderItem> ItemList)
    {

        _orderItems = ItemList;
        for(int i = 0; i < _orderItems.Count; i++)
        {
            TotalCost += _orderItems[i].product.ProductPrice * _orderItems[i].Quantity;
        }
       
    }
    public int TotalCost { get => _TotalCost; set => _TotalCost = value; }

    public void DisplayOrder()
    {
        Console.WriteLine("\n\n Order Invoice");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine($"{"Name",-30} {"Unit Price",15} {"Quantity",10}");
        Console.WriteLine("------------------------------------------------------------");

        for (int i = 0; i < _orderItems.Count; i++)
        {
            Console.WriteLine($"{_orderItems[i].product.ProductName,-30} {_orderItems[i].product.ProductPrice,15} {_orderItems[i].Quantity,10}");
        }
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine($"{"Total Cost:",-30} {TotalCost,15}");
    }

}

class Customer : Person
{
    Order _order;
    public Customer(string name) : base(name) { }

    public void ViewMenu(Menu menu)
    {
        menu.DisplayMenu();
    }

    public void PlaceOrder(List<OrderItem> OrderItems)
    {
        _order = new Order(OrderItems);
    }
    public void GenerateInvoice()
    {
        _order.DisplayOrder();
    }
    public Product SearchItem(Menu menu,int id)
    {
        return menu.ReturnProductInfo(id);
    }

}

class SweetLoop
{
    static void Main()
    {
        string input = "";
        Menu menu = new Menu();
        menu.PopulateDefaultMenu();

        Console.WriteLine("\n\t\t\t\t Welcome to SweetLoop\n\n");
        Console.WriteLine("Are you a Customer or StoreKeeper? Enter 1 for Customer and Enter 2 for StoreKeeper");
        Console.Write("Your Input: ");
        input = Console.ReadLine();

        if (input == "2") 
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            StoreKeeper storeKeeper = new StoreKeeper(name);

            while (true)
            {
                Console.WriteLine($"\nWelcome {name} (StoreKeeper)");
                Console.WriteLine("Enter 1 to View Menu");
                Console.WriteLine("Enter 2 to Add an Item to Menu");
                Console.WriteLine("Enter 3 to Update an Item in the Menu");
                Console.WriteLine("Enter 4 to Remove an Item from the Menu");
                Console.WriteLine("Enter -1 to exit :( ");
                Console.Write("Your Input: ");
                input = Console.ReadLine();

                if (input == "-1") break;

                switch (input)
                {
                    case "1":
                        storeKeeper.ViewMenu(menu);
                        break;

                    case "2":
                        Console.Write("Enter Product Name: ");
                        string addName = Console.ReadLine();
                        Console.Write("Enter Product Price: ");
                        int addPrice = int.Parse(Console.ReadLine());
                        storeKeeper.AddItem(menu, new Product(addName, addPrice));
                        break;

                    case "3":
                        Console.Write("Enter Product ID to Update: ");
                        int updId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Name: ");
                        string updName = Console.ReadLine();
                        Console.Write("Enter New Price: ");
                        int updPrice = int.Parse(Console.ReadLine());
                        storeKeeper.UpdateItem(menu, updId, updName, updPrice);
                        break;

                    case "4":
                        Console.Write("Enter Product ID to Remove: ");
                        int remId = int.Parse(Console.ReadLine());
                        storeKeeper.RemoveItem(menu, remId);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        else if (input == "1")
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Customer customer = new Customer(name);

            List<OrderItem> cart = new List<OrderItem>();

            while (true)
            {
                Console.WriteLine($"\nWelcome {name} (Customer)");
                Console.WriteLine("Enter 1 to View Menu");
                Console.WriteLine("Enter 2 to add an item to the cart");
                Console.WriteLine("Enter 3 to Place the order and Generate Order Invoice");
                Console.WriteLine("Enter -1 to exit :( ");
                Console.Write("Your Input: ");
                input = Console.ReadLine();

                if (input == "-1") break;

                switch (input)
                {
                    case "1":
                        customer.ViewMenu(menu);
                        break;

                    case "2":
                        Console.Write("Enter Product ID to Order: ");
                        int pId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Quantity: ");
                        int qty = int.Parse(Console.ReadLine());

                        Product p = customer.SearchItem(menu, pId);
                        if (p!=null)
                        {
                            cart.Add(new OrderItem(p, qty));
                            Console.WriteLine("Item added to cart.");
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;

                    case "3":
                        if (cart.Count > 0)
                        {
                            customer.PlaceOrder(cart);
                            customer.GenerateInvoice();
                            Console.WriteLine("\nThank you for purchasing from SweetLoop! Exiting...");
                            return;  
                        }
                        else
                        {
                            Console.WriteLine("Cart is empty, place an order first!");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid Input! Restart the program.");
        }
    }
}
