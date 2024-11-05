using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestfulWeb.Application.Interface;
using RestfulWeb.Application.ViewModels;

namespace RestfulWeb.Controllers
{
    [ApiVersion("1.0")]
    [Route("[controller]/{version:apiversion}")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;
        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("user/{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var userViewModel = await _userAppService.GetUserById(id);
            return Ok(userViewModel);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("user")]
        public async Task<IActionResult> Get()
        {
            var userViewModel = await _userAppService.GetUserAll();
            return Ok(userViewModel);
        }

        [HttpPost]
        [Route("user")]
        public async Task<IActionResult> Post([FromBody] UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    Error = ModelState.Values.SelectMany(v => v.Errors).ToList()
                });
            }
            await _userAppService.CreateUser(model);
            return Ok();
        }
        [HttpPut]
        [Route("user")]
        public async Task<IActionResult> Put([FromBody] UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    Error = ModelState.Values.SelectMany(v => v.Errors).ToList()
                });
            }
            await _userAppService.UpdateUser(userViewModel);
            return Ok();
        }

        [HttpPost]
        [Route("user/{id:int}")]
        public async Task<IActionResult> Patch(int id)
        {
            await _userAppService.DenyUser(id);
            return Ok();
        }

        [HttpDelete]
        [Route("user/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userAppService.DeleteUser(id);
            return Ok();
        }
    }
}
