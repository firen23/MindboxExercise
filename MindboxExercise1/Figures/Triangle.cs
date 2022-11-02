namespace MindboxExercise1.Figures;

public class Triangle : IFigure
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double side1, double side2, double side3)
    {
        // Assign greatest side to C, others to A and B
        if (side1 >= side2 && side1 >= side3)
        {
            C = side1;
            A = side2;
            B = side3;
        }
        else if (side2 >= side1 && side2 >= side3)
        {
            C = side2;
            A = side1;
            B = side3;
        }
        else
        {
            C = side3;
            A = side1;
            B = side2;
        }
    }
    
    public double Area()
    {
        if (!IsCorrect())
            return 0;

        if (IsRight())
            return A * B / 2;
        
        return Math.Sqrt((A + B + C) * (B + C - A) * (A + C - B) * (A + B - C)) / 4; // Heron's formula
    }

    public bool IsCorrect()
    {
        return (A + B > C) && (B + C > A) && (A + C > B);
    }

    public bool IsRight()
    {
        return Math.Pow(C, 2).Equals(Math.Pow(A, 2) + Math.Pow(B, 2));
    }
}
