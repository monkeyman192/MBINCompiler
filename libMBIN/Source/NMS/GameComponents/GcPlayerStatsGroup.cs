using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x8E0C4DD242A5FA5D, NameHash = 0xEBAB39E2F49FE5F)]
    public class GcPlayerStatsGroup : NMSTemplate // 0x28 bytes
    {
        public NMSString0x10 GroupId;

        public ulong Address;

        public List<GcPlayerStat> Stats;
    }
}