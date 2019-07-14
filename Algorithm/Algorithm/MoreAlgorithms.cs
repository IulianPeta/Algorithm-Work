using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public abstract class MoreAlgorithms
    {

        //When I have more than 1 algorithm

        private Interface formula;

        MoreAlgorithms(Interface formula)
        {
            this.formula = formula;
        }

        public void ApplyFromula()
        {
            formula.Formula();
        }   
 
    }
}
