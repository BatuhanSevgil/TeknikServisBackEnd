using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IAddressService
    {

        public IResult Add(Address address);
        public IResult Update(Address address);
        public IResult Delete(Address address);
        public IDataResult<Address> GetByCustomerId(int customerId);

    }
}