using items;
using System;
using System.Collections.Generic;

namespace cart
{
    public class Cart
    {
        List<Items> __products { get; set; }
        

        int __amount { get; set; }

        ModeOfPayment mode;

        public Cart addCart()
        {
            // Adding cart with items (calling add items), total amount, mode of payment
        }
        public void show(Cart ob)
        {
            // showing all the items with their attributes and showing total amount and mode of payment. 
        }


        public Cart removeItems(Cart ob)
        {
            // Can remove items 
            
        }

        public void checkout()
        {
            // On the basis of mode of payment selected checkout is performed.
        }
    }

    public enum ModeOfPayment
    {
        COD,
        Online
     }
}
