using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController
{
  [HttpGet]
  public string Get() => "Hello World!";
}
