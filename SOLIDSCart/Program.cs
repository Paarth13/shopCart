using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cart;
using Ops;
using items;
namespace SOLIDSCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart shopCart = new Cart();
            Items funcs = new Items();
            shopCart.products.Add(funcs.addItem());
            shopCart.mode = ModeOfPayment.COD;
            shopCart=shopCart.removeItems(shopCart);
            int amount = 0;
            for (int i = 0; i < shopCart.products.Count; i++)
            {
                amount += shopCart.products[i].price * shopCart.products[i].quantity;
            }

            shopCart.amount = amount;
            shopCart.show(shopCart);
        }
    }
}
