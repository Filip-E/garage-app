using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using garage_app_bl.Services;

namespace WebApplication1.Controllers
{
    public class TokenController : ApiController
    {
        private AuthService _authService;

        public TokenController()
        {
            _authService = new AuthService();
        }

        [AllowAnonymous]
        public IHttpActionResult Get(string username, string password)
        {
            try
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
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        private bool CheckUser(string username, string password)
        {
            return true;
        }
    }
}