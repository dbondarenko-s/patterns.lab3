using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Lab3.Events
{
    public class PressListener : IPressListener
    {
        private readonly string _text;

        public PressListener(string text)
        {
            _text = text;
        }

        public void Press(object sender, EventRequest e)
        {
            Console.WriteLine(_text);
        }
    }
}
