using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes
{
    internal class ProductA : IProduct
    {
        public ProductA()
        {
            Console.WriteLine("New "+ this.GetType().Name + " created.");
        }
    }
}
