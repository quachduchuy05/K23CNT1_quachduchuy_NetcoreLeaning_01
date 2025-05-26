using Microsoft.AspNetCore.Mvc;
using QdhLab06.Models;

namespace QdhLab06.Controllers
{
    public class QdhEmployeeController : Controller
    {
        public static readonly List<QdhEmployee> QdhEmployee = new List<QdhEmployee>()
        {
            new QdhEmployee {  QdhName = "huy", QdhBirthDay = new DateTime(2005, 10, 2), QdhEmail = "huychuoi@gmail.com", QdhPhone = "0123456789", QdhSalary = "1000", QdhStatus = 1 },
            new QdhEmployee {  QdhName = "member2", QdhBirthDay = new DateTime(2005, 10, 2) , QdhEmail = "nguyenvukien03@gmail.com", QdhPhone = "0359661833", QdhSalary = "1000", QdhStatus = 2 },
            new QdhEmployee {  QdhName = "member3", QdhBirthDay = new DateTime(2005, 10, 2), QdhEmail = "nguyenvukien04@gmail.com", QdhPhone = "0374661833", QdhSalary = "1000", QdhStatus = 1 },
            new QdhEmployee {  QdhName = "member4", QdhBirthDay = new DateTime(2005, 10, 2), QdhEmail = "nguyenvukien05@gmail.com", QdhPhone = "0179661833", QdhSalary = "1000", QdhStatus = 1 },
            new QdhEmployee {  QdhName = "member5", QdhBirthDay = new DateTime(2005, 10, 2), QdhEmail = "nguyenvukien06@gmail.com", QdhPhone = "0123618339", QdhSalary = "1000", QdhStatus = 2 }
        };

        public IActionResult QdhIndex()
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
            return RedirectToAction("QdhIndex");
        }

    }
}