using EntityFramework.Models;
using EntityFramework.Repositories;
using EntityFramework.Servies;

namespace EntityFramework.Servies;
public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public List<Product> GetAll()
    {
        return _repository.GetAll();
    }

    public Product GetById(int id)
    {
        return _repository.GetById(id);
    }

    public void Add(Product product)
    {
        if (product.Price <= 0)
        {
            throw new Exception("Price must be greater than zero");
        }

        _repository.Add(product);
        _repository.Save();
    }

    public void Update(Product product)
    {
        _repository.Update(product);
        _repository.Save();
    }

    public void Delete(int id)
    {
        _repository.Delete(id);
        _repository.Save();
    }
}