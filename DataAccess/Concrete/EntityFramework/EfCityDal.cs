using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCityDal:EfRepositoryBase<City,TeknikServisContext>,IEntityRepository<City>,ICityDal
    {
        
    }
}