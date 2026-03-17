using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__Constructor__Inheritance_Code_.Models
{
    public class Order
    {
        public int Id;
        public string ProductName;
        public int Quantity;
        public double Price;

        public Order(int id, string productName, double price)
        {
            Id = id;
            ProductName = productName;
            Price = price;
            Quantity = 1;
        }

        public Order(int id, string productName, int quantity, double price)
        {
            Id = id;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }

        public double GetTotalAmount()
        {
            return Quantity * Price;
        }

        public void IncreaseQuantity(int n = 1)
        {
            Quantity += n;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Sifariş ID: {Id}");
            Console.WriteLine($"Məhsul: {ProductName}");
            Console.WriteLine($"Sayı: {Quantity}");
            Console.WriteLine($"Qiymət: {Price} AZN");
            Console.WriteLine($"Ümumi Məbləğ: {GetTotalAmount()} AZN");
        }

        public void ChangePrice(double newPrice, out int diff)
        {
            diff = (int)(newPrice - Price);
            Price = newPrice;
        }






    }
}
