using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.Interfaces
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}
