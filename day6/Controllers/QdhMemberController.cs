using day6.Models.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace day6.Controllers
{
    public class QdhMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult QdhGetMember()
        {
            QdhMember member = new QdhMember();
            member.QdhMemberId = Guid.NewGuid().ToString();
            member.QdhUserName = "huy";
            member.QdhFullName = "quach duc huy";
            member.QdhEmail = "huychuoi@gmail.com";
            return View();
        }

    }
}
