using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class ProductStatus:IEntity
    {
        public int Id { get; set; }
        public string Status { get; set; }

    }
}
