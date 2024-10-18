using Patterns.Lab3.Exports;

namespace Patterns.Lab3.Graph
{
    public class Scene
    {
        private ICollection<GraphObject> _objects;

        private static Scene _instance;

        private Scene()
        {
            _objects = new HashSet<GraphObject>();
        }

        public static Scene GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Scene();
            }
                
            return _instance;
        }

        public void Add(GraphObject obj)
        {
            _objects.Add(obj);
        }

        public void Clear()
        {
            _objects.Clear();
        }

        public void Draw()
        {
            foreach (GraphObject obj in _objects)
            {
                obj.Draw();
            }
        }

        public void Export(IExporter visitor)
        {
            IEnumerator<GraphObject> iterator = _objects.GetEnumerator();

            visitor.Start();

            while (iterator.MoveNext())
            {
                GraphObject g = iterator.Current;

                if (g is IExportable)
                {
                    ((IExportable)g).Accept(visitor);
                }
            }

            visitor.End();
        }
    }
}
