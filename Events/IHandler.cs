namespace Patterns.Lab3.Events
{
    public interface IHandler
    {
        void SetNextHandler(IHandler next);

        void Handle(EventRequest request);
    }
}
