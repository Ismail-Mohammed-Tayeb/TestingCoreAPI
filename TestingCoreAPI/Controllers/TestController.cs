using Microsoft.AspNetCore.Mvc;
using System;

namespace TestingCoreAPI.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        [Route("api/Test/Get")]

        public IActionResult Get() {
            return Ok(new Random().Next(0, 200));
        }

        [HttpGet]
        [Route("api/Test/GetBiggerRandom")]

        public int GetBiggerRandom()
        {
            return new Random().Next(500, 9999);
        }
        
        [HttpGet]
        [Route("api/Test/GetBigList")]

        public List<int> GetBigList()
        {
            List<int> res = new List<int>();
            for(int i =0; i< 9999; i++) res.Add(new Random().Next(500, 9999));
            return res;
        }

    }
}
