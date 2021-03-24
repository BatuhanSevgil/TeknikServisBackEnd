using Core.Entity;

namespace Entity.Concrete

{
    public class District:IEntity
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public int CityId { get; set; }
        
    }
}