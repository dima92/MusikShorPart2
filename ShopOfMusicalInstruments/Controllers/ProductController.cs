﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BLL.Core.BLL_Core.Interface;
using DAL.Core.ModelDTO;

namespace ShopOfMusicalInstruments.Core.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController  
    {
        private readonly IBLLFactory _bllFactory;

        public ProductController(IBLLFactory bllFactory)
        {
            if (bllFactory == null)
            {
                throw new ArgumentNullException(nameof(bllFactory));
            }

            _bllFactory = bllFactory;
        }

        [HttpGet]
        [Route("GetAllDataBase")]
        public IHttpActionResult GetAllDataBase()
        {
            List<ProductDTO> result = _bllFactory.ProductBll.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllCatalog")]
        public IHttpActionResult GetAllCatalog()
        {
           var result = _bllFactory.ProductBll.GetAll().Where(w => w.Window == true).OrderBy(r => r.Brand.Name).ToList();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetProductById")]
        public IHttpActionResult GetProductById(int categoryId, int subcategoryId, bool flag)
        {
            List<ProductDTO> result = _bllFactory.ProductBll.GetProductById(categoryId, subcategoryId, flag);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Add(ProductDTO product)
        {
            _bllFactory.ProductBll.Add(product);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Edit([FromBody]List<ProductDTO> data)
        {
            _bllFactory.ProductBll.Edit(data);
            return Ok();
        }


        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _bllFactory.ProductBll.Delete(id);
            return Ok();
        }
    }
}
