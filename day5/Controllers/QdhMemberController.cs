using Microsoft.AspNetCore.Mvc;
using QdhLesson5.Models.DataModel;
using System.Runtime.Serialization.DataContracts;
namespace QdhLesson5.Controllers
{
    public class QdhMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult QdhGetMember()
        {
            var QdhMember = new QdhMember();
            QdhMember.QdhMemberID = Guid.NewGuid().ToString();
            QdhMember.QdhUserName = "QdhUserName";
            QdhMember.QdhFullName = "QdhFullName";
            QdhMember.QdhPassword = "QdhPassword";
            QdhMember.QdhEmail = "QdhEmail";
            ViewBag.QdhMember = QdhMember;
            return View();
        }
    }
}