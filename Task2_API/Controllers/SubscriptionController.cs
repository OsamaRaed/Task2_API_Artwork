using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2_API.Core.DTO;
using Task2_API.Service.Services.Subscription;

namespace Task2_API.Controllers
{
    public class SubscriptionController : BaseController
    {
        private ISubscriptionService _service;
        public SubscriptionController(ISubscriptionService service)
        {
            _service = service;
        }

        // GET: SubscriptionController
        [HttpGet]
        public IActionResult Index()
        {
            var Subscriptions = _service.Index();
            return Ok(GetRespons(Subscriptions));
        }

        // GET: SubscriptionController/Details/5
        [HttpGet]

        public IActionResult Details(int id)
        {
            var Subscription = _service.Details(id);
            return Ok(GetRespons(Subscription));
        }

        // POST: SubscriptionController/Create
        [HttpPost]
        public IActionResult Create([FromBody] CreateSubscriptionDTO dTO)
        {
            _service.Create(dTO);
            return Ok(GetRespons());
        }

        // POST: SubscriptionController/Update/
        [HttpPut]
        public IActionResult Update([FromBody] UpdateSubscriptionDTO dTO)
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
