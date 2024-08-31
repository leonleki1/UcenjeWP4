using Microsoft.AspNetCore.Mvc;
using WebApiPaulovnija.Data;

namespace WebApiPaulovnija.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class Radnicicontroller : ControllerBase
    {
        private readonly Paulovnijacontext _context;

        public Radnicicontroller(Paulovnijacontext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Radnik);
        }



    }
}



