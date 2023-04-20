using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MiniFileBase
{
    abstract public class Button : IRunnable, IButton
    {
        public char Id { get; set; }

        public string Caption { get; set; }

        abstract public void Run();
    }
}
