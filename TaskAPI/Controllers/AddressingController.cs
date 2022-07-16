using Contracts;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressingController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public AddressingController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetAddressings(CancellationToken cancellationToken = default)
        {
            var addressings = await _serviceManager.AddressingService.GetAllAsync(cancellationToken);

            return Ok(addressings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressingById(int id, CancellationToken cancellationToken = default)
        {
            var addressing = await _serviceManager.AddressingService.GetByIdAsync(id, cancellationToken);

            return Ok(addressing);
        }

        [HttpPost]
        public async Task<IActionResult> AddAddressing([FromBody] AddressingDto addressingDto, CancellationToken cancellationToken = default)
        {
            var addressing = await _serviceManager.AddressingService.CreateAsync(addressingDto, cancellationToken);

            return Ok(addressing);
        }

        [HttpPut("{addressingId}")]
        public async Task UpdateAddressing(int addressingId, [FromBody] UpdateAddressingDto updateAddressingDto, CancellationToken cancellationToken = default)
        {
            await _serviceManager.AddressingService.UpdateAsync(addressingId, updateAddressingDto, cancellationToken);
        }

        [HttpDelete("{addressingId}")]
        public async Task DeleteAddressing([FromBody] int addressingId, CancellationToken cancellationToken = default)
        {
            await _serviceManager.AddressingService.DeleteAsync(addressingId, cancellationToken);
        }
    }
}
