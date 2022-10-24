using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes
{
    internal class ProductAFactory : ICreator
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }   
    }
}
