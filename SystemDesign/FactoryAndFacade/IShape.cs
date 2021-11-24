using System;
using System.Collections.Generic;
using System.Text;

namespace Solve.Factory
{
    public interface IShape
    {
        void Draw();
    }

    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("triangle");
        }
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("rectangle");
        }
    }

    public class Triangle2D : IShape
    {
        public void Draw()
        {
            Console.WriteLine("triangle");
        }
    }

    public class Rectangle2D : IShape
    {
        public void Draw()
        {
            Console.WriteLine("rectangle");
        }
    }




    public enum ShapeType
    {
        TRIANGLE, RECTANGLE
    }

    public class ShapeFacade
    {
        private IShape _triangle;
        private IShape _rectangle;

        public ShapeFacade()
        {
            _triangle = new Triangle();
            _rectangle = new Rectangle();
        }

        public void Draw(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.RECTANGLE:
                    _rectangle.Draw();
                    break;
                case ShapeType.TRIANGLE:
                    _triangle.Draw();
                    break;
            }
            throw new InvalidOperationException("Unknown type");
        }
    }

    public interface IFactory
    {
        IShape GetShape(ShapeType shapeType);
    }

    public class ShapeFactory : IFactory
    {
        public IShape GetShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.RECTANGLE:
                    return new Rectangle();
                case ShapeType.TRIANGLE:
                    return new Triangle();
            }
            throw new InvalidOperationException("Unknown type");
        }
    }

    public class ShapeFactory2D : IFactory
    {
        public IShape GetShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.RECTANGLE:
                    return new Rectangle();
                case ShapeType.TRIANGLE:
                    return new Triangle();
            }
            throw new InvalidOperationException("Unknown type");
        }
    }

    public enum FactoryType
    {
        Normal, _2D
    }

    public static class AbstractFactory
    {
        public static IFactory GetFactory(FactoryType factoryType)
        {
            switch (factoryType)
            {
                case FactoryType.Normal:
                    return new ShapeFactory();
                case FactoryType._2D:
                    return new ShapeFactory2D();
            }
            throw new InvalidOperationException("Unknown type");
        }
    }
}
