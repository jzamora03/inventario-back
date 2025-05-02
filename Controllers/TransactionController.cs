using Microsoft.AspNetCore.Mvc;
using InventoryAPI.Repositories;
using InventoryAPI.Models;
using InventoryAPI.Data;

namespace InventoryAPI.Controllers
{
    [Route("api/transactions")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionRepository _repository;
        private readonly InventoryDbContext _context;

        public TransactionController(TransactionRepository repository, InventoryDbContext context)
        {
            _repository = repository;
            _context = context; 
        }


        [HttpPost]
     public async Task<IActionResult> ProcessTransaction([FromBody] Transaction transaction)
     {
        var success = await _repository.ProcessTransaction(transaction);

        if (success)
        {
            return Ok(new { ok = true, message = "Transacción completada." });
        }
        else
        {
            return BadRequest(new { ok = false, message = "Error al procesar la transacción." });
        }
     }
    }
}