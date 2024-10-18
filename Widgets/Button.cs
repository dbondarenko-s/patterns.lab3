namespace Patterns.Lab3.Widgets
{
    using Patterns.Lab3.Events;

    public class Button : ContentControl
    {
        public static string ButtonFrame = "*";

        public Button()
        {
        }

        public Button(string text) : base(text) { }

        private void PrintBorder()
        {
            for (int i = 0; i < GetText().Length; i++)
            {
                Console.Write(ButtonFrame);
            }
        }

        public override bool Draw(int line)
        {
            if (line == 0 || line == 2)
            {
                Console.Write(ButtonFrame);

                PrintBorder();

                Console.Write(ButtonFrame);

                return true;
            }
            if (line == 1)
            {
                Console.Write(ButtonFrame);

                Console.Write(GetText());

                Console.Write(ButtonFrame);

                return true;
            }
            return false;
        }

        public override int GetHeight()
        {
            return 3;
        }

        public void Press()
        {
		    Console.WriteLine("Button pressed");

            Handle(new EventRequest());
        }
    }
}
