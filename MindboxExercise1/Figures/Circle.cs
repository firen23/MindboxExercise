namespace MindboxExercise1.Figures;

public class Circle : IFigure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
