using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpenseManager.Web.Controllers
{
    public class ExpenseController : Controller
    {
        // GET: Expense
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
    }
}