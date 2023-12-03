// Введення даних для циліндра
Console.WriteLine("Enter the parameters for the cylinder:");
Console.Write("Enter the radius: ");
double cylinderRadius = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the height: ");
double cylinderHeight = Convert.ToDouble(Console.ReadLine());

// Створення об'єкта циліндра та виведення площі поверхні
Cylinder cylinder = new Cylinder(cylinderRadius, cylinderHeight);
Console.WriteLine($"Surface Area of Cylinder: {cylinder.GetSurfaceArea()}");

// Введення даних для куба
Console.WriteLine("\nEnter the parameters for the cube:");
Console.Write("Enter the side length: ");
double cubeSideLength = Convert.ToDouble(Console.ReadLine());

// Створення об'єкта куба та виведення площі поверхні
Cube cube = new Cube(cubeSideLength);
Console.WriteLine($"Surface Area of Cube: {cube.GetSurfaceArea()}");

// Введення даних для конуса
Console.WriteLine("\nEnter the parameters for the cone:");
Console.Write("Enter the radius: ");
double coneRadius = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the height: ");
double coneHeight = Convert.ToDouble(Console.ReadLine());

// Створення об'єкта конуса та виведення площі поверхні
Cone cone = new Cone(coneRadius, coneHeight);
Console.WriteLine($"Surface Area of Cone: {cone.GetSurfaceArea()}");
public interface ITrigonometricFigure
{
    double GetSurfaceArea();
}

public abstract class TrigonometricFigure : ITrigonometricFigure
{
    public abstract double GetSurfaceArea();
}

public class Cylinder : TrigonometricFigure
{
    public double Radius { get; set; }
    public double Height { get; set; }

    public Cylinder(double radius, double height)
    {
        Radius = radius;
        Height = height;
    }

    public override double GetSurfaceArea()
    {
        return 2 * Math.PI * Radius * (Radius + Height);
    }
}

public class Cube : TrigonometricFigure
{
    public double SideLength { get; set; }

    public Cube(double sideLength)
    {
        SideLength = sideLength;
    }

    public override double GetSurfaceArea()
    {
        return 6 * Math.Pow(SideLength, 2);
    }
}

public class Cone : TrigonometricFigure
{
    public double Radius { get; set; }
    public double Height { get; set; }

    public Cone(double radius, double height)
    {
        Radius = radius;
        Height = height;
    }

    public override double GetSurfaceArea()
    {
        return Math.PI * Radius * (Radius + Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Radius, 2)));
    }
}
