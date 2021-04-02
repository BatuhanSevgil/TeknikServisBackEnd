using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
  public  class Model:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }

    }
}
