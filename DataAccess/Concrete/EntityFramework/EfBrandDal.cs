﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal:EfRepositoryBase<Brand,TeknikServisContext>,IBrandDal
    {
        
    }
}