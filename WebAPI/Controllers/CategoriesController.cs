using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {

            var result = _categoryService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbyid")]

        public IActionResult GetByCategoryId(int Id)
        {

            var result = _categoryService.GetById(Id);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("add")]

        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }

        [HttpPost("update")]

        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }

        [HttpPost("delete")]

        public IActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }

    }
}
