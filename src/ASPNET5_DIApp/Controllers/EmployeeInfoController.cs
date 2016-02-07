using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ASPNET5_DIApp.Models;
using ASPNET5_DIApp.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNET5_DIApp.Controllers
{
    public class EmployeeInfoController : Controller
    {

        public IService<EmployeeInfo> _service { get; set; }
        public EmployeeInfoController(IService<EmployeeInfo> srv)
        {
            _service = srv;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var Emps = _service.Get();
            return View(Emps);
        }
    }
}
