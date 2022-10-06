using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using JourneyPlatform.Data;
using JourneyPlatform.Models;

namespace JourneyPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DashboardController : Controller
    {

        private readonly DataContext _context;

        public DashboardController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Dashboard>>> Get()
        {
            var countRoles = await _context.Roles.CountAsync();
            var countUser = await _context.Users.CountAsync();
           // var countNewsCategories = await _context.NewsCategories.CountAsync();
            //var countAccomodationCategories = await _context.AccomodationCategories.CountAsync();
            var countNavigation = await _context.Navigations.CountAsync();
           // var countLocation = await _context.Location.CountAsync();


            var result = new Dashboard
            {
                CountRoles = countRoles,
                CountUser = countUser,
                //CountNewsCategories = countNewsCategories,
                //CountAccomodationCategories = countAccomodationCategories,
                CountNavigation = countNavigation,
               // CountLocation = countLocation,

            };

            return Ok(result);
        }
    }
}