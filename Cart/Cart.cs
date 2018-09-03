using items;
using System;
using System.Collections.Generic;

namespace cart
{
    public class Cart
    {
        public List<Items> products { get; set; }
        

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

    }

    public enum ModeOfPayment
    {
        COD,
        Online
    }
}
