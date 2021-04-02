using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CityManager:ICityService
    {
        private ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IDataResult<List<City>> GetAllCity()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());

        }

        public IDataResult<City> GetByCode(int cityCode)
        {
            return new SuccessDataResult<City>(_cityDal.Get(city => city.CityId == cityCode));
        }

    }
}