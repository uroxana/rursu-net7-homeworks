using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a class Product with one constructor and the following fields:
- name
- price
- quantity

Add the following methods:
- GetName() - returns the product's name.
- GetPrice() - returns the product's price.
- GetQuantity() - returns the product's quantity.
- SetName(string name) - sets the product's name.
- SetPrice(double price) - sets the product's price.
- SetQuantity(int quantity) - sets the product's quantity.

The following program should work after you implement missing classes:

Product product = new Product("Apple", 0.99, 10);

Console.WriteLine(product.GetName()); // Outputs "Apple"
Console.WriteLine(product.GetPrice()); // Outputs 0.99
Console.WriteLine(product.GetQuantity()); // Outputs 10

product.SetName("Orange");
product.SetPrice(1.49);
product.SetQuantity(20);

Console.WriteLine(product.GetName()); // Outputs "Orange"
Console.WriteLine(product.GetPrice()); // Outputs 1.49
Console.WriteLine(product.GetQuantity()); // Outputs 20*/

namespace homework_week_4.exercise_4
{
    public class Product
    {
        public Product(string name,double price,int quantity) 
        { 
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public string name;
        public double price;
        public int quantity;
    public string GetName()
        { return name; }
    public double GetPrice()
        { return price; }
    public int GetQuantity()
        { return quantity; }
    public void SetName(string name)
        { this.name = name; }
    public void SetPrice(double price)
        { this.price = price; }
    public void SetQuantity(int quantity)
        { this.quantity = quantity; }
    }
}
