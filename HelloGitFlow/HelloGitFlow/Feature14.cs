using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitFlow
{
    public class Feature14
    {
        public Feature14() { }

        public void Start(Feature10 f10)
        {
            if (f10.Name != null)
                Console.WriteLine(f10.Name);
        }
    }
}
