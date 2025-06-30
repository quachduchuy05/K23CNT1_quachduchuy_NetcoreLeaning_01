using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace day9.Controllers
{
    public class QdhCategoriesController : Controller
    {
        // GET: QdhCategoriesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: QdhCategoriesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QdhCategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QdhCategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QdhCategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QdhCategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QdhCategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QdhCategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
