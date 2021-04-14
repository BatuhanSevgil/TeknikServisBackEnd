using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IServiceProductPriceService
    {
        public IDataResult<List<IResult>> Add(ServiceProductPrice productPrice);
        public IResult Update(ServiceProductPrice productPrice);
        
    }
}
