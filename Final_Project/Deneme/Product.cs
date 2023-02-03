using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }

    }
}
