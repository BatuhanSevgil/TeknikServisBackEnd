using System.Collections.Generic;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IProductStatusService
    {
        //SABİT TANIM
        IResult Add(ProductStatus productStatus);
        IResult Delete(ProductStatus productStatus);
        IDataResult<List<ProductStatus>> GetAllProductStatus();
        IDataResult<ProductStatus> GetById(int productStatusId);

    }
}