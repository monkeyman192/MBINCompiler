using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF7254B0803F8138, NameHash = 0x95028D8CB7957BEF)]
    public class GcAbandonedFreighterComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A MarkerLabel;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcFreighterDungeonChoice> DungeonOptions;
        [NMS(Index = 0)]
        /* 0x30 */ public TkModelResource DungeonRootScene;
        [NMS(Index = 3)]
        /* 0xB4 */ public TkTextureResource MarkerIcon;
    }
}
