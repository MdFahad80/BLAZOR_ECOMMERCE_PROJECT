using ECommerce.Shared.Models;
using ECommerce.Shared.DTO;

namespace ECommerce.Client.Service.InterfaceServices
{
    public interface IProductService
    {
         Task<ServiceModel> AddProduct(Product NewProduct);
         Task<ServiceModel> GetProducts();
         Task<ServiceModel> GetProduct(int ProductId);
        public Task<ServiceModel> UpdateProduct(Product NewProduct);
        public Task<ServiceModel> DeleteProduct(int ProductId);

    }
}
