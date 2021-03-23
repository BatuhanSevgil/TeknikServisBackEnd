using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Core.Entity;

namespace Entity.Concrete
{   
    public class ServiceProduct:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; } // MüşteriId
        public int BrandId { get; set; } // MarkaId
        public int AcceptedPersonId { get; set; } // Kabul eden PersonelID
        public int ServiceTypeId { get; set; } // Bilgisayar,Telefon
        public string Model { get; set; } // Model
        public string SerialNo { get; set; } // Seri No ?
        public string ProductName { get; set; } // Ürün Adı
        public string TroubleDescription { get; set; } // Müşteri Arıza Açıklaması
        public string AcceptedWithProduct { get; set; } // Ürün ile birlikte gelenler
        public bool ProductStatus { get; set; }


    }
}
