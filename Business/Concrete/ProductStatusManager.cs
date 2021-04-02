using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Concrete
{
    public class ProductStatusManager:IProductStatusService
    {
        public IResult Add(ProductStatus productStatus)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(ProductStatus productStatus)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<ProductStatus>> GetAllProductStatus()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<ProductStatus> GetById(int productStatusId)
        {
            throw new System.NotImplementedException();
        }
    }
}