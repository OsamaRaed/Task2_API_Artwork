using Microsoft.AspNetCore.Mvc;
using Task2_API.Core.DTO;
using Task2_API.Data.Models;
using Task2_API.Service.Services.Interest;

namespace Task2_API.Controllers
{

    public class InterestController : BaseController
    {
        private IInterestService _InterestService;
        public InterestController(IInterestService InterestService)
        {
            _InterestService = InterestService;
        }

        [HttpGet]
        // GET: InterestController

        public IActionResult Index()
        {
            var Interests = _InterestService.Index();
            return Ok(GetRespons(Interests));
        }
        [HttpGet]
        // GET: InterestController/Details/5

        public IActionResult Details(int id)
        {
            var Interest = _InterestService.Details(id);
            return Ok(GetRespons(Interest));
        }
        [HttpPost]
        // POST: InterestController/Create

        public IActionResult Create([FromBody] CreateInterestDTO dTO)
        {
            _InterestService.Create(dTO);
            return Ok(GetRespons());
        }
        [HttpPut]
        // Put: InterestController/Update

        public IActionResult Update([FromBody] UpdateInterestDTO dTO)
        {
            _InterestService.Update(dTO);
            return Ok(GetRespons());
        }
        // Delete: InterestController/Delete/5
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _InterestService.Delete(id);
            return Ok(GetRespons());
        }

    }
}
