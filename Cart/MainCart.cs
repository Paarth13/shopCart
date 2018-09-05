using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class MainCart
    {
        public int cartId { get; set; }
        public List<Items> items = new List<Items>();
        public int amount = 0;

    }
}
