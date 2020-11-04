using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_ClassiIndexate
{
    class IndexClass
    {
        private string[] element;

        public IndexClass(int dim)
        {
            element = new string[dim];
            for (int i = 0; i < dim; i++)
                element[i] = "Empty";
        }

        public string this[int pos]
        {
            get { return element[pos]; }
            set { element[pos] = value; }
        }

        public int lenght()
        {
            return element.Length;
        }
    }
}
