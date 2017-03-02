using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBEApp_v1._0
{
    abstract class AbstractSink
    {
        public abstract void setOptions(string aOptions);

        public abstract object getOutputNode(object aUpStreamMediaType);
    }
}
