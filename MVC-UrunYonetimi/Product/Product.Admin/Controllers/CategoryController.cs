using Product.Core.Infrastructure;
using Product.Data.Model;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Product.Admin.Controllers
{
    public class CategoryController : Controller
    { 
        // Dependency injection oluşturuldu Bootstrapper class'ında
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET: Category
        public ActionResult Index()
        {
            var categoriList = _categoryRepository.GetAll().ToList();
            return View(categoriList);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            _categoryRepository.Insert(category);
            _categoryRepository.Save();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var category = _categoryRepository.GetById(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _categoryRepository.Update(category);
            _categoryRepository.Save();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var category = _categoryRepository.GetById(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var category = _categoryRepository.GetById(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _categoryRepository.Delete(id);
            _categoryRepository.Save();
            return RedirectToAction("Index");
        }


    }
}