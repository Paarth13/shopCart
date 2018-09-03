using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace items
{
    public class Items
    {
        public string productName { get; set; }
        public int productId { get; set; }

        public int quantity { get; set; }

        public int price { get; set; }


        public Items addItem()
        {
            Items ob = new Items();
            ob.price = 100;
            ob.productName = "BB";
            ob.quantity = 2;
            ob.productId = 101;
            return ob;
        }

        

    }
}
