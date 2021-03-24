using System.Collections.Generic;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICityService
    {
        public IDataResult<List<City>> GetAllCity();
        public IDataResult<City> GetByCode(int cityCode);

    }
}