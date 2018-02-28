using System;
using System.Collections.Generic;
using System.Web.Http;
using BLL.Core.BLL_Core.Interface;
using DAL.Core;
using DAL.Core.ModelDTO;

namespace ShopOfMusicalInstruments.Core.Controllers
{
    public class BrandsController : ApiController  
    {
        private IBLLFactory _bllFactory;

        public BrandsController(IBLLFactory bllFactory)
        {
            if (bllFactory == null)
            {
                throw new ArgumentNullException(nameof(bllFactory));
            }

            _bllFactory = bllFactory;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = _bllFactory.BrandBll.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Add(BrandDTO brand)
        {
           _bllFactory.BrandBll.Add(brand);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Edit(List<Brand> data)
        {
            //foreach (var editBrand in data)
            //{
            //    var objectBrand = _db.Brands.Find(editBrand.Id);
            //    if (objectBrand == null) continue;
            //    objectBrand.Name = editBrand.Name;
            //    objectBrand.Description = editBrand.Description;
            //    _db.Entry(objectBrand).State = System.Data.Entity.EntityState.Modified;
            //}

            //_db.SaveChanges();
            return Ok();
        }


        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            //var objectBrand = _db.Brands.Find(id);
            //if (objectBrand == null) return Ok();
            //objectBrand.DeleteDate = DateTime.Now;
            //_db.Entry(objectBrand).State = System.Data.Entity.EntityState.Modified;
            //_db.SaveChanges();
            return Ok();
        }

    }
}