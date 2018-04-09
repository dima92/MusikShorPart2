﻿using System;
using System.Web.Http;
using BLL.Core.BLL_Core.Interface;
using DAL.Core.ModelDTO;
using WebGrease.Css;

namespace ShopOfMusicalInstruments.Core.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        private IBLLFactory _bllFactory;

        public OrdersController(IBLLFactory bllFactory)
        {
            _bllFactory = bllFactory ?? throw new ArgumentNullException(nameof(bllFactory));
        }

        [Route("savePreOrder")]
        [HttpPost]
        public IHttpActionResult SavePreOrder(OrderDto data)
        {
            try
            {
                _bllFactory.OrderBll.SavePreOrder(data);
                return Ok(true);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [Route("order")]
        [HttpPost]
        public IHttpActionResult Order(OrderDto data)
        {
            try
            {
                _bllFactory.OrderBll.Order(data);
                return Ok(true);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);

            }
        }
    }

}