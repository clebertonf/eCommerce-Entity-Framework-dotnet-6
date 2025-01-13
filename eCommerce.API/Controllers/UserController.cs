using eCommerce.API.Repositories;
using eCommerce.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers;

[ApiController]
[Route("/api")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    
    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    [Route("/health-check")]
    public IActionResult HealthCheck()
    {
        return Ok(new { message = "it's alive!"});
    }

    [HttpGet]
    [Route("/users")]
    public async Task<IActionResult> GetUsers()
    {
        return Ok(await _userRepository.GetUsersAsync());
    }

    [HttpGet]
    [Route("/users/{id}")]
    public async Task<IActionResult> GetUser(int id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user is null)
            return NotFound();
        
        return Ok(user);
    }

    [HttpPost]
    [Route("/user")]
    public async Task<IActionResult> AddUser([FromBody] User user)
    {
        await _userRepository.AddUserAsync(user);
        return Ok(user);
    }

    [HttpPut]
    [Route("/user/{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
    {
        if(id != user.Id)
            return BadRequest();

        await _userRepository.UpdateUserAsync(user);
        return Ok(user);
    }

    [HttpDelete]
    [Route("/user/{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        await _userRepository.DeleteUserAsync(id);
        return NoContent();
    }
}