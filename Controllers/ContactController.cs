using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationCore31.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            ContactDTO person = new ContactDTO() { FirstName = "Özgür", LastName = "Çelik" };
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody]ContactDTO person)
        {
            return Ok($"{person.FirstName} {person.LastName}");
        }
    }
}