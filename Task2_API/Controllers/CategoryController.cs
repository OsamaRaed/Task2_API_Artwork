using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2_API.Core.DTO;
using Task2_API.Service.Services.Category;

namespace Task2_API.Controllers
{
    public class CategoryController : BaseController
    {
        private ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        // GET: CategoryController
        [HttpGet]
        public IActionResult Index()
        {
            var categories = _service.Index();
            return Ok(GetRespons(categories));
        }

        // GET: CategoryController/Details/5
        [HttpGet]

        public IActionResult Details(int id)
        {
            var category = _service.Details(id);
            return Ok(GetRespons(category));
        }

        // POST: CategoryController/Create
        [HttpPost]
        public IActionResult Create([FromBody] CreateCategoryDTO dTO)
        {
            _service.Create(dTO);
            return Ok(GetRespons());
        }

        // POST: CategoryController/Update/
        [HttpPut]
        public IActionResult Update([FromBody] UpdateCategoryDTO dTO)
        {
            _service.Update(dTO);
            return Ok(GetRespons());
        }
        // Delete: CategoryController/Delete/5
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok(GetRespons());
        }
    }
}
