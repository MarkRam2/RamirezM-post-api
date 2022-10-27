using Microsoft.AspNetCore.Mvc;
using post_api.Model;

namespace post_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PostApiController : ControllerBase
{
    [HttpGet]
    [Route("Hello")]

    public string SayHello(SayHelloModel name)
    {
        return "say hello " + name.userName + name.lastName;
    }

    [HttpGet]
    [Route("Adding")]
    public string Adding(AddingModel Number)
    {
        return "we are adding two numbers" + (Number.num1 + Number.num2);
    }

}
