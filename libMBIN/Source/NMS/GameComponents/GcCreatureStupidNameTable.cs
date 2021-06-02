using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0xC9DD036CB59D969D, NameHash = 0x4992418A4C059481)]
    public class GcCreatureStupidNameTable : NMSTemplate
    {
        public NMSString0x80 StupidUserName;

        public List<GcCreatureStupidName> Table;
    }
}