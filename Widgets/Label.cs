namespace Patterns.Lab3.Widgets
{
    public class Label : ContentControl
    {
        public Label(string text) : base(text) { }

        public override bool Draw(int line)
        {
            if (line == 0)
            {
                Console.Write($" {GetText()} ");

                return true;
            }
            return false;
        }
    }
}
