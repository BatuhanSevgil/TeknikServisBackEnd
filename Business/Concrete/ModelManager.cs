using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Concrete
{
    public class ModelManager:IModelService
    {
        public IResult Add(Model model)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Model> GetByModelId(int modelId)
        {
            throw new System.NotImplementedException();
        }

        public IResult DeleteById(int modelId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Model>> GetByBrandId(int brandId)
        {
            throw new System.NotImplementedException();
        }
    }
}