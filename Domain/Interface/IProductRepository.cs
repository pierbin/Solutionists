using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
