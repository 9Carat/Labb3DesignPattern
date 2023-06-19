using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3DesignPattern
{
    public interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(int total);
    }
}
