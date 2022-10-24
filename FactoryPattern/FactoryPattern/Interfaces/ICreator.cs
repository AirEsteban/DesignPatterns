using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interfaces
{
    interface ICreator
    {
       public abstract IProduct CreateProduct();
    }
}
