using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Concrete.DTOs;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _CustomerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _CustomerDal = customerDal;
        }

        public IDataResult<CustomerDetailDto> GetByCustomerDetailWithId(int customerId)
        {
            return new SuccessDataResult<CustomerDetailDto>(_CustomerDal.GeyByCustomerDetailWithId(customerId));

        }



        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_CustomerDal.GetAll());
        }

        //[Aspect]]
        public IResult Add(Customer customer)
        {

            _CustomerDal.Add(customer);
            return new SuccessResult();

        }

        public IResult Update(Customer customer)
        {
            _CustomerDal.Update(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _CustomerDal.Delete(customer);
            return new SuccessResult();

        }

        public IDataResult<Customer> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Customer>(_CustomerDal.Get(customer => customer.Id == customerId));
        }

        public IDataResult<Customer> AddOutId(Customer customer)
        {
            var result = _CustomerDal.AddOutEntity(customer);
            return new SuccessDataResult<Customer>(result);
        }

    }
}
