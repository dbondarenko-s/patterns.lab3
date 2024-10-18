using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Lab3.Widgets
{
    public class CompositeControl : UIComponent
    {
        protected static string CompositeFrame = "+";

        protected ICollection<UIComponent> Children = new List<UIComponent>();

        public CompositeControl Add(UIComponent component)
        {
            Children.Add(component);

            component.SetNextHandler(this);

            return this;
        }

        public void Remove(UIComponent component)
        {
            Children.Remove(component);
        }

        public ICollection<UIComponent> GetChildren()
        {
            return Children;
        }

        public void Draw()
        {
            for (int i = 0; i < GetHeight(); i++)
            {
                Draw(i);
            }  
        }

        private void PrintBorder()
        {
            for (int i = 0; i < GetWidth() - 1; i++)
            {
                Console.Write(CompositeFrame);
            }
        }

        public override bool Draw(int line)
        {
            if (line == 0 || line == GetHeight() - 1)
            {
                PrintBorder();

                DrawLineFinish();

                return true;
            }

            if (line > 0 && line < GetHeight() - 1)
            {
                Console.Write(CompositeFrame);

                foreach (var component in Children)
                {
                    if (!component.Draw(line - 1))
                    {
                        for (int i = 0; i < component.GetWidth(); i++)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                    
                DrawLineFinish();

                return true;
            }

            return false;
        }

        public virtual void DrawLineFinish()
        {
            Console.Write(CompositeFrame);
        }

        public override int GetHeight()
        {
            int max = 0;

            foreach (var component in Children)
            {
                if (component.GetHeight() > max)
                {
                    max = component.GetHeight();
                }
            }
                
            return max + 2;
        }

        public override int GetWidth()
        {
            int summa = 0;

            foreach (var component in Children)
            {
                summa += component.GetWidth();
            }

            return summa + 2;
        }

    }
}
