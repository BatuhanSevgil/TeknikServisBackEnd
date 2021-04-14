using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ServiceTypeManager:IServiceTypeService
    {
        private readonly IServiceTypeDal _serviceTypeDal;

        public ServiceTypeManager(IServiceTypeDal serviceTypeDal)
        {
            _serviceTypeDal = serviceTypeDal;   
        }
        public IResult Add(ServiceType serviceType)
        {
            _serviceTypeDal.Add(serviceType);
            return new SuccessResult();
        }

        public IResult Update(ServiceType serviceType)
        {
            _serviceTypeDal.Update(serviceType);
            return new SuccessResult();

        }

        public IResult Delete(ServiceType serviceType)
        {

            _serviceTypeDal.Delete(serviceType);
            return new SuccessResult();
        }

        public IDataResult<ServiceType> GetById(int serviceId)
        {
            return new SuccessDataResult<ServiceType>(
                _serviceTypeDal.Get(serviceType => serviceType.Id == serviceId));
        }

        public IDataResult<List<ServiceType>> GetAll()
        {
            return new SuccessDataResult<List<ServiceType>>(_serviceTypeDal.GetAll());
        }
    }
}