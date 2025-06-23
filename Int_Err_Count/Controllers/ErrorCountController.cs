using Int_Err_Count.Data;
using Int_Err_Count.Models;
using Microsoft.AspNetCore.Mvc;

namespace Int_Err_Count.Controllers
{
    public class ErrorCountController(UserDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var data = context.ErrorCount.ToList();
            var model = new ErrorCountViewModel()
            {
                ErrorCounts = data
            };
            return View(model);
        }

        public async Task<IActionResult> AddData(ErrorCount errcount)
        {
            context.Add(errcount);
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult AddForm()
        {
            return View();
        }
    }
}
