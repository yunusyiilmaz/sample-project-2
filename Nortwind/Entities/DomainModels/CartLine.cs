using Core.Entities.Abstract;
using Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DomainModels
{
    public class CartLine:IDomainModel//sepet eleman detayı
    {
        public Product Product { get; set; }//ürün
        public int Quantity { get; set; }//ürün sayısı
    }
}
