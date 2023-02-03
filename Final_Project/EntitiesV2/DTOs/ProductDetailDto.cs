using CoreV2;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesV2.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName {get; set; }
        public short UnitsInStock { get; set; }
    }
}
