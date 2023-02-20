// See https://aka.ms/new-console-template for more information
using Events;

Console.WriteLine("Hello, World!");

Product harddisk = new Product(50);
harddisk.ProductName = "Hard Disk";

Product gsm= new Product(50);
gsm.ProductName = "Gsm";
gsm.StockControlEvent += Gsm_StockControlEvent  ;

void Gsm_StockControlEvent()
{
    Console.WriteLine("Gsm is about to finish.");

}

for (int i = 0; i < 10; i++)
{
    harddisk.Sell(10);
    gsm.Sell(10);
    Console.ReadLine();
}