using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Test
{
    public static partial class enums
    {
        #region Enum Shapes
        public enum Shapes
        {
            [Description("Square")]
            Square = 1,
            [Description("Rectangle")]
            Rectangle = 2,
            [Description("Triangle")]
            Triangle = 3,
            [Description("Circle")]
            Circle = 4,
            [Description("Sphere")]
            Sphere = 5
        }
        #endregion
    }
}
