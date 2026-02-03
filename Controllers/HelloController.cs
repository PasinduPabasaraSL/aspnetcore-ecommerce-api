using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts.Hello;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    private readonly IHelloService _service;
    
    public HelloController(IHelloService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<HelloResponse> Get()
        => Ok(_service.GetHello());

    [HttpPost]
    public ActionResult<HelloResponse> Create([FromBody] CreateHelloRequest body)
        => Ok(_service.Create(body));
    
}
