using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Lab3.Exports
{
    public interface IExportable
    {
        void Accept(IExportVisitor v);
    }
}
