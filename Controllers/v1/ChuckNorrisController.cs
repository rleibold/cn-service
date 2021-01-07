using System.Collections.Generic;
using System.Threading.Tasks;
using cn_service.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace cn_service.Controllers.v1
{
    
    [Route("api/v1/chucknorris")]
    [ApiController]
    public class ChuckNorrisController : ControllerBase
    {
        private readonly ILogger<SampleController> logger;
        private readonly ChuckNorrisContext _chuckNorrisContext;
        
        public ChuckNorrisController(ILogger<SampleController> logger, ChuckNorrisContext chuckNorrisContext)
        {
            this.logger = logger;
            this._chuckNorrisContext = chuckNorrisContext;
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<ChuckNorrisItem>> GetById(string id)
        {
            var items = await _chuckNorrisContext.ChuckNorrisItems.FindAsync(id);
            
            if (items == null) 
            {
                return NotFound();
            }

            return items;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChuckNorrisItem>>> GetChuckNorrisItems()
        {
            return await _chuckNorrisContext.ChuckNorrisItems.ToListAsync();
        }

    }

}