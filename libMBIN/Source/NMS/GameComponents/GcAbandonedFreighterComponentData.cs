using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x140, GUID = 0xAD72055522079998, NameHash = 0x95028D8CB7957BEF)]
    public class GcAbandonedFreighterComponentData : NMSTemplate
    {
        /* 0x000 */ public TkModelResource DungeonRootScene;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x084 */ public byte[] Padding84;
        /* 0x088 */ public List<GcFreighterDungeonChoice> DungeonOptions;
        /* 0x098 */ public NMSString0x20 MarkerLabel;
        /* 0x0B8 */ public TkTextureResource MarkerIcon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x13C */ public byte[] EndPadding;
    }
}
