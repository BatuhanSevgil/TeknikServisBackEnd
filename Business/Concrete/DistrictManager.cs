using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class DistrictManager:IDistrictService
    {
        private IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }
        public IDataResult<List<District>> GetByCityCode(int cityCode)
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetAll(dist => dist.CityId == cityCode).ToList());

        }
    }
}