using Microsoft.AspNetCore.Mvc;

namespace WebApi2.Controllers
{
    public class User
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public string Token { get; set; }


    }
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {


        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new User()
            {

                Id = 1,
                Name = "test",
                Token = new Guid().ToString()



            });
        }
        [HttpPost]
        public ActionResult Post(User user)
        {
            return Ok("Gönderilen değer"+user.Name);
        }
    }
}
