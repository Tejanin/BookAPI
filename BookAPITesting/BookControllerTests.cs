using BookAPI.Controllers;
using BookAPI.Models.ResponseModels;
using BookAPI.UnitOfWork;
using Moq;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace BookAPITesting
{
    public class BookControllerTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly BookController _controller;

        public BookControllerTests()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _controller = new BookController(_mockUnitOfWork.Object);
        }


        [Fact]
        public async Task GetAllBooks_ReturnsNoContent_WhenNoBooksExist()
        {
            // Arrange

            _mockUnitOfWork.Setup(uof => uof.Books.GetAllBooks()).ReturnsAsync(new List<BookResponseModel>());

            // Act

            var result =await _controller.GetAllBooks();

            //Assert
           
            result.Should().BeOfType<NoContentResult>();
            
        }
    }
}