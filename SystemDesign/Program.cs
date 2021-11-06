using System;
using System.Threading;
using System.Threading.Tasks;
using SystemDesign.ChainOfResponsibility;
using SystemDesign.Factory;

namespace SystemDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new Employee1(
                new Employee2(null)
            );

            var rand = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < 10; i++)
            {
                Task.Run(() =>
                {
                    while (true)
                    {
                        employee.AcceptTask(rand.Next(10, 100));
                        Thread.Sleep(10);
                    }
                });
            }


            //ShapeFactory shapeFactory = new ShapeFactory();

            //var rectangle = shapeFactory.GetShape(ShapeType.RECTANGLE);
            //var triangle = shapeFactory.GetShape(ShapeType.TRIANGLE);

            //rectangle.Draw();
            //triangle.Draw();

            //var factory = AbstractFactory.GetFactory(FactoryType.Normal);

            //var shp = factory.GetShape(ShapeType.RECTANGLE);

            //shp.Draw();

            Console.ReadKey();
        }
    }
}
