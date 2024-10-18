namespace Patterns.Lab3.Graph
{
    public class ColorGOFactory : AbstractGOFactory
    {
        private Point _defaultPoint = new Point(0, 0);

        public override Circle CreateCircle()
        {
            var item = new Circle(0, 0, 1);

            item.SetColor("Green");

            OnCreate(item);

            return item;
        }

        public override Line CreateLine()
        {
            var item = new Line(0, 0, 1, 1);

            item.SetColor("Red");

            OnCreate(item);

            return item;
        }

        public override Point CreatePoint()
        {
            var item = _defaultPoint.Clone();

            item.SetColor("Yellow");

            OnCreate(item);

            return item;
        }

        protected void OnCreate(GraphObject item)
        {
            Scene.GetInstance().Add(item);
        }
    }
}
