using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Test
{
    internal class CommonFunctions
    {
        #region IsNotEmptyOrNull
        public bool CheckValueIsNotEmpty(string shapeType)
        {

            return shapeType != "" ? true : false;
        }


        public bool CheckValueIsNotEmpty(double shapeValue)
        {
            return shapeValue != 0 ? true : false;
        }

        #endregion

        #region Tuple method
        /// <summary>
        /// Returns shapeType, firstValue, secondValue based on Shape Type
        /// </summary>
        /// <param name="AreaTypeData"></param>
        /// <returns></returns>
        public static (string ShapeType, string FirstValue, string SecondValue) GetInputValues(string[] AreaTypeData)
        {
            string shapeType = "";
            string firstValue = "";
            string secondValue = "";

            if (AreaTypeData.Length == 2)
            {
                shapeType = AreaTypeData[0];
                firstValue = AreaTypeData[1];
            }
            else if (AreaTypeData.Length == 3)
            {
                shapeType = AreaTypeData[0];
                firstValue = AreaTypeData[1];
                secondValue = AreaTypeData[2];
            }

            return (shapeType, firstValue, secondValue);
        }
        #endregion

        #region CheckShapeTypeAssignEnum
        public int CheckShapeTypeAssignEnum(string ShapeType)
        {
            int enumShapeType = 0;
            switch(ShapeType.ToLower())
            {
                case "square":
                    enumShapeType = (int)enums.Shapes.Square;
                    break;
                case "rectangle":
                    enumShapeType = (int)enums.Shapes.Rectangle;
                    break;
                case "triangle":
                    enumShapeType = (int)enums.Shapes.Triangle;
                    break;
                case "circle":
                    enumShapeType = (int)enums.Shapes.Circle;
                    break;
                case "sphere":
                    enumShapeType = (int)enums.Shapes.Sphere;
                    break;
                default:
                    enumShapeType = 0;
                    break;
            }

            return enumShapeType;
        }
        #endregion
    }
}
