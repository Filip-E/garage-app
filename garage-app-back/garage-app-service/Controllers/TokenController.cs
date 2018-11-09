using System.Web.Http;
using garage_app_bl.Services;

namespace garage_app_service.Controllers
{
    public class TokenController : ApiController
    {
        private readonly AuthService _authService;

        public TokenController()
        {
            _authService = new AuthService();
        }

        [AllowAnonymous]
        [Route("token/{username}/{password}")]
        public IHttpActionResult Get(string username, string password)
        {
            bool isUserAuthenticated = _authService.ValidateUser(username, password);
            if (isUserAuthenticated)
            {
                return Ok(JwtManager.GenerateToken(username));
            }
            else
            {
                return BadRequest("Wrong username and password combination");
            }
        }
    }
}