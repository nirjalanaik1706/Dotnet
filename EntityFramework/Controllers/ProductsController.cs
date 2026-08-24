using Microsoft.AspNetCore.Mvc;
using EntityFramework.Models;
using EntityFramework.Servies;

namespace EntityFramework.Servies;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;

    public ProductsController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var products = _service.GetAll();

        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = _service.GetById(id);

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost]
    public IActionResult Add(Product product)
    {
        _service.Add(product);

        return Ok(product);
    }

    [HttpPut]
    public IActionResult Update(Product product)
    {
        _service.Update(product);

        return Ok(product);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);

        return Ok();
    }
}