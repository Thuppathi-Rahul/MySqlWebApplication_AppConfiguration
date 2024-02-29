using MySqlWebApplication.Models;

namespace MySqlWebApplication.Services
{
    public interface IProductService
    {
        List<Products> GetProducts();
    }
}