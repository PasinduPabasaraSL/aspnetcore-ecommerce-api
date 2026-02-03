using WebApplication1.Contracts.Hello;

namespace WebApplication1.Services.Interfaces;

public interface IHelloService
{
    HelloResponse GetHello();
    HelloResponse Create(CreateHelloRequest request);
}

