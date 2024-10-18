namespace Patterns.Lab3.Graph
{
    using Patterns.Lab3.Exports;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Circle : GraphObject, IExportable
    {
        public Coordinates Coordinates { get; private set; }

        public int Radius { get; private set; }

        public Circle(Circle circle) : this(circle.Coordinates.X, circle.Coordinates.Y, circle.Radius, circle.Color)
        {
        }

        public Circle(int x, int y, int radius) : this(x, y, radius, DefaultColor)
        {
        }

        public Circle(int x, int y, int radius, string color) : base(color)
        {
            Coordinates = new Coordinates(x, y);

            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle. Coordinates: X={Coordinates.X}, Y={Coordinates.Y}. Radius: {Radius}. Color: {Color}.");
        }

        public override Circle Clone()
        {
            return new Circle(this);
        }

        public void Accept(IExportVisitor v)
        {
            v.Export(this);
        }
    }
}
