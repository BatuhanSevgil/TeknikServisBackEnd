using System.Collections.Generic;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IModelService
    {

        IResult Add(Model model);
        IDataResult<Model> GetByModelId(int modelId);
        IResult DeleteById(int modelId);
        IDataResult<List<Model>> GetByBrandId(int brandId);

    }

}