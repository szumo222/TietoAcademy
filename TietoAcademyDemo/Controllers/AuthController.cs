using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TietoAcademyDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet("protected")]
        public string ProtectedEndpoint()
        {
            return "Protected Ednpoint";
        }

        [HttpGet("notprotected")]
        [AllowAnonymous]
        public string NotProtectedEndpoint()
        {
            return "Not protected Ednpoint";
        }
    }
}