using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public  class EfProductStatusDal:EfRepositoryBase<ProductStatus,TeknikServisContext>,IProductStatusDal
    {
    }
}
