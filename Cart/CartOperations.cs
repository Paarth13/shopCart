using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class CartOperations : ICartOperations
    {
        public void AddItems(MainCart cart, Items product)
        {


            cart.items.Add(product);

        }

        public void RemoveAllItems(MainCart cart)
        {
            cart.items.Clear();
        }


        public void RemoveItem(MainCart cart)
        {
            if (cart.items.Count == 0)
            {
                Console.WriteLine("Cart is Empty");
            }
            else
            {
                int index = 0, value;
                Console.WriteLine("Select the corresponding values of the element you want to delete");
                ShowCart(cart);
                index = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Enter the number of elements you want to delete.");
                value = int.Parse(Console.ReadLine());
                if (value >= cart.items[index].quantity)
                    cart.items.RemoveAt(index);
                else
                    cart.items[index].quantity -= value;
                Console.WriteLine("Items is removed");

            }
        }
        public void ShowCart(MainCart cart)
        {
            if (cart.items.Count == 0)
            {
                Console.WriteLine("Cart is Empty");
            }
            else
            {
                int count = 1;
                foreach (var eachItem in cart.items)
                {
                    Console.WriteLine(count++);
                    Console.WriteLine("Name: " + eachItem.name);
                    Console.WriteLine("Price: " + eachItem.itemPrice);
                    Console.WriteLine("Quantity: " + eachItem.quantity);
                    cart.amount += eachItem.quantity * eachItem.itemPrice;
                }
                Console.WriteLine("Amount :" + cart.amount);
            }
        }
    }
}
