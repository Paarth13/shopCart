using items;
using System;
using System.Collections.Generic;

namespace cart
{
    public class Cart
    {
        public List<Items> products = new List<Items>();
        

        public  int amount { get; set; }

      public   ModeOfPayment mode;


        public void show(Cart ob)
        {
            foreach (var prod in ob.products)
            {
                Console.WriteLine(prod.productName);
                Console.Write(prod.price);
                Console.WriteLine(prod.quantity);
            }
            Console.WriteLine(ob.mode);
            Console.WriteLine("Price is:");
            Console.WriteLine(ob.amount);
        }


        public Cart removeItems(Cart ob)
        {
            ob.products.Clear();
            return ob;
        }
    }

    public enum ModeOfPayment
    {
        COD,
        Online
    }
}
