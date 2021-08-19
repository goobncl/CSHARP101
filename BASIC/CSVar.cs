using System;

namespace BASIC
{
    class CSVar
    {
        int globalVar;
        const int MAX = 1024;

        public void Method1()
        {
            int localVar;
            
            localVar = 100;
            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }
}