using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.Interfaces;
using Models;

namespace DependencyInjectionExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReportingService _reportingService;
        private readonly ILoggingService _loggingService;
        private readonly IDatabaseService<BaseModel> _databaseService;
        public HomeController(ILoggingService logService, IDatabaseService<BaseModel> dbService, IReportingService reportService)
        {
            _loggingService = logService;
            _databaseService = dbService;
            _reportingService = reportService;
        }
        // GET: Home
        public ActionResult Index()
        {
            @ViewData["LoggingServiceMessage"] = _loggingService.Log("print this text");
            @ViewData["ReportingServiceMessage"] = _reportingService.GetReportText();
            @ViewData["DatabaseServiceMessage"] = _databaseService.Get().ToString();
            return View();
        }
    }
}