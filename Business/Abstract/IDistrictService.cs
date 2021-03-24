using System.Collections.Generic;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        IDataResult<List<District>> GetByCityCode(int cityCode);

    }
}