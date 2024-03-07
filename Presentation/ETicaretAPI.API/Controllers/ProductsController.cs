﻿
using ETicaretAPI.Application.Abstactions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        
            public ProductsController(IProductService productService)
        {
            _productService = productService;

        } 
        public IActionResult GetProducts()
    {
        var products = _productService.GetProducts();
        return Ok(products);
        }
    }
}
