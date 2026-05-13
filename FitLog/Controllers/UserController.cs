using FitLog.Dto;
using FitLog.Exceptions;
using FitLog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IUserService _userService;

        public UserController(IUserService userService) {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);
                return Ok(user);
            } catch (UserNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var user = await _userService.GetAllUsersAsync();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserDto user)
        {
            try
            {
                var createdUser = await _userService.CreateUserAsync(user);
                return CreatedAtAction(nameof(GetById), new { id = createdUser.Id }, null);
            }
            catch (InvalidOperationException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] UserDto user)
        {
            try
            {
                var userUpdated = await _userService.UpdateUserAsync(id, user);
                return Ok(userUpdated);
            }
            catch (UserNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                await _userService.DeleteUser(id);
                return NoContent();
            }
            catch (UserNotFoundException e)
            {
                return NotFound(e.Message);
            }

        }
    }
}
