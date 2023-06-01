using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstracts;

namespace FForum.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService; 
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = categoryService.GetAll();
            return (result.Success) ? Ok(result) : BadRequest();
        }


        [HttpGet("getallwithsubcategories")]
        public IActionResult GetAllWithSubCategory()
        {
            var result = categoryService.GetAllWithSubCategory();
            return (result.Success) ? Ok(result) : BadRequest();
        }
        
    }
}
