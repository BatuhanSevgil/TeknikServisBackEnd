using Core.Entity;

namespace Entity.Concrete
{
   public  class City:IEntity
    {
        public int CityId  { get; set; }
        public string Name { get; set; }
    }
}
