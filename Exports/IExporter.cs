using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Lab3.Exports
{
    public interface IExporter : IExportVisitor
    {
        void Start();

        void End();

        void Delimeter();
    }
}
