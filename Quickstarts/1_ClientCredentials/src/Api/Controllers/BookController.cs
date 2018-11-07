using System.Collections.Generic;
using Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    //[Produces("application/json")]
    [Route("api/book")]
    [Authorize("bookPolicy")]
    public class BookController : ControllerBase
    {
        // GET: api/Book
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(new Book[] {
                new Book() {
                    Author = "James Joyce",
                    Title = "Ulysses"
                },
                new Book() {
                    Author = "M. oi",
                    Title = "The secret life of me"
                }
            });
        }
    }
}
