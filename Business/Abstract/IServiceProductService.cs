using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IServiceProductService
    {
        IResult Add(ServiceProduct serviceProduct);
        
    }
}