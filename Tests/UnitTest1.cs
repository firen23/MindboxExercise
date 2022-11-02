using System;
using NUnit.Framework;
using MindboxExercise1.Figures;

namespace Tests;

public class Tests
{
    private Circle circle;
    private Triangle incorrectTriangle;
    private Triangle triangle;
    private Triangle rightTriangle;
    
    [SetUp]
    public void Setup()
    {
        circle = new Circle(3);
        incorrectTriangle = new Triangle(3, 7, 4);
        triangle = new Triangle(3, 4, 2);
        rightTriangle = new Triangle(5, 4, 3);
    }

    [Test]
    public void TestCircleArea()
    {
        // TODO: should the values being compared be constant or computed?
        double circleArea = Math.PI * circle.Radius * circle.Radius;
        
        IFigure figure = circle;
        
        Assert.True(figure.Area().Equals(circleArea));
    }

    [Test]
    public void TestTriangleIsCorrect()
    {
        Assert.False(incorrectTriangle.IsCorrect());
        Assert.True(triangle.IsCorrect());
    }

    [Test]
    public void TestTriangleIsRight()
    {
        Assert.False(triangle.IsRight());
        Assert.True(rightTriangle.IsRight());
    }

    [Test]
    public void TestTriangleArea()
    {
        // TODO: should the values being compared be constant or computed?
        double triangleArea = Math.Sqrt(
            (triangle.A + triangle.B + triangle.C) *
            (triangle.B + triangle.C - triangle.A) *
            (triangle.A + triangle.C - triangle.B) *
            (triangle.A + triangle.B - triangle.C)) / 4;
        double rightTriangleArea = rightTriangle.A * rightTriangle.B / 2;
        
        IFigure figure1 = triangle;
        IFigure figure2 = rightTriangle;
        
        Assert.True(figure1.Area().Equals(triangleArea));
        Assert.True(figure2.Area().Equals(rightTriangleArea));
    }
}
