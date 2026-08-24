using EntityFramework.Data;
using EntityFramework.Models;

namespace EntityFramework.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;
    public ProductRepository(AppDbContext context)
    {
        _context=context;
    }

    public List<Product> GetAll()
    {
        return _context.Products.ToList();
    }
    public Product GetById(int id)
    {
        return _context.Products.FirstOrDefault(p => p.Id == id);
    }
    public void Add(Product product)
    {
        _context.Products.Add(product);
    }

    public void Update(Product product)
    {
        _context.Products.Update(product);
    }
    public void Delete(int id)
    {
        var product=_context.Products.FirstOrDefault(product=>product.Id==id);
        if (product != null)
        {
            _context.Products.Remove(product);
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}