using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA8, Alignment = 0x8, GUID = 0xBC0F1CB9999EBBA, NameHash = 0xEB5E59FB895AFF06)]
    public class GcStatsGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;

        /* 0x10 */ public TkTextureResource Icon;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding94;

        /* 0x98 */ public List<GcStatsEntry> StatIds;
    }
}
