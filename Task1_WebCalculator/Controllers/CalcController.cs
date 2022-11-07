using Microsoft.AspNetCore.Mvc;
using Task1_WebCalculator.Models;

namespace Task1_WebCalculator.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public IActionResult Index(Calculator c, string operation)
        {
            if (operation == "add")
            {
                c.result = c.num1 + c.num2;
            } 
            else if (operation == "sub")
            {
                c.result = c.num1 - c.num2;
            }
            else if (operation == "mul")
            {
                c.result = c.num1 * c.num2;
            }
            else if (operation == "div")
            {
                c.result = c.num1 / c.num2;
            }

            return View(c);
        }
    }
}
