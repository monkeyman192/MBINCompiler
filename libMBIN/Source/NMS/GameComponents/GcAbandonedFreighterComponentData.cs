using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDFC505E8066AB0E7, NameHash = 0x95028D8CB7957BEF)]
    public class GcAbandonedFreighterComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A MarkerLabel;
        /* 0x20 */ public List<GcFreighterDungeonChoice> DungeonOptions;
        /* 0x30 */ public TkModelResource DungeonRootScene;
        /* 0xB4 */ public TkTextureResource MarkerIcon;
    }
}
