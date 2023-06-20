using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OmniAPI.Domain.Models;

namespace OmniAPI.Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthController : ControllerBase
    {
        private readonly IAsyncRepository<User> _repository;
        private readonly IPasswordHasher _passwordHasher;

        public Register(IAsyncRepository<User> repository,
            IPasswordHasher passwordHasher)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
        }

        /// <summary>
        /// Creates a new User
        /// </summary>
        [HttpPost("[namespace]/Register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public override async Task<ActionResult> HandleAsync([FromBody] RegisterUserCommand request,
            CancellationToken cancellationToken = default)
        {
            var existingUsers = await _repository.ListByExpressionAsync(u => u.Email == request.Email, cancellationToken);

            if (existingUsers.Any()) return BadRequest("User with email already exists");

            var user = new User(request.Email, _passwordHasher.HashPassword(request.Password));

            await _repository.AddAsync(user, cancellationToken);

            return Ok(user.Id);
        }
        // GET: UserController
        [HttpPost]
        public ActionResult Login()
        {
            return Ok();
            //TODO
        }
        [HttpPost]
        public ActionResult Register()
        {
            return Ok();
            //TODO
        }

    }
}
