﻿using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavoritesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<FavoritesController>
        [HttpGet("myFavorites"), Authorize]
        public IActionResult GetUserFavorites()
        {
            string userId = User.FindFirstValue("id");
            var favorites = _context.Favorites.Where(f => f.UserId.Equals(userId));
            return StatusCode(200, favorites);
        }

        //// GET api/<FavoritesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<FavoritesController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Favorite favorite)
        {
            var userId = User.FindFirstValue("id");
            favorite.UserId = userId;
            _context.Favorites.Add(favorite);
            _context.SaveChanges();
            return StatusCode(201);

        }
        //// PUT api/<FavoritesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<FavoritesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
