using Domain.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplicationArch.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeDetailsService _IEmployeeDetailsService;
        public EmployeeController(IEmployeeDetailsService IEmployeeDetailsService)
        {
            _IEmployeeDetailsService = IEmployeeDetailsService;
        }
        // GET: Employee
        public ActionResult Index()
        {
            List <EmployeeInfo> lstInfo = _IEmployeeDetailsService.GetEmployeeInfo();
            return View(lstInfo);
        }
    }
}