using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BookDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //// GET: api/<BookDetailsController>
        //[HttpGet("{bookId}")]
        //public IActionResult GetAllBooks(string bookId)
        //{
        //    var userId = User.FindFirstValue("id");
        //    var bookReviews = _context.Reviews.Where(r => r.BookId == bookId).Select(r => new BookDetailsDto
        //    {
        //        Reviews = _context.Reviews.Select(review => new ReviewWithUserDto
        //        {
        //            Id = review.Id,
        //            BookId = review.BookId,
        //            Text = review.Text,
        //            Rating = review.Rating,
        //            User = new UserForDisplayDto
        //            {
        //                Id = review.User.Id,
        //                FirstName = review.User.FirstName,
        //                LastName = review.User.LastName,
        //                UserName = review.User.UserName,
        //            }

        //        }).ToList(),
        //        AverageRating = _context.Reviews.Select(rating => new ReviewWithUserDto
        //        {
        //            Rating=rating.Rating.Average()
        //        }
        //    });
            
        //    return StatusCode(200, bookReviews);
        //}

        //// GET api/<BookDetailsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<BookDetailsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<BookDetailsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<BookDetailsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
