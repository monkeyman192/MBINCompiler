using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureStupidNameTable : NMSTemplate
    {
        public NMSString0x80 StupidUserName;

        public List<GcCreatureStupidName> Table;
    }
}
