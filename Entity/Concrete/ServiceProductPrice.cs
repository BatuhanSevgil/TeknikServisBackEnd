using Core.Entity;

namespace Entity.Concrete
{
    public class ServiceProductPrice : IEntity
    {

        private decimal _toplamFiyat;

        public int Id { get; set; }
        public int ServiceProductId { get; set; }
        public decimal Parca { get; set; }
        public decimal Iscilik { get; set; }
        public decimal ArizaTespit { get; set; }
        public decimal Nakliye { get; set; }
        public decimal Iskonto { get; set; }
        public decimal ToplamFiyat {get; set;}
    }
}