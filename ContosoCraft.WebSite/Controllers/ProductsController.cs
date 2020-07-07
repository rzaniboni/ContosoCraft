using System.Collections.Generic;
using ContosoCraft.WebSite.Models;
using ContosoCraft.WebSite.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCraft.WebSite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }
        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
    }
}