using Patterns.Lab3.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Lab3.Exports
{
    public class XMLExport : IExporter
    {
        private bool _indent;

        public XMLExport(bool indent)
        {
            _indent = indent;
        }

        public XMLExport() : this(false)
        {
        }

        public void Delimeter()
        {
            if (_indent)
            {
                Console.Write("\n\t");
            }
            else
            {
                Console.WriteLine();
            }
        }

        public void End()
        {
            Console.WriteLine("</Scene>");
        }

        public void Export(Point p)
        {
            Console.WriteLine($"<Point x=\"{p.Coordinates.X}\" y=\"{p.Coordinates.Y}\" color=\"{p.Color}\" />");
        }

        public void Export(Circle c)
        {
            Console.WriteLine($"<Circle x=\"{c.Coordinates.X}\" y=\"{c.Coordinates.Y}\" radius=\"{c.Radius}\" color=\"{c.Color}\" />");
        }

        public void Export(Line c)
        {
            Console.WriteLine($"<Line xA=\"{c.ACoordinates.X}\" yA=\"{c.ACoordinates.Y}\" xB=\"{c.BCoordinates.X}\" yB=\"{c.BCoordinates.Y}\" color=\"{c.Color}\" />");
        }

        public void Start()
        {
            Console.WriteLine("<Scene>");
        }
    }
}
