using System;


public abstract class Shape
{
    public abstract double CalculateArea(); //面积
    public abstract bool IsValid(); //判断非法
}


public class Rectangle : Shape   //长方形
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double CalculateArea()  //面积
    {
        return length * width;
    }

    public override bool IsValid()
    {
        return length > 0 && width > 0;
    }
}


public class Square : Shape   // 正方形类
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double CalculateArea()
    {
        return side * side;
    }

    public override bool IsValid()
    {
        return side > 0;
    }
}


public class Triangle : Shape  // 三角形类
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double CalculateArea()//海伦计算面积
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3)); 
    }

    public override bool IsValid()
    {
        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }
}


public class ShapeFactory   // 工厂类
{
    public static Shape CreateShape(string type, params double[] sides)
    {
        switch (type)
        {
            case "Rectangle":
                if (sides.Length != 2) return null;
                return new Rectangle(sides[0], sides[1]);
            case "Square":
                if (sides.Length != 1) return null;
                return new Square(sides[0]);
            case "Triangle":
                if (sides.Length != 3) return null;
                return new Triangle(sides[0], sides[1], sides[2]);
            default:
                return null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[10];
        Random random = new Random();

        double totalArea = 0;

        // 随机创建10个形状对象
        for (int i = 0; i < 10; i++)
        {
            string type = (random.Next(3) == 0) ? "Rectangle" : (random.Next(3) == 1) ? "Square" : "Triangle";
            double[] sides = new double[3];

            for (int j = 0; j < sides.Length; j++)
            {
                sides[j] = random.Next(1, 10);
            }

            Shape shape = ShapeFactory.CreateShape(type, sides);

            if (shape.IsValid())
            {
                shapes[i] = shape;
                totalArea += shape.CalculateArea();
            }
            else
            {
                i--;
            }
        }

        Console.WriteLine($"Total area of the shapes: {totalArea}");
    }
}