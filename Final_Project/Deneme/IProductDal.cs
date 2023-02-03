using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public interface IProductDal: IEntityRepository<Product>
    {
        public Product Product { get; set; }
        public void denem();
    }
}
