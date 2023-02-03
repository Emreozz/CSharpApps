using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class EfProductDal:EfEntityRepositoryBase<NorthwindContext,Product>,IProductDal
    {
    }
}
