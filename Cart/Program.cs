using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Program
    {
        static List<Items> product = new List<Items>()
        {
            new Items(){itemId=1,itemPrice=200,name="BasketBall",quantity=1 },
            new Items(){itemId=2,itemPrice=1000,name="Tshirts",quantity=1 }
        };
        static void Main(string[] args)
        {
            int itemNumber = 0, count = 1;
            MainCart cart = new MainCart();
            CartOperations cartOps = new CartOperations();
            while (true)
            {

                Console.WriteLine("Select from the following \n1.Add Item\n2.Delete all \n3.Delete a particular\n4.Show Cart\n");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Please Select the corresponding number of an Item from the following list you want.");
                        foreach (var eachItem in product)
                        {
                            Console.WriteLine(count++);
                            Console.WriteLine("Name: " + eachItem.name);
                            Console.WriteLine("Price: " + eachItem.itemPrice);
                            Console.WriteLine("\n");

                        }
                        itemNumber = int.Parse(Console.ReadLine());
                        itemNumber -= 1;
                        Console.WriteLine("Please select the quantity");
                        product[itemNumber].quantity = int.Parse(Console.ReadLine());
                        cartOps.AddItems(cart, product[itemNumber]);
                        break;
                    case 2:
                        cartOps.RemoveAllItems(cart);
                        break;
                    case 3:
                        cartOps.RemoveItem(cart);
                        break;
                    case 4:
                        cartOps.ShowCart(cart);
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Do you wish to continue Press y for yes and press n for no");
                string character = Console.ReadLine();
                if (character == "y")
                    break;
            }



        }
    }
}
