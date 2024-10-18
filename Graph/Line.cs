namespace Patterns.Lab3.Graph
{
    using Patterns.Lab3.Exports;
    using System;

    public class Line : GraphObject, IExportable
    {
        public Coordinates ACoordinates { get; private set; }

        public Coordinates BCoordinates { get; private set; }

        public Line(Line line) : this(line.ACoordinates.X, line.ACoordinates.Y, line.BCoordinates.X, line.BCoordinates.Y, line.Color)
        {
        }

        public Line(int xA, int yA, int xB, int yB) : this(xA, yA, xB, yB, DefaultColor)
        {
        }

        public Line(int xA, int yA, int xB, int yB, string color) : base(color)
        {
            ACoordinates = new Coordinates(xA, yA);

            BCoordinates = new Coordinates(xB, yB);
        }

        public override void Draw()
        {
            Console.WriteLine($"Line. Coordinates: A(X={ACoordinates.X}, Y={ACoordinates.Y}), B(X={BCoordinates.X}, Y={BCoordinates.Y}). Color: {Color}.");
        }

        public override Line Clone()
        {
            return new Line(this);
        }

        public void Accept(IExportVisitor v)
        {
            v.Export(this);
        }
    }
}
