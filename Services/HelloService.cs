using WebApplication1.Contracts.Hello;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Services;

public class HelloService : IHelloService
{
    public HelloResponse GetHello()
        => new("Hello from my API", DateTime.UtcNow);
    
    public HelloResponse Create(CreateHelloRequest request)
        => new($"Saved: {request.Text}",DateTime.UtcNow);
}

