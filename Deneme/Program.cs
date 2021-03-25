using System;

class Product
{
    public string ProductName { get; set; }
    public int Price { get; set; }
    public bool StockStatus { get; set; }

}
class MainClass
{
    public static void Main(string[] args)
    {
        int w = 0;
        Product Laptop = new Product();
        Laptop.ProductName = "HP LAPTOP";
        Laptop.Price = 4000;
        Laptop.StockStatus = true;

        Product Phone = new Product();
        Phone.ProductName = "Samsung Phone";
        Phone.Price = 11000;
        Phone.StockStatus = false;

        Product Pencil = new Product();
        Pencil.ProductName = "Black Pencil";
        Pencil.Price = 102;
        Pencil.StockStatus = false;

        Product[] Products = new Product[] { Pencil, Phone, Laptop };

        Console.WriteLine("Foreach Döngüsü");
        
        foreach (var Product in Products)
        {
            Console.WriteLine(Product.ProductName + " : " + Product.Price + " TL");
            Console.WriteLine("Stok Durumu : " + Product.StockStatus);
        }
        
        Console.WriteLine(" ");
        Console.WriteLine("For Döngüsü");
        
        for (int i = 0; i < Products.Length; i++)
        {
            Console.WriteLine(Products[i].ProductName + " : " + Products[i].Price + " TL");
            Console.WriteLine("Stok Durumu : " + Products[i].StockStatus);
        }
        
        Console.WriteLine(" ");
        Console.WriteLine("While Döngüsü");
        
        while (w < Products.Length)
        {
            Console.WriteLine(Products[w].ProductName + " : " + Products[w].Price + " TL");
            Console.WriteLine("Stok Durumu : " + Products[w].StockStatus);
            w++;
        }
        
        Console.WriteLine(" ");






    }
}