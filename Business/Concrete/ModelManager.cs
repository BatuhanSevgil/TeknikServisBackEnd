using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class ModelManager:IModelService
    {
        private IModelDal _modelDal;

        public IResult Add(Model model)
        {
            _modelDal.Add(model);
            return new SuccessResult();
        }

        public IDataResult<Model> GetByModelId(int modelId)
        {
            throw new System.NotImplementedException();
        }

        public IResult DeleteById(int modelId)
        {
            var result = _modelDal.Get(model => model.Id == modelId);
            _modelDal.Delete(result);
            return new SuccessResult();
        }

        public IDataResult<List<Model>> GetByBrandId(int brandId)
        {
           return new SuccessDataResult<List<Model>>( _modelDal.GetAll(model => model.BrandId == brandId));
        }
    }
}