using System.Collections.Generic;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IServiceTypeService
    {
        IResult Add(ServiceType serviceType);
        IResult Update(ServiceType serviceType);
        IResult Delete(ServiceType serviceType);
        IDataResult<ServiceType> GetById(int serviceId);
        IDataResult<List<ServiceType>> GetAll();

    }
}