using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QdhLesson07.Controllers
{
    public class QdhMemberController : Controller
    {
        // GET: QdhMemberController
        public ActionResult Index()
        {
            return View();
        }

        // GET: QdhMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QdhMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QdhMemberController/Create
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

        // GET: QdhMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QdhMemberController/Edit/5
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

        // GET: QdhMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QdhMemberController/Delete/5
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