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

            if(addressings == null)
            {
                return BadRequest(new { error = "Unable to get data of addresses" });
            }

            return Ok(addressings);
        }

        [HttpGet("{addressingId}")]
        public async Task<IActionResult> GetAddressingById(int addressingId, CancellationToken cancellationToken = default)
        {
            var addressing = await _serviceManager.AddressingService.GetByIdAsync(addressingId, cancellationToken);

            if(addressing == null)
            {
                return BadRequest(new { error = "Unable to get address by id" });
            }

            return Ok(addressing);
        }

        [HttpPost]
        public async Task<IActionResult> AddAddressing([FromBody] AddressingDto addressingDto, CancellationToken cancellationToken = default)
        {
            var addressing = await _serviceManager.AddressingService.CreateAsync(addressingDto, cancellationToken);

            if(addressing == null)
            {
                return BadRequest(new { error = "Unable to add an address" });
            }

            return Ok(addressing);
        }

        [HttpPut("{addressingId}")]
        public async Task<IActionResult> UpdateAddressing(int addressingId, [FromBody] UpdateAddressingDto updateAddressingDto, CancellationToken cancellationToken = default)
        {
            try
            {
                await _serviceManager.AddressingService.UpdateAsync(addressingId, updateAddressingDto, cancellationToken);

                return Ok();
            }
            catch
            {
                return BadRequest(new { error = "Unable to update address" });
            }
        }

        [HttpDelete("{addressingId}")]
        public async Task<IActionResult> DeleteAddressing([FromBody] int addressingId, CancellationToken cancellationToken = default)
        {
            try
            {
                await _serviceManager.AddressingService.DeleteAsync(addressingId, cancellationToken);

                return Ok();
            }
            catch
            {
                return BadRequest(new { error = "Unable to delete address" });
            }
        }
    }
}
