namespace MindBoxTestTask.GeometricFigures.Interfaces.Figures;

public interface ITriangle : IFigure
{
    double SideA { get; }

    double SideB { get; }

    double SideC { get; }

    bool IsRightAngled { get; }
}