using Day8.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day8.Controllers
{
    public class QdhEmployeeController : Controller
    {
        // mock Data
        private static List<QdhEmployee> qdhListEmployee = new List<QdhEmployee>()
        {
            new QdhEmployee
    {
        QdhId = 1,
        QdhName = "Quách đức huy",
        QdhBirthDay = new DateTime(2005, 01, 02),
        QdhEmail = "huychuoi05@gmail.com",
        QdhPhone = "0328966457",
        QdhSalay = 12000000,
        QdhStatus = true
    },
    new QdhEmployee
    {
        QdhId = 2,
        QdhName = "Trần Thị B",
        QdhBirthDay = new DateTime(1992, 8, 22),
        QdhEmail = "tranthib@example.com",
        QdhPhone = "0934567890",
        QdhSalay = 10500000,
        QdhStatus = true
    },
    new QdhEmployee
    {
        QdhId = 3,
        QdhName = "Lê Văn C",
        QdhBirthDay = new DateTime(1985, 1, 15),
        QdhEmail = "levanc@example.com",
        QdhPhone = "0987654321",
        QdhSalay = 15000000,
        QdhStatus = false
    },
    new QdhEmployee
    {
        QdhId = 4,
        QdhName = "Phạm Thị D",
        QdhBirthDay = new DateTime(1998, 11, 30),
        QdhEmail = "phamthid@example.com",
        QdhPhone = "0978123456",
        QdhSalay = 9800000,
        QdhStatus = true
    },
    new QdhEmployee
    {
        QdhId = 5,
        QdhName = "Đỗ Văn E",
        QdhBirthDay = new DateTime(1995, 4, 5),
        QdhEmail = "dovane@example.com",
        QdhPhone = "0909123456",
        QdhSalay = 11200000,
        QdhStatus = false
    }
        };
        // GET: QdhEmployeeController
        public ActionResult QdhIndex()
        {
            return View( qdhListEmployee);
        }

        // GET: QdhEmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var qdhEmployee = new QdhEmployee();
            return View(qdhEmployee);
        }

        // GET: QdhEmployeeController/QdhCreate
        public ActionResult QdhCreate()
        {
            return View();
        }

        // POST: QdhEmployeeController/Create
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

        // GET: QdhEmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QdhEmployeeController/Edit/5
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

        // GET: QdhEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QdhEmployeeController/Delete/5
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
