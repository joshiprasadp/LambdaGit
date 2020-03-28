using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cy.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    public class WltpController : ControllerBase
    {
        [HttpGet("api/wltp/list")]
        public IActionResult Get()
        {
            return Ok(new string[] { "test1", "test2" });
        }

        [HttpPost("api/wltp")]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}
