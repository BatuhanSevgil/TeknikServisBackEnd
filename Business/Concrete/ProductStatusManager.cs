using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class ProductStatusManager:IProductStatusService
    {
        private IProductStatusDal _productStatusDal;

        public ProductStatusManager(IProductStatusDal productStatusDal)
        {
            _productStatusDal = productStatusDal;
        }
        public IResult Add(ProductStatus productStatus)
        {
            _productStatusDal.Add(productStatus);
            return new SuccessResult();

        }

        public IResult Delete(ProductStatus productStatus)
        {
            _productStatusDal.Delete(productStatus);
            return new SuccessResult();

        }

        public IDataResult<List<ProductStatus>> GetAllProductStatus()
        {
            return new SuccessDataResult<List<ProductStatus>>(_productStatusDal.GetAll());
        }

        public IDataResult<ProductStatus> GetById(int productStatusId)
        {
            return new SuccessDataResult<ProductStatus>(_productStatusDal.Get(productstatus =>
                productstatus.Id == productStatusId));
        }
    }
}