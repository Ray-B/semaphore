using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Signal.API.DTOs.Food;

namespace Signal.API.Controllers.Foods
{
    [Route("api/[controller]")]
    [ApiController]
    //TODO: Add an error response type attribute [ErrorResponseType] 
    public class FoodsController : ControllerBase
    {
        [Route("id:long")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var foods = new List<FoodDto>();

            return Ok(foods);
        }
    }
}