using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace day9.Controllers
{
    public class QdhAccountController : Controller
    {
        // GET: QdhAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: QdhAccount/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QdhAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QdhAccount/Create
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

        // GET: QdhAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QdhAccount/Edit/5
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

        // GET: QdhAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QdhAccount/Delete/5
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
