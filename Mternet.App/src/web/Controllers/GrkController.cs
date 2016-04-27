using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace web.Controllers
{
    public class GrkController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var items = new List<string>
            {
                "https://drive.google.com/folderview?id=0B2XjVl8PRUcDY3ZZUUotWWVEQ28&usp=sharing"

            };

            return View(items);
        }

       
    }
}
