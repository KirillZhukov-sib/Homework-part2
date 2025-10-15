using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_8
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string PicturePath { get; set; }
        public ProductCategory Category { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price:C} ({Category})";
        }
    }
    public enum ProductCategory
    {
        Food, Appliances
    }   
}
