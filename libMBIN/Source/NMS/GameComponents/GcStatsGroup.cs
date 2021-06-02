using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA8, Alignment = 0x8, GUID = 0x972BE2E3DFB75904, NameHash = 0xEB5E59FB895AFF06)]
    public class GcStatsGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding94;
        /* 0x98 */ public List<GcStatsEntry> StatIds;
    }
}
