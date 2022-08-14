using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Conrete
{
    public class Category: IEntity//(inteface yapılmasının nedeni:veri tabanı tablosu olduğunu gösterir)
    {
        //kodlama yaparken kullanacağımız veriler veritabanı tablosundaki isimler yazılır. 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
