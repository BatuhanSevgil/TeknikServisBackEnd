using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IServiceProductPriceDal:IEntityRepository<ServiceProductPrice>
    {
    }
}
