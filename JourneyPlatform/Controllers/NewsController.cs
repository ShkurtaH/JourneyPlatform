using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JourneyPlatform.Models;

//namespace JourneyPlatform.Controllers
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NewsController : ControllerBase
    {
        private readonly DataContext _context;


        public NewsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<News>>> Get()
        {
            var News = await _context.News.ToListAsync();
            return Ok(Food);
        }

        [HttpPost]
        public async Task<ActionResult<List<News>>> AddNews(News news)
        {
            var AddNews = _context.News.Add(news);
            await _context.SaveChangesAsync();
            if (AddNews == null)
                return Ok("Failed");
            return Ok("Added succesfuly");
        }


        [HttpPut]
        public async Task<ActionResult<List<Food>>> UpdateFood(Food f)
        {
            var newsUpdate = await _context.News.FindAsync(n.Id);
            if (newsUpdate == null)
                return BadRequest("News not found.");

            newsUpdate.Title = n.Title;
            newsUpdate.Description = n.Description;
            newsUpdate.Category = n.Category;
            newsUpdate.Date = n.Date;


        await _context.SaveChangesAsync();

            return Ok("Updated successfuly");
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<News>>> DeleteNews(int Id)
        {
            var newsDelete = await _context.News.FindAsync(id);
            if (newsDelete == null)
                return BadRequest("News not found.");

            _context.News.Remove(newsDelete);
            await _context.SaveChangesAsync();

            return Ok("Deleted successfuly");
        }
    }
}
