using Microsoft.AspNetCore.Mvc;
using Quachduchuy_2310900045.Models;

namespace Quachduchuy_2310900045.Controllers
{
    public class QdhEmployeeController : Controller
    {
        private static List<QdhEmployee> employees = new List<QdhEmployee>
        {
            new QdhEmployee { qdhEmpId = 1, qdhEmpName = "quách đức huy", qdhEmpLevel = "Sinh viên", qdhEmpStartDate = DateTime.Parse("2023-08-15"), qdhEmpStatus = true },
            new QdhEmployee { qdhEmpId = 2, qdhEmpName = "nguyễn hữu tuyên", qdhEmpLevel = "Nhân viên", qdhEmpStartDate = DateTime.Parse("2022-05-10"), qdhEmpStatus = true },
            new QdhEmployee { qdhEmpId = 3, qdhEmpName = "đỗ tiến dũng", qdhEmpLevel = "Quản lý", qdhEmpStartDate = DateTime.Parse("2021-11-25"), qdhEmpStatus = false }
        };

        public IActionResult QdhIndex() => View(employees);

        public IActionResult QdhDetail(int id)
        {
            var emp = employees.FirstOrDefault(e => e.qdhEmpId == id);
            return View(emp);
        }

        public IActionResult QdhCreate() => View();

        [HttpPost]
        public IActionResult QdhCreate(QdhEmployee emp)
        {
            employees.Add(emp);
            return RedirectToAction("QdhIndex");
        }

        public IActionResult QdhEdit(int id)
        {
            var emp = employees.FirstOrDefault(e => e.qdhEmpId == id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult QdhEdit(QdhEmployee emp)
        {
            var old = employees.FirstOrDefault(e => e.qdhEmpId == emp.qdhEmpId);
            if (old != null)
            {
                old.qdhEmpName = emp.qdhEmpName;
                old.qdhEmpLevel = emp.qdhEmpLevel;
                old.qdhEmpStartDate = emp.qdhEmpStartDate;
                old.qdhEmpStatus = emp.qdhEmpStatus;
            }
            return RedirectToAction("QdhIndex");
        }

        public IActionResult QdhDelete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.qdhEmpId == id);
            return View(emp);
        }

        [HttpPost, ActionName("QdhDelete")]
        public IActionResult QdhDeleteConfirmed(int id)
        {
            var emp = employees.FirstOrDefault(e => e.qdhEmpId == id);
            if (emp != null) employees.Remove(emp);
            return RedirectToAction("QdhIndex");
        }
    }
}
