using System.Collections.Generic;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IServiceProductService
    {
        IResult Add(ServiceProduct serviceProduct);
        IDataResult<List<ServiceProduct>> GetAll();
        IResult AddwithCustomer(ServiceProduct serviceProduct, Customer customer);
    }
}