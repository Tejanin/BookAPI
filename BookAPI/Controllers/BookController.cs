using BookAPI.Models.Entities;
using BookAPI.Models.DTOs;
using BookAPI.Models.ResponseModels;
using BookAPI.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookAPI.Handlers;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookController(IUnitOfWork unitOfWork) =>  _unitOfWork = unitOfWork;



        [HttpGet]
        [Route("getAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _unitOfWork.Books.GetAllBooks();

            if(!books.Any()) return NoContent();
            return Ok(books);
        }

        [HttpPost]
        [Route("addBook")]
        public async Task<IActionResult> AddBook(BookDTO book)
        {
            try
            {
                await _unitOfWork.Books.AddBook(book);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
            

            
        }

        [HttpPost]
        [Route("uploadBook")]
        public IActionResult uploadBook(IFormFile file)
        {
           UploadHandler handler = new UploadHandler();
           return Ok(handler.Upload(file));


        }



    }
}
