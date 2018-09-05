using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    interface ICartOperations
    {
        void ShowCart(MainCart cart);

        void AddItems(MainCart cart,Items Product);

        void RemoveItem(MainCart cart);

        void RemoveAllItems(MainCart cart);

    }
}
