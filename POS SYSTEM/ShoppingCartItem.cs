﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_SYSTEM
{
    internal class ShoppingCartItem
    {
        public string ItemName { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get { return Qty * Price; } }
    }
}
