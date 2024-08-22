using System;
using System.Collections.Generic;
using System.Threading;
using Base_Backend.Config.Database;
using Base_Backend.Gen;
using Base_Backend.Model;
using Base_Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Controllers
{

    public class ProductController : ProductHandler
    {
        public ProductController(IProductRepository productRepository) : base(productRepository) { }
        
        public override ActionResult<List<ProductEntity>> GetAll()
        {
            var products = _productRepository.GetAll();
            return Ok(products);
        }
        
        public override ActionResult<ProductEntity> Save([FromBody]ProductEntity product)
        {
            if (product.Id == 0)
            {
                product =  _productRepository.Add(product);
            }
            else
            {
                product =  _productRepository.Update(product.Id, product);
                
            }
            
            return Ok(product);
        }
    }
}
