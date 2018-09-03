using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using items;
using cart;
namespace Ops
{
    public class Operations
    {
        public Items addItem()
        {
            Items ob = new Items();
            ob.price = 100;
            ob.productName = "BB";
            ob.quantity = 2;
            ob.productId = 101;
            return ob;
        }

        public Cart removeItems(Cart ob)
        {
            ob.products.Clear();
            return ob;
        }

            }
}
