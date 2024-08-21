using System;
using System.Collections.Generic;
using Base_Backend.Model;
using Base_Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Gen;
[Serializable]
[ApiController]
[Route("v1/products")]
public abstract class ProductHandler : ControllerBase
{
    public readonly IProductRepository _productRepository;

    public ProductHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [AcceptVerbs("GET")]
    [Route("GetAll")]
    public abstract ActionResult<List<ProductEntity>> GetAll();

    [AcceptVerbs("POST")]
    [Route("Save")]
    public abstract ActionResult<ProductEntity> Save([FromBody] ProductEntity product);

    [AcceptVerbs("GET")]
    [Route("GetConsulting")]
    public abstract ActionResult<ProductEntity> GetConsulting();
}