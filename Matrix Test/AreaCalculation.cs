using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Test
{
    internal class AreaCalculation
    {
        public double Area;
        private double Pi = 3.14;

        Square square = new Square();
        Rectangle rectangle = new Rectangle();
        Triangle triangle = new Triangle();
        Circle_Sphere circle_sphere = new Circle_Sphere();

        #region CalculateArea
        public double CalculateArea(string areaType, double firstValue, double secondValue = 0)
        {

            switch (areaType.ToLower())
            {

                case "square":
                    square.Length = firstValue;
                    break;
                case "rectangle":
                    square.Length = firstValue;
                    rectangle.Width = secondValue;
                    break;
                case "triangle":
                    rectangle.Width = firstValue != 0 ? firstValue : 0;
                    triangle.Height = secondValue;
                    break;
                case "circle":
                case "sphere":
                    circle_sphere.Radius = firstValue;
                    break;
            }

            GetAreaOfShape(areaType.ToLower());
            return Area;
        }
        #endregion

        #region GetAreaOfShape
        private void GetAreaOfShape(string areaType)
        {
            try
            {
                if (areaType == "square")
                {
                    Area = square.Length * 2;
                }
                else if (areaType == "rectangle")
                {
                    Area = square.Length * rectangle.Width;
                }
                else if (areaType == "triangle")
                {
                    Area = (rectangle.Width * triangle.Height) / 2;
                }
                else if (areaType == "circle")
                {
                    Area = Pi * (circle_sphere.Radius * circle_sphere.Radius);
                }
                else if (areaType == "sphere")
                {
                    Area = 4 * Pi * (circle_sphere.Radius * circle_sphere.Radius);
                }
            }
            catch (Exception ex)
            {


            }
        }
        #endregion

    }


}
