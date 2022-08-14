using Entities.Conrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);//sepete eklemek için
        void RemoveFromCart(Cart cart, int productId);//sepette silmek için
         List<CartLine> List(Cart cart);// sepettekileri listelemek için
    }
}
