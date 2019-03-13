﻿using System;
using System.Web.Http;
using System.Web.Http.Cors;
using Ecommerce.Business;
using Ecommerce.Business.Models;

namespace Ecommerce.Controllers
{
    [EnableCors("*", "*", "*")]
    //[RoutePrefix("api/[controller]")]
    public class ProductController : ApiController
    {
        ProductService productService = new ProductService();

        [Route("api/product/{name}")]
        [HttpGet]
        public IHttpActionResult GetProductByName(string name)
        {
        return Ok(productService.GetProductByName(name));
        }

        public IHttpActionResult GetByPartialName(string name)
        {
            return Ok(productService.GetByPartialName(name));
        }

        [HttpGet]
        public IHttpActionResult GetProductById(int id)
        {
            return Ok(productService.GetProductById(id));
        }

        [HttpPost]
        public IHttpActionResult CreateProduct(ProductModel product)
        {
            return Ok(productService.CreateProduct(product));
        }

        [HttpPut]
        public IHttpActionResult ModifyProduct(ProductModel product)
        {
            try
            {
                return Ok(productService.ModifyProduct(product));
                //return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


    }
}