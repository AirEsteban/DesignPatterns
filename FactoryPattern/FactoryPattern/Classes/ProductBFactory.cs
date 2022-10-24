using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes
{
    internal class ProductBFactory : ICreator
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
