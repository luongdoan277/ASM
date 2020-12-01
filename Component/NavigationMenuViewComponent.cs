using ASM.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Component
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreReponsitory repository;

        public NavigationMenuViewComponent(IStoreReponsitory repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .Select(p => p.Categories.Name)
                .Distinct()
                .OrderBy(p => p));
        }
    }
}
