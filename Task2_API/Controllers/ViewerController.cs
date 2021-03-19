using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2_API.Core.DTO;
using Task2_API.Service.Services.Viewer;

namespace Task2_API.Controllers
{
    public class ViewerController : BaseController
    {
        private IViewerService _service;
        public ViewerController(IViewerService service)
        {
            _service = service;
        }

        // GET: ViewerController
        [HttpGet]
        public IActionResult Index()
        {
            var Viewers = _service.Index();
            return Ok(GetRespons(Viewers));
        }

        // GET: ViewerController/Details/5
        [HttpGet]

        public IActionResult Details(int id)
        {
            var Viewer = _service.Details(id);
            return Ok(GetRespons(Viewer));
        }

        // POST: SubscriptionController/Create
        [HttpPost]
        public IActionResult Create([FromBody] CreateViewerDTO dTO)
        {
            _service.Create(dTO);
            return Ok(GetRespons());
        }

        // POST: SubscriptionController/Update/
        [HttpPut]
        public IActionResult Update([FromBody] UpdateViewerDTO dTO)
        {
            _service.Update(dTO);
            return Ok(GetRespons());
        }
        // Delete: SubscriptionController/Delete/5
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok(GetRespons());
        }
    }
}
