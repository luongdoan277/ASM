using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASM.Models;
using ASM.Models.ViewModels;

namespace ASM.Controllers
{
    public class HomeController : Controller
    {
        private IStoreReponsitory reponsitory;
        public int PageSize = 6;

        public HomeController(IStoreReponsitory repo)
        {
            reponsitory = repo;
        }
        public ViewResult Index(string category, int productPage = 1)
        {
            return View(new ProductsListViewModel
            {
                Products = reponsitory.Products
                .Where(p => category == null || p.Categories.Name == category)
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    reponsitory.Products.Count() :
                    reponsitory.Products.Where(
                        e => e.Categories.Name == category).Count()
                },
                CurrentCategory = category
            });
        }
    }
}
