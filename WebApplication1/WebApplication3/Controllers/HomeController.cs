using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository _repository;


        public HomeController(ILogger<HomeController> logger, IRepository repository)
        {
            _logger = logger;
            this._repository = repository;

        }

        public IActionResult Index()
        {



            _repository.CreateDatabase();
            _repository.addnewCustomer(new data.Entities.Customer()
            {
                CustId = "0012",
                FirstName = "Edward",
                LastName = "Johson",
                Address = "2 firs street",
                City = "Minneapolis",
                State = "MN",
                Email = "Ed.John@gmail.com",
                PhoneNumber = "612-425-5656",
                CreateDate = DateTime.Now,
                CreatedBy = "Abou"
            });
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}