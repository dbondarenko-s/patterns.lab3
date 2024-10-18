namespace Patterns.Lab3.Graph
{
    public abstract class AbstractGOFactory
    {
        public abstract Point CreatePoint();

        public abstract Circle CreateCircle();

        public abstract Line CreateLine();
    }
}
