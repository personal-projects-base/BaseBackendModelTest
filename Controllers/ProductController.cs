using Base_Backend.Config.Database;
using Base_Backend.Model;
using Base_Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Controllers
{
    [Serializable]
    [ApiController]
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [AcceptVerbs("GET")]
        [Route("GetAll")]
        public ActionResult<List<ProductEntity>> GetAll()
        {
            var products = _productRepository.GetAll();
            return Ok(products);
        }


        [AcceptVerbs("POST")]
        [Route("Save")]
        public ActionResult<ProductEntity> Save([FromBody ]ProductEntity product)
        {
            if (product.Id == null)
            {
                product =  _productRepository.Add(product);
            }
            else
            {
                product =  _productRepository.Update(product.Id, product);
                
            }
            
            return Ok(product);
        }

        [AcceptVerbs("GET")]
        [Route("GetConsulting")]
        public ActionResult<ProductEntity> GetConsulting()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            return Ok(_productRepository.FindPrice());
        }
    }
}
