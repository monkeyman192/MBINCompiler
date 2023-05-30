using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureStupidName : NMSTemplate
    {
        public NMSString0x10 Id;

        public int Count;
        public List<NMSString0x80> Names;
    }
}
