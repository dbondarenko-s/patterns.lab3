using Patterns.Lab3.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.Lab3.Widgets
{
    public abstract class UIComponent : IHandler
    {
        private IHandler _nextHandler;

        private ICollection<IPressListener> _listeners = new List<IPressListener>();

        public abstract bool Draw(int line);

        public abstract int GetHeight();

        public abstract int GetWidth();

        public void SetNextHandler(IHandler next)
        {
            _nextHandler = next;
        }

        public void AddPressListener(IPressListener l)
        {
            _listeners.Add(l);
        }

        public void RemovePressListener(IPressListener l)
        {
            _listeners.Remove(l);
        }

        public void Handle(EventRequest request)
        {
            foreach (var item in _listeners)
            {
                if (request.Handled)
                {
                    return;
                }

                item.Press(this, request);
            }

            if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }
    }
}
