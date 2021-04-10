using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICustomerGroupService
    {

        public IResult Add(CustomerGroup customerGroup);
        public IResult Update(CustomerGroup customerGroup);
        public IResult Delete(CustomerGroup customerGroup);
        public IDataResult<List<CustomerGroup>> GetAll();
    }
}
