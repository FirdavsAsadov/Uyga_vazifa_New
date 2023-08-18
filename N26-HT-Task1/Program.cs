using System.Runtime.InteropServices;
using System.Threading.Channels;
using N26_HT_Task1;
using N26_HT_Task1.Interfeys;
using N26_HT_Task1.Model;
using N26_HT_Task1.Service;
using Monitor = N26_HT_Task1.Model.Monitor;

public class Program
{
    static void Main(string[] args)
    {
        /*ProductService productServiceis = new ProductService();
        PaymentService paymentService = new PaymentService();
        var orderserviceis = new OrderService(productServiceis, paymentService);
        IProduct m1 = new Monitor(4, 4.7, "Manitor Asus 1pro", "Juda ajoyib", false, 14);
        IProduct m2 = new Monitor(8, 4.9, "Manitor Asus 4pro", "so great", false, 18900);
        IProduct m3 = new Monitor(2, 4.1, "Manitor Asus 2pro", "so beutiful", false, 16000);
        productServiceis.Add(m1);
        productServiceis.Add(m2);
        productServiceis.Add(m3);
        var l1 = new Laptop("ryzen", "C", "Asus Rog strix", "Very betuful", false, 120000);
        var l2 = new Laptop("ryzen", "C", "Asus zepheryus", "Very jje", false, 140000);
        var l3 = new Laptop("ryzen", "C", "Asus vivobook", "Very kontributor", true, 170000);
        productServiceis.Add(l1);
        productServiceis.Add(l2);
        productServiceis.Add(l3);
        var ch1 = new Chair(20, "alyuminium", "bigmans", "very strongly", false, 130_000);
        var ch2 = new Chair(21, "temir", "bigmans", "very strongly", false, 130_000);
        var ch3 = new Chair(25, "oltin", "richmans", "very expensive", false, 90000000);
        productServiceis.Add(ch1);
        productServiceis.Add(ch2);
        productServiceis.Add(ch3);
        /*DebitCard card1 = new DebitCard { Balance = 100, CardNumber = "1234567890123456" };
        bool orderResult = orderserviceis .Order(m1.Id, card1);
        Console.WriteLine($"Order Result: - {orderResult}");#1#
        ProductFilterDataModel model = new ProductFilterDataModel
        {
            ProductTypes = new List<string>
                { typeof(Monitor).FullName, typeof(Chair).FullName, typeof(Laptop).FullName }
        };
        DebitCard card2 = new DebitCard { Balance = 500, CardNumber = "128372837128937912" };
        bool orderResult = orderserviceis.Order(model, card2);
        Console.WriteLine("Multiple Products Order Result: " + orderResult);*/
        ProductService productService = new ProductService();
        PaymentService paymentService = new PaymentService();
        OrderService orderService = new OrderService(productService, paymentService);

        // Creating and adding products to the inventory
        IProduct laptop = new Laptop("Intel", "i7", "Laptop Model 1", "High-performance laptop", true, 1200);
        IProduct monitor = new Monitor(60, 27.0, "Monitor Model 1", "High-resolution monitor", false, 300);
        IProduct chair = new Chair(150, "Wood", "Chair Model 1", "Comfortable wooden chair", false, 150);

        productService.Add(laptop);
        productService.Add(monitor);
        productService.Add(chair);

        // Ordering individual products
        DebitCard card1 = new DebitCard { Balance = 1500, CardNumber = "1234-5678-9012-3456" };
        bool orderResult1 = orderService.Order(laptop.Id, card1);
        Console.WriteLine("Laptop Order Result: " + orderResult1);

        // Creating a filter data model for ordering multiple products
        ProductFilterDataModel filterDataModel = new ProductFilterDataModel
        {
            ProductTypes = new List<string> { typeof(Monitor).FullName, typeof(Chair).FullName }
        };

        DebitCard card2 = new DebitCard { Balance = 500, CardNumber = "9876-5432-1098-7654" };
        bool orderResult2 = orderService.Order(filterDataModel, card2);
        Console.WriteLine("Multiple Products Order Result: " + orderResult2);

    }
}















