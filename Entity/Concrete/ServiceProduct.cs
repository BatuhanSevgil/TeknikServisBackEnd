using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Core.Entity;

namespace Entity.Concrete
{
    public class ServiceProduct : IEntity
    {
        public int Id { get; set; }
        public int SpecialCode { get; set; }  // Özel kod - Takip No
        public int CustomerId { get; set; } // MüşteriId
        public int BrandId { get; set; } // MarkaId
        public int ModelId { get; set; } //Model ID
        public int AcceptedPersonId { get; set; } // Kabul eden PersonelID
        public int ServiceTypeId { get; set; } // Bilgisayar,Telefon
        public string SerialNo { get; set; } // Seri No 
        public string TroubleDescription { get; set; } // Müşteri Arıza Açıklaması
        public string AcceptedWithProduct { get; set; } // Ürün ile birlikte gelenler  -- şarj canta vb ,
        public string PhysicalStatus { get; set; } // ürün fiziksel durumu ekran kırık vb ,
        public int ProductStatus { get; set; } // Ürün durumu , Onarımı yapıldı, Parça bekliyor Ücret onayında 



    }
}
