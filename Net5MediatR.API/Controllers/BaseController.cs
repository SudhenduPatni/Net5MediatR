using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5MediatR.API.Controllers
{
    [ApiController]
    public class BaseController : Controller
    {
        protected IActionResult GetResult<T>(IEnumerable<T> responseObject) where T : class
        {
            var responseState = responseObject?.Any();
            IActionResult actionResult = responseState.HasValue && responseState.Value ? Ok(responseState) : NoContent();
            return actionResult;
        }

        protected IActionResult GetResult<T>(T responseObject) where T : class
        {
            IActionResult actionResult = responseObject != null ? Ok(responseObject) : NoContent();
            return actionResult;
        }
    }
}
