﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace Business.Concrete
{
 public class AddressManager:IAddressService
    {
        private IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;   
        }

        
        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult();

        }

        public IResult Update(Address address)
        {
            _addressDal.Update(address);
            return new SuccessResult();
        }

        public IResult Delete(Address address)
        {
            _addressDal.Delete(address);
            return new SuccessResult();
        }

        public IDataResult<Address> GetByCustomerId(int customerId)
        {
         return new SuccessDataResult<Address>(_addressDal.Get(address => address.CustomerId == customerId));
        }
    }
}
