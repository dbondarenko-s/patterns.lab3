namespace Patterns.Lab3.Widgets
{
    public class MainWindow : CompositeControl
    {
        public override void DrawLineFinish()
        {
            base.DrawLineFinish();

            Console.WriteLine();
        }
    }
}
