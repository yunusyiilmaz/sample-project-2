using Business.Abstract;
using Entities.Conrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)//sepete ekleme kodları
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);//gönderdiğimiz ıd de başka bir ürün var mı? 
            if(cartLine!=null)
            {
                cartLine.Quantity++;

            }
            else
            {
                cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
            }
        }

        public List<CartLine> List(Cart cart)//sepettekileri listeleyen kodlar
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)//sepettekileri silmek için
        {
            cart.CartLines.Remove(item: cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
           
        }
    }
}
