using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenFrontendBE.Data;
using OpenFrontendBE.Dtos;
using OpenFrontendBE.Models;

namespace OpenFrontendBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly OfdbContext _db;

        public CategoryController(OfdbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<Category[]>> GetCategories()
        {
            var categories = _db.Categories.ToList();

            return Ok(categories);
        }

        [HttpPost]
        public async Task<ActionResult<Category>> AddCategory(CategoryDto categoryDto)
        {
            if (!ModelState.IsValid)
            {
               return BadRequest(ModelState);
            }

            var newCategory= new Category
            {
                CategoryName= categoryDto.CategoryName,
                Icon= categoryDto.Icon,
                TotalCount=0
            };
            _db.Categories.Add(newCategory);
            _db.SaveChanges();
            return Ok(newCategory);

        }
      

    }
}
