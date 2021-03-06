﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Core.BLL_Core.Interface;
using DAL.Core;
using DAL.Core.DAL_Core;
using DAL.Core.ModelDTO;

namespace BLL.Core.BLL_Core.Repository
{
    public class BrandBLL : IBrandBLL
    {
        private readonly DalFactory _dalFactory;

        public BrandBLL(DalFactory dalFactory)
        {
            _dalFactory = dalFactory;
        }

        public List<BrandDTO> GetAll()
        {
            List<Brand> brandList = _dalFactory.Brand.GetAll().Where(w => w.DeleteDate == null).OrderBy(x => x.Name).ToList();
            var result = Mapper.Map<List<Brand>, List<BrandDTO>>(brandList);
            return result;
        }

        public void Add(BrandDTO brand)
        {
            Brand result = Mapper.Map<BrandDTO, Brand>(brand);
            _dalFactory.Brand.Add(result);
        }

        public void Edit(List<BrandDTO> data)
        {
            foreach (BrandDTO brand in data)
            {
                Brand result = Mapper.Map<BrandDTO, Brand>(brand);
                _dalFactory.Brand.UpdateVoid(result, result.Id);
            }
        }

        public void Delete(int id)
        {
            var entity = _dalFactory.Brand.GetById(id);
            entity.DeleteDate = DateTime.Now;
            _dalFactory.Brand.UpdateVoid(entity, entity.Id);
        }
    }
}
