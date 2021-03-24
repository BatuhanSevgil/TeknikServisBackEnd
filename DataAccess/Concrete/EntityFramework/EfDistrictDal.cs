using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDistrictDal:EfRepositoryBase<District,TeknikServisContext>,IEntityRepository<District>
    {
        
    }
}