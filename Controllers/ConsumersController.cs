using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using uniqAPI.Models;
using uniqAPI.data;
using uniqAPI.Service;

namespace uniqAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumersController : ControllerBase
    {
        private readonly IService _service;

        public ConsumersController(IService service)
        {
            _service = service;
        }

        // GET: api/Consumers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Consumer>>> GetConsumerTable()
        {
           var data= await _service.GetConsumerListAsync();
            return Ok(data);
        }

        // GET: api/Consumers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Consumer>> GetConsumer(int id)
        {
            var consumer = await _service.GetConsumerByIdAsync(id);

            if (consumer == null)
            {
                return NotFound();
            }

            return Ok(consumer);
        }

        // PUT: api/Consumers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsumer(int id, Consumer consumer)
        {
            if (id != consumer.Id)
            {
                return BadRequest("Id mismtach");
            }
           await  _service.EditConsumerAsync(consumer);
            return Ok("Edited successfully");
        }

        // POST: api/Consumers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Consumer>> PostConsumer(Consumer consumer)
        {
            await _service.CreateConsumerAsync(consumer);


            return Ok("created");
        }

        // DELETE: api/Consumers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsumer(int id)
        {
             await _service.DeleteConsumerAsync(id);
      
            return Ok("Deleted succefully");
        }

      
    }
}
