using ECommerce.Server.Repositories.Interfaces;
using ECommerce.Shared.DTO;
using ECommerce.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo productRepo;
        public ProductController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }

        //Add Product
        [HttpPost("Add-Product")]
        public async Task<ActionResult<ServiceModel>> AddProduct(Product NewProduct)
        {
            return Ok(await productRepo.AddProduct(NewProduct));
        }

        //All Product
        [HttpGet]
        public async Task<ActionResult<ServiceModel>> GetProducts()
        {
            return Ok(await productRepo.GetProducts());
        }

        //Single Product
        [HttpGet("Get-Product/{ProductId:int}")]
        public async Task<ActionResult<ServiceModel>> GetProduct(int ProductId)
        {
            return Ok(await productRepo.GetProduct(ProductId));
        }

        //Delete Product
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ServiceModel>> DeleteProduct(int id)
        {
            return Ok(await productRepo.DeleteProduct(id));
        }

        //Update Product
        [HttpPut]
        public async Task<ActionResult<ServiceModel>> UpdateProduct(Product newProduct)
        {
            return Ok(await productRepo.UpdateProduct(newProduct));
        }
    }
}
