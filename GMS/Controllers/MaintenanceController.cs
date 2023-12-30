using GMS.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace GMS.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MaintenanceController : Controller
    {
        private DBContext _Context = new DBContext();
        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch (System.Exception ex)
            {
				throw ex;
			}
        }

        public JsonResult getMembersList()
        {
            try
            {
                var list = JsonConvert.SerializeObject(_Context.GetMembersList());
                TempData["MembersList"] = list;
                return Json(list);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
