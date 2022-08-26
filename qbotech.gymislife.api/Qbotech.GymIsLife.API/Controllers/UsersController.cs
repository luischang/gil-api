using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Qbotech.GymIsLife.Core.Domain.Interfaces;

namespace Qbotech.GymIsLife.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }


        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var usersList = await _usersRepository.GetAll();
            return Ok(usersList);
        }


    }
}
