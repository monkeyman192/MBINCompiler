using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcStatsGroup : NMSTemplate
    {
        public NMSString0x10 Id;

        public TkTextureResource Icon;

        public List<GcStatsEntry> StatIds;
    }
}
