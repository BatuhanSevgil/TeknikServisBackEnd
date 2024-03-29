﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomerGroupManager:ICustomerGroupService
    {
        private ICustomerGroupDal _groupDal;


        public CustomerGroupManager(ICustomerGroupDal groupDal)
        {
            _groupDal = groupDal;   
        }
        public IResult Add(CustomerGroup customerGroup)
        {
            return new SuccessResult();
        }

        public IResult Update(CustomerGroup customerGroup)
        {
            _groupDal.Update(customerGroup);
            return new SuccessResult();
        }

        public IResult Delete(CustomerGroup customerGroup)
        {
            _groupDal.Delete(customerGroup);
            return new SuccessResult();
        }

        public IDataResult<List<CustomerGroup>> GetAll()
        {
            return new SuccessDataResult<List<CustomerGroup>>(_groupDal.GetAll());
        }
    }
}
