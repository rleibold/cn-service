using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace cn_service.Controllers.v1
{
    
    [Route("api/v1/chucknorris")]
    [ApiController]
    public class ChuckNorrisController : ControllerBase
    {
        private readonly ILogger<SampleController> logger;
        
        public ChuckNorrisController(ILogger<SampleController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return new ObjectResult(id); // TODO - should return real value
        }

        /*
        public IEnumerable<TodoItem> GetAll()
        {
            ToDoItems.GetAll();
        }
        */
         
    }

}