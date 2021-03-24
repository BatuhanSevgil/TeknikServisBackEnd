using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete.DTOs;

namespace DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        public List<CustomerDetailDto> GetAllCustomerDetail();
        public CustomerDetailDto GeyByCustomerDetailWithId(int customerId);
    }
}
