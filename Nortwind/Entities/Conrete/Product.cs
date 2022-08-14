using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Conrete
{
    public class Product:IEntity//(inteface yapılmasının nedeni:veri tabanı tablosu olduğunu gösterir)
    {
        //kodlama yaparken kullanacağımız veriler veritabanı tablosundaki isimler yazılır. 
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
   
    }
}
