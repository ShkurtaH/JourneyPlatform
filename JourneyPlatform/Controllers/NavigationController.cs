
using JourneyPlatform.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JourneyPlatform.Models;

namespace JourneyPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavigationController : ControllerBase
    {
        private readonly DataContext _context;


        public NavigationController (DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Navigation>>> Get()
        {
            var navigation = await _context.Navigations.ToListAsync();
            return Ok(navigation);
        }

        [HttpPost]
        public async Task<ActionResult<List<Navigation>>> AddNavigation(Navigation n)
        {
            var AddNavigation = _context.Navigations.Add(n);
            await _context.SaveChangesAsync();
            if (AddNavigation == null)
                return Ok("Failed");
            return Ok("Added succesfuly");
        }


        [HttpPut]
        public async Task<ActionResult<List<Navigation>>> UpdateNavigation(Navigation n)
        {
            var UpdateNavigation = await _context.Navigations.FindAsync(n.Id);
            if (UpdateNavigation == null)
                return BadRequest("Navigation not found.");

            UpdateNavigation.Title = n.Title;
            UpdateNavigation.Link = n.Link;
            UpdateNavigation.FeaturedImage = n.FeaturedImage;


            await _context.SaveChangesAsync();

            return Ok("Updated successfuly");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Navigation>>> DeleteNavigation(int id)
        {
            var DeleteNavigation = await _context.Navigations.FindAsync(id);
            if (DeleteNavigation == null)
                return BadRequest("Navigation not found.");

            _context.Navigations.Remove(DeleteNavigation);
            await _context.SaveChangesAsync();

            return Ok("Deleted successfuly");
        }
    }
}
