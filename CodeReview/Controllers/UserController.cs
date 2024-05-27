using CodeReview.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeReview.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] uint id)
        {
            var result = await _service.Delete(id);
            if(!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
