using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class ShopingCart
    {
        private IValueCalculator calc;

        public ShopingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductsTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}