﻿using System;
using System.Collections.Generic;
using System.Web.Http;
using BLL.Core.BLL_Core.Interface;
using DAL.Core.ModelDTO;

namespace ShopOfMusicalInstruments.Core.Controllers
{
    [RoutePrefix("api/Cart")]
    public class CartController : ApiController
    {
        private IBLLFactory _bllFactory;

        public CartController(IBLLFactory bllFactory)
        {
            _bllFactory = bllFactory ?? throw new ArgumentNullException(nameof(bllFactory));
        }

        [Route("GetAllToCart")]
        [HttpPost]
        public IHttpActionResult GetAllToCart(List<dynamic> data)
        {
            List<ProductDTO> result = _bllFactory.ProductBll.GetAllToCart(data);
            return Ok(result);
        }
    }


}