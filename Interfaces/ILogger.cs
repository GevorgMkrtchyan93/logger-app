using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInterfaceApp.Interfaces
{
    interface ILogger
    {
        void Log(string source);
        string CreateLog(Exception source);
    }
}
