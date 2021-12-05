using System.Collections.Generic;

namespace Domain.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}
