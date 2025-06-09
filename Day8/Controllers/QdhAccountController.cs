using Microsoft.AspNetCore.Mvc;
using Day8.Models;

namespace Day8.Controllers
{
    public class QdhAccountController : Controller
    {
        public IActionResult Index()
        {
            QdhAccount account = new QdhAccount();
            return View(account);
        }

        // GET: QdhAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QdhAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QdhAccountController/Create
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

        // GET: QdhAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QdhAccountController/Edit/5
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

        // GET: QdhAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QdhAccountController/Delete/5
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
