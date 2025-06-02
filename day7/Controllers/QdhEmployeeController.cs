using Microsoft.AspNetCore.Mvc;
using day7.Models; // hoặc đúng namespace chứa QdhEmployee

namespace day7.Controllers
{
    public class QdhEmployeeController : Controller
    {
        public class QdhEmployeeController : Controller
        {
            public static readonly List<QdhEmployee> QdhEmployee = new List<QdhEmployee>()
        {
            new QdhEmployee {  QdhName = "Kien", QdhBirthDay = new DateTime(2005, 10, 2), QdhEmail = "Quachduchuy02@gmail.com", QdhPhone = "0379661833", QdhSalary = "1000", QdhStatus = 1 },
            new QdhEmployee {  QdhName = "member2", QdhBirthDay = new DateTime(2005, 10, 2) , QdhEmail = "Quachduchuy03@gmail.com", QdhPhone = "0359661833", QdhSalary = "1000", QdhStatus = 2 },
            new QdhEmployee {  QdhName = "member3", QdhBirthDay = new DateTime(2005, 10, 2), QdhEmail = "Quachduchuy04@gmail.com", QdhPhone = "0374661833", QdhSalary = "1000", QdhStatus = 1 },
            new QdhEmployee {  QdhName = "member4", QdhBirthDay = new DateTime(2005, 10, 2), QdhEmail = "Quachduchuy05@gmail.com", QdhPhone = "0179661833", QdhSalary = "1000", QdhStatus = 1 },
            new QdhEmployee {  QdhName = "member5", QdhBirthDay = new DateTime(2005, 10, 2), QdhEmail = "Quachduchuy06@gmail.com", QdhPhone = "0123618339", QdhSalary = "1000", QdhStatus = 2 }
        };

            public IActionResult QdhIndex1()
            {
                ViewBag.QdhEmployee = QdhEmployee;
                return View();
            }
            public IActionResult QdhCreate()
            {
                return View();
            }
            [HttpPost] // hành động gọi ứng với method là POST
            public IActionResult QdhCreateSubmit(QdhEmployee employee)
            {
                //// Gán mã MemberId mới (kiểu Guid)
                //employee.QdhId = Guid.NewGuid().ToString();

                // Thêm đối tượng member vào danh sách
                QdhEmployee.Add(employee);

                // Chuyển hướng về trang danh sách thành viên
                return RedirectToAction("QdhIndex1");
            }
            //  GET: /TvcEmployee/TvcEdit/id?
            public IActionResult QdhEdit(int id)
            {
                var model = QdhEmployee.FirstOrDefault(x => x.QdhId == id);
                return View(model);
            }
            [HttpPost]
            public IActionResult QdhEdit(QdhEmployee employee)
            {
                var existing = QdhEmployee.FirstOrDefault(x => x.QdhId == employee.QdhId);
                if (existing != null)
                {
                    existing.QdhName = employee.QdhName;
                    existing.QdhBirthDay = employee.QdhBirthDay;
                    existing.QdhEmail = employee.QdhEmail;
                    existing.QdhPhone = employee.QdhPhone;
                    existing.QdhSalary = employee.QdhSalary;
                    existing.QdhStatus = employee.QdhStatus;
                }

                return RedirectToAction("QdhIndex1");
            }

            public IActionResult QdhDetails(int id)
            {
                var employee = QdhEmployee.FirstOrDefault(e => e.QdhId == id);
                if (employee == null)
                {
                    return NotFound();
                }
                return View(employee);
            }
            // GET: Hiển thị xác nhận xóa
            public IActionResult QdhDelete(int id)
            {
                var employee = QdhEmployee.FirstOrDefault(e => e.QdhId == id);
                if (employee == null)
                {
                    return NotFound();
                }
                return View(employee);
            }

            // POST: Xóa nhân viên
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult QdhDelete(int id, IFormCollection collection)
            {
                try
                {
                    var employee = QdhEmployee.FirstOrDefault(e => e.QdhId == id);
                    if (employee != null)
                    {
                        QdhEmployee.Remove(employee);
                    }
                    return RedirectToAction(nameof(QdhIndex1));
                }
                catch
                {
                    return View();
                }
            }
        }
    }
}
    