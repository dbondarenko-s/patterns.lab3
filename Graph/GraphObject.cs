using Patterns.Lab3.Exports;

namespace Patterns.Lab3.Graph
{
    public abstract class GraphObject
    {
        public const string DefaultColor = "black";

        public string Color { get; private set; }

        public GraphObject() : this(DefaultColor)
        {
        }

        public GraphObject(string color)
        {
            Color = color;
        }

        public void SetColor(string collor)
        {
            Color = collor;
        }

        public abstract void Draw();

        public abstract GraphObject Clone();
    }
}
