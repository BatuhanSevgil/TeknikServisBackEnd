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
        private IAddressService _addressService;

        public CustomerManager(ICustomerDal customerDal, IAddressService addressService)
        {
            _CustomerDal = customerDal; 
            _addressService = addressService;   
        }

        public IDataResult<CustomerDetailDto> GeyByCustomerDetailWithId(int customerId)
        {
            return new SuccessDataResult<CustomerDetailDto>(_CustomerDal.GeyByCustomerDetailWithId(customerId));

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
        //[TransactionAspect] Gelince içeride ki cod refactor edilecek.
        public IResult AddWithAddress(Customer customer, Address address)
        {
            using (TransactionScope scope=new TransactionScope())
            {
                try
                {
                    var entity = _CustomerDal.AddOutEntity(customer);
                    address.CustomerId = entity.Id;
                    _addressService.Add(address);
                    scope.Complete();
                    return new SuccessResult();

                }
                catch (Exception e)
                {
                    scope.Dispose();
                    return new ErrorResult(e.Message);
                }
            }
        }
    }
}
