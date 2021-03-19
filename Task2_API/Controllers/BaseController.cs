using Microsoft.AspNetCore.Mvc;
using Task2_API.Core.ViewModels;

namespace Task2_API.Controllers
{
    [Route("api/[controller]/[action]")]

    public class BaseController : Controller
    {
        protected APIResponseViewModel GetRespons(object data = null, string message = "Done")
        {
            var result = new APIResponseViewModel();
            result.Status = true;
            result.Message = message;
            result.Data = data;
            return result;
        }
    }
}
