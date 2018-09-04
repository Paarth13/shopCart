using System;
using System.Collections.Generic;
using System.Text;
using cart;
namespace Carts
{
    interface ICart
    {
        Cart addCart();
        void show(Cart ob);

        Cart removeItems();

        void checkout();
    }
}
