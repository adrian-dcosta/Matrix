using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matrix_Test
{
    internal class Program
    {
        public static int enumShapeType = 0;
        static void Main(string[] args)
        {
            CalcuateShapeArea();
        }

        #region CalculateShapeArea
        public static void CalcuateShapeArea()
        {
            double Area = 0; ;
            string AreaTypeAndArea;
            string[] AreaTypeData;

            AreaCalculation areaCalculation = new AreaCalculation();
            CommonFunctions commonFunctions = new CommonFunctions();
            
            while (true)
            {
                Console.WriteLine("Calculate area for Square, Rectangle, Triangle, Circle, Sphere, Exit to close\n ");
                AreaTypeAndArea = Console.ReadLine();
                if (AreaTypeAndArea.ToLower() == "exit") Environment.Exit(0);

                AreaTypeData = AreaTypeAndArea.Split(' ');

                var paratype = GetInputValues(AreaTypeData);
                enumShapeType = commonFunctions.CheckShapeTypeAssignEnum(paratype.ShapeType);

                if(enumShapeType == 0)
                {
                    Console.Write("Please enter a valid shape\n");
                    Thread.Sleep(1000);
                    Console.Clear();
                    CalcuateShapeArea();
                }

                // Check if first input field is not empty
                if (commonFunctions.CheckValueIsNotEmpty(paratype.ShapeType))
                {
                    if ((enumShapeType == (int)enums.Shapes.Square || enumShapeType == (int)enums.Shapes.Circle || enumShapeType == (int)enums.Shapes.Sphere)
                        && paratype.FirstValue != "")
                    {
                        Area = areaCalculation.CalculateArea(paratype.ShapeType, Convert.ToDouble(paratype.FirstValue));
                        Console.WriteLine("\nThe Area of {0} is {1}\n", paratype.ShapeType, Area);
                    }
                    else if ((enumShapeType == (int)enums.Shapes.Rectangle || enumShapeType == (int)enums.Shapes.Triangle) &&
                        paratype.FirstValue != "" && paratype.SecondValue != "")
                    {
                        Area = areaCalculation.CalculateArea(paratype.ShapeType, Convert.ToDouble(paratype.FirstValue), Convert.ToDouble(paratype.SecondValue));
                        Console.WriteLine("The Area of {0} is {1}\n", paratype.ShapeType, Area);
                    }
                    else
                    {
                        Console.WriteLine("You need enter a value to calculate the area\n\n");
                        Area = 0;
                    }

                    //Console.WriteLine("The Area of {0} is {1}\n", paratype.ShapeType, Area);
                }
                else
                {
                    Console.WriteLine("You need to enter a shape to calcuate the area");
                }
            };
        }
        #endregion

        #region tuple method
        private static (string ShapeType, string FirstValue, string SecondValue) GetInputValues(string[] AreaTypeData)
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
    }
}
