using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitFlow
{
    public class Feature8
    {
        public string Name { get; set; }

        public int Index { get; set; }

        public Feature8(string name)
        {
            Name = name;
        }

        public Feature8(string name, int index)
        {
            Name = name;
            Index = index;
        }
    }
}
