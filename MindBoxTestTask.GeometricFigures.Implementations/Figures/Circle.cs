using System.Diagnostics.ContractsLight;
using MindBoxTestTask.GeometricFigures.Interfaces.Figures;

namespace MindBoxTestTask.GeometricFigures.Implementations.Figures;

public sealed class Circle : ICircle
{
    #region Поля и свойства

    public double Radius { get; }

    public double Diameter { get; }

    public double Area { get; }

    public double Perimeter { get; }

    #endregion Поля и свойства

    #region Конструкторы

    public Circle(double radius)
    {
        Contract.Requires(radius > 0);

        Radius = radius;

        Area = CalculateArea();
        Perimeter = CalculatePerimeter();
        Diameter = 2 * Radius;
    }

    #endregion Конструкторы

    #region Методы

    private double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    private double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    #endregion Методы
}