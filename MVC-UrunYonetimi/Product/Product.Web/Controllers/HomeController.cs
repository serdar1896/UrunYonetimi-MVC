using Product.Core.Infrastructure;
using System.Linq;
using System.Web.Mvc;

namespace Product.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public HomeController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public ActionResult Index()
        {
            var categoryList = _categoryRepository.GetAll().ToList();
            return View(categoryList);
        }

       
    }
}