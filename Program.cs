using Patterns.Lab3.Events;
using Patterns.Lab3.Exports;
using Patterns.Lab3.Graph;
using Patterns.Lab3.Widgets;

namespace Patterns.Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompositeControl mainWindow = new MainWindow();

            CompositeControl frame1 = new CompositeControl();

            CompositeControl frame2 = new CompositeControl();

            frame1.Add(new Label("Login")).Add(new Button("OK"));

            frame2.Add(new Label("Password")).Add(new Button("Verify"));

            Button printButton = new Button("Print");

            mainWindow.Add(frame1).Add(frame2).Add(new CompositeControl().Add(printButton));

            mainWindow.AddPressListener(new PressListener("MainWin handler"));

            printButton.AddPressListener(new PressListener("Button press first handler"));

            mainWindow.Draw();

            printButton.AddPressListener(new PressListener("Button press second handler"));

            printButton.Press();

            AbstractGOFactory gof = new ColorGOFactory();

            gof.CreatePoint().SetColor("red");

            gof.CreatePoint().SetColor("green");

            gof.CreateCircle().SetColor("blue");

            Scene.GetInstance().Draw();

            Scene.GetInstance().Export(new XMLExport(true));
        }
    }
}
