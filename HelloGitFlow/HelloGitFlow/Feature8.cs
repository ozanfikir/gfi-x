using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitFlow
{
    public class Feature8
    {
        public string Name
        {
            get
            {
                return string.Format("{0}-{1}", InternalName, Index);
            }
        }

        public int Index { get; set; }

        public string InternalName { get; set; }

        public Feature8(string name)
        {
            InternalName = name;
        }

        public Feature8(string name, int index)
        {
            InternalName = name;
            Index = index;
        }
    }
}
