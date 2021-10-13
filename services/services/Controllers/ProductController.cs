using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using services.DbContexts;
using services.Enitities;
using services.Enitities.Request;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationContext appContext;
        public ProductController(ApplicationContext applicationContext)
        {
            appContext = applicationContext;
        }
        [HttpGet("getproducts")]
        public IActionResult GetProducts()
        {
            return Ok(appContext.Products.ToList());
            //return appContext.Products.Select(x => new Product()
            //{
            //    Id = x.Id,
            //    ProductName = x.ProductName,
            //    ProductCode = x.ProductCode,
            //    ReleaseDate = x.ReleaseDate,
            //    ImageUrl = x.ImageUrl,
            //    CreatedDate = x.CreatedDate,
            //    DeletedDate = x.DeletedDate
            //}
            //).ToList();
        }
        [HttpGet("getproduct/{productId}")]
        public Product GetProduct(int productId)
        {
            return appContext.Products.AsQueryable().Where(x => x.Id == productId).FirstOrDefault();

        }
        [HttpDelete("deleteproduct/{productId}")]
        public bool DeleteProduct(int productId)
        {
            try
            {
                var product = appContext.Products.Where(x => x.Id == productId).FirstOrDefault();
                appContext.Products.Remove(product);
                appContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost("addproduct")]
        public IActionResult AddProduct(ProductRequest productRequest)
        {
            try
            {
                var product = new Product()
                {
                    ProductName = productRequest.ProductName,
                    ProductCode = productRequest.ProductCode,
                    ReleaseDate = productRequest.ReleaseDate,
                    Description = productRequest.Description,
                    Price = productRequest.Price,
                    ImageUrl = null
                };
                appContext.Products.Add(product);
                appContext.SaveChanges();
            }
            catch (Exception)
            {
                return Ok(false);
            }
            return Ok(true);
        }
        [HttpPost("updateproduct")]
        public IActionResult UpdateProduct(ProductRequest productRequest)
        {
            try
            {
                var updObject = appContext.Products.Where(x => x.Id == productRequest.Id).FirstOrDefault();
                updObject.ProductName = productRequest?.ProductName;
                updObject.ProductCode = productRequest.ProductCode;
                updObject.ReleaseDate = productRequest.ReleaseDate;
                updObject.Description = productRequest.Description;
                updObject.Price = productRequest.Price;
                appContext.SaveChanges();
            }
            catch (Exception)
            {
                return Ok(false);
            }
            return Ok(true);
        }

    }
}