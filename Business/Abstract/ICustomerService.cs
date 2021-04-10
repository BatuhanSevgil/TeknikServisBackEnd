using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Concrete.DTOs;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        public IResult Add(Customer customer);
        public IResult Update(Customer customer);
        public IResult Delete(Customer customer);
        public IDataResult<Customer> GetByCustomerId (int customerId);
        public IDataResult<Customer> AddOutId(Customer customer);
        public IDataResult<CustomerDetailDto> GetByCustomerDetailWithId(int customerId);

        public IDataResult<List<Customer>> GetAll();
    }
}
