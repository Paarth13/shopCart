using ITEMSclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace items
{
    public class Items : IItems()
    {
         string __productName { get; set; }
         int __productId { get; set; }

         int __quantity { get; set; }

         int __price { get; set; }


        public Items AddItem() 
        {
            // adding an item with all of its attributes.
           
        }

        

    }
}
