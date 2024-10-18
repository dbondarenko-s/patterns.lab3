using Patterns.Lab3.Graph;

namespace Patterns.Lab3.Exports
{
    public interface IExportVisitor
    {
        void Export(Point p);

        void Export(Circle c);

        void Export(Line c);
    }
}
