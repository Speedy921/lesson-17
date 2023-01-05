using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_17
{
    //этот тип будет функционировать как включаемый класс
    class BenefitPackage
    {
        //предположим, что етсь другие члены, представляющие 
        //медицинские/стомтатологические программы
        public double ComputePayDeduction()
        {
            return 125.0;
        }

    }
}
