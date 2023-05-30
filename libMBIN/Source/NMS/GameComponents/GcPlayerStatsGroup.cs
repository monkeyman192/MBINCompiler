using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlayerStatsGroup : NMSTemplate // 0x28 bytes
    {
        public NMSString0x10 GroupId;

        public ulong Address;

        public List<GcPlayerStat> Stats;
    }
}
