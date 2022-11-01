using System.Runtime.CompilerServices;

namespace Internship2022WebAPI.Data
{
    public interface IStaticDatabase
    {
        List<Product> GetProducts();
        Product GetById(Guid id);
        Product AddProduct(Product product);

        Product RemoveProdcut(Product product);
    }
    public class StaticDatabase : IStaticDatabase
    {
        private List<Product> Products { get; set; } = new List<Product>();

        public List<Product> GetProducts()
        {
            return Products;
        }

        public Product AddProduct(Product product)
        {
            Products.Add(product);
            return product;
        }

        public Product RemoveProdcut(Product product)
        {
            Products.Remove(product);
            return product;
        }

        public Product GetById(Guid id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }
    }

}
