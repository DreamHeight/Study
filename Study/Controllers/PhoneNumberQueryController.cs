using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Study.Controllers
{
    public class PhoneNumberQueryController : Controller
    {
        //
        // GET: /PhoneNumberQuery/

        public ActionResult Index()
        {
            return View();
        }

        #region 查询归属地
        public JsonResult DoQuery() {

            return Json("");
        }
        #endregion　查询归属地
    }
}
