using Business.Abstract;
using Entities.Conrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class CategoryController:Controller
    {
        private ICategoryService _CategoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _CategoryService = categoryService;
        }
    }
}
