using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Concrete
{
  public  class CustomerManager:ICustomerService
    {
        private ICustomerDal _CustomerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _CustomerDal = customerDal;
            
        }

        public IResult Add(Customer customer)
        {
            var isSuccess = BusinessRules.Run();

            if (isSuccess.Success)
            {
                _CustomerDal.Add(customer);

            }

            return isSuccess;
        }

        public IResult Update(Customer customer)
        {
            var isSuccess= BusinessRules.Run();

            if (isSuccess.Success)
            {
                _CustomerDal.Update(customer);
                
            }

            return isSuccess;

        }

        public IResult Delete(Customer customer)
        {
            var isSuccess = BusinessRules.Run();

            if (isSuccess.Success)
            {
                _CustomerDal.Delete(customer);

            }

            return isSuccess;

        }

        public IDataResult<Customer> GetByCustomerId(int customerId)
        {
            var isSuccess = BusinessRules.Run();

            if (isSuccess.Success)
            {
                return new SuccessDataResult<Customer>(_CustomerDal.Get(customer => customer.Id == customerId));
            }

            return new ErrorDataResult<Customer>();
        }
    }
}
