using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Core
{
    interface LogInterface
    {
        LogInterface log(string str);
             LogInterface write();
    }
}
