using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Test
{
    internal class Square
    {
        public double Area;
        public double Length;

        public double CalculateArea()
        {
            Area = 0;
            try
            {
                if(Length != 0)
                {
                    return Area = this.Length * 2;
                }

            } 
            catch(Exception ex)
            {

            }

            return Area;
        }
    }
}
