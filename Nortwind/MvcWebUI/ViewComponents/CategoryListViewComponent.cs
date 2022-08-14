using Business.Abstract;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent//ekranda default sabit görünmesi için yazıldı.
    {
        private ICategoryService _CategoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _CategoryService = categoryService;
        }
        public ViewViewComponentResult Invoke()//componentin dönüş tipidir.
        {
            var model = new CategoryListViewModel
            {
                Categories = _CategoryService.GetAll(),//category listelerini yazdırdık.
                CurrentCategory=Convert.ToInt32(HttpContext.Request.Query["category"])//hangi datanın seçili olduğunun kodlanması
            };
            return View(model);
        }
    }
}
