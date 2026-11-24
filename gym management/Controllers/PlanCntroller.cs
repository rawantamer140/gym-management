using gym_management.contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace gym_management.Controllers
{
    public class PlanCntroller : Controller
    {

        private GymDbContext dbContext = new GymDbContext();
        public IActionResult IndexTest()
        {
            return View(); // return the view associated with this action

            //views/PlanCntroller/IndexTest.cshtml
            

        }


        public async Task<IActionResult> Index()
        {
            var plans = await dbContext.Plans.ToListAsync();
            return View(plans);
        }
    }
}
