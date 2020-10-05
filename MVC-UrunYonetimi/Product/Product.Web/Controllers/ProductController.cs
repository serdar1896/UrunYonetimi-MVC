using Product.Core.Infrastructure;
using Product.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product.Web.Controllers
{
    public class ProductController : Controller
    {
        ICategoryRepository _categoryRepository;
        IProductRepository _productRepository;
        public ProductController(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }
        // GET: Product
        public ActionResult Index(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("Index","Home");
            }
            var product = _productRepository.GetById(id.Value);
            if (product==null)
            {
                return RedirectToAction("Index","Home");
            }
            var allCategory = _categoryRepository.GetAll().ToList();
            var pageModel = new ProductPageModel
            {
                CurrentProduct = product,
                CategoryList = allCategory
            };
            return View(pageModel);
        }

    }
}