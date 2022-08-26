using System.Diagnostics.ContractsLight;
using MindBoxTestTask.GeometricFigures.Interfaces.Figures;

namespace MindBoxTestTask.GeometricFigures.Implementations.Figures;

public sealed class Triangle : ITriangle
{
    #region Поля и свойства

    public double SideA { get; }

    public double SideB { get; }

    public double SideC { get; }

    public double Area { get; }

    public double Perimeter { get; }

    public bool IsRightAngled { get; }

    #endregion Поля и свойства

    #region Конструкторы

    public Triangle(double sideA, double sideB, double sideC)
    {
        Contract.Requires(sideA > 0);
        Contract.Requires(sideB > 0);
        Contract.Requires(sideC > 0);
        Contract.Requires(IsTriangleExists(sideA, sideB, sideC));

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        Perimeter = CalculatePerimeter();
        Area = CalculateArea();
        IsRightAngled = IsTriangleRightAngled();
    }

    #endregion Конструкторы

    #region Методы

    #region Методы валидации

    private bool IsTriangleExists(double sideA, double sideB, double sideC)
    {
        if (sideA >= sideB + sideC)
            return false;

        if (sideB >= sideA + sideC)
            return false;

        return !(sideC >= sideA + sideB);
    }

    #endregion Методы валидации

    private double CalculateArea()
    {
        var semiPerimeter = Perimeter / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) *
                         (semiPerimeter - SideC));
    }

    private double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }

    private bool IsTriangleRightAngled()
    {
        var sidesArray = new List<double> {SideA, SideB, SideC};
        sidesArray.Sort();

        return Math.Abs(Math.Pow(sidesArray[2], 2) - (Math.Pow(sidesArray[1], 2) + Math.Pow(sidesArray[0], 2))) < double.Epsilon;
    }

    #endregion Методы
}