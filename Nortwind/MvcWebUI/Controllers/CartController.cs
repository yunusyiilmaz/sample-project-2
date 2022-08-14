using Business.Abstract;
using Entities.Conrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Helpers;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class CartController:Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IProductService _productService;
        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            Product product = _productService.GetById(productId);//ürün çekmek için
            var cart = _cartSessionHelper.GetCart(key:"cart");//sessiondan sepeti çekmek için
            _cartService.AddToCart(cart, product);//çekilen sepete ürün eklemek için kullanılır.
            _cartSessionHelper.SetCart(key: "cart",cart);//ürün sessiona eklenir.
            TempData.Add("message", product.ProductName + "sepetten eklendi");
            return RedirectToAction("Index", controllerName: "Product");
        }
        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart(key: "cart")
            };
            return View(model);
        }
        public IActionResult RemoveFromCart(int productId)
        {
            Product product = _productService.GetById(productId);//ürün çekmek için
            var cart = _cartSessionHelper.GetCart(key: "cart");//sessiondan sepeti çekmek için
            _cartService.RemoveFromCart(cart, productId);//çekilen sepete ürün silmek için kullanılır.
            _cartSessionHelper.SetCart(key: "cart", cart);//ürün sessiona eklenir.
            TempData.Add("message", product.ProductName + "sepetten silindi");
            return RedirectToAction("Index", controllerName: "Cart");
        }
        public IActionResult Complete()
        {
            var model = new ShippingDetailsViewModel
            {
                ShippingDetail = new ShippingDetail()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult complete(ShippingDetail shippingDetail)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", "siparişiniz başarıyla tamamlandı.");
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", controllerName: "cart");
        }
        }
}
