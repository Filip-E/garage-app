﻿using DAL.models;
using garage_app_bl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.DTOs.Response;
using WebApplication1.Mappers;

namespace WebApplication1.Controllers
{
    public class ProductController : ApiController
    {
        private ProductService  _service;
        private ProductsMapper _mapper;
        ProductController()
        {
            _service = new ProductService();
            _mapper = new ProductsMapper();
        }

        public IHttpActionResult GetAllProducts()
        {
            List<ProductResponseDTO> response = new List<ProductResponseDTO>();
            List<Product> products = _service.getProducts();

            foreach (Product p in products)
            {
                response.Add(_mapper.ToDTO(p));
            }
            return Ok(response);
        }

        //public IHttpActionResult GetProduct(int id)
        //{
        //    var product = _service.findProduct(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}
    }
}
