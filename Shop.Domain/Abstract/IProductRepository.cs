using Shop.Domain.Entities;
using System.Collections.Generic;


namespace Shop.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
