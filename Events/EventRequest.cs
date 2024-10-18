namespace Patterns.Lab3.Events
{
    public class EventRequest
    {
        public bool Handled { get; private set; } = false;

        public void SetHandled(bool handled)
        {
            Handled = handled;
        }

        public void Consume()
        {
            SetHandled(true);
        }
    }
}
