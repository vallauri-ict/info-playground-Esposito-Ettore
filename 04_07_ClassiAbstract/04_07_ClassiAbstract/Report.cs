using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_07_ClassiAbstract
{
    abstract class Report
    {
        protected abstract void PrintHeader();
        protected abstract void PrintBody();
        protected abstract void PrintFooter();

        public void PrintReport()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }
}
