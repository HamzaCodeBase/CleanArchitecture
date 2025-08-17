using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Misc
{
    public static class Misc
    {
        public static string GetWorkerProcessName()
        {
            return System.Diagnostics.Process.GetCurrentProcess().ProcessName;
        }
    }
}
