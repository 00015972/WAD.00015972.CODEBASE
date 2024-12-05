using Microsoft.AspNetCore.Mvc;
using Back_End_00015972.Models;
using Back_End_00015972.Repositories;
/*  My Studen ID: 00015972   */
namespace Back_End_00015972.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KeyController : ControllerBase
    {
        private readonly IKeyRepository_00015972 _repository;

        public KeyController(IKeyRepository_00015972 repository)
        {
            _repository = repository;
        }

        // GET: api/Key
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KeyItem_00015972>>> GetKeys()
        {
            var keys = await _repository.GetAllKeysAsync();
            return Ok(keys);
        }

        // GET: api/Key/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KeyItem_00015972>> GetKey(int id)
        {
            var key = await _repository.GetKeyByIdAsync(id);
            if (key == null)
            {
                return NotFound();
            }
            return Ok(key);
        }

        // POST: api/Key
        [HttpPost]
        public async Task<ActionResult> CreateKey(KeyItem_00015972 key)
        {
            await _repository.AddKeyAsync(key);
            await _repository.SaveAsync();
            return CreatedAtAction(nameof(GetKey), new { id = key.Id }, key);
        }

        // PUT: api/Key/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateKey(int id, KeyItem_00015972 key)
        {
            if (id != key.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateKeyAsync(key);
            await _repository.SaveAsync();
            return NoContent();
        }

        // DELETE: api/Key/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKey(int id)
        {
            await _repository.DeleteKeyAsync(id);
            await _repository.SaveAsync();
            return NoContent();
        }
    }
}