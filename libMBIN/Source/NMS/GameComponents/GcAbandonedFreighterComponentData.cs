using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4EB3B314D54DBCE, NameHash = 0x6F8085E)]
    public class GcAbandonedFreighterComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A MarkerLabel;
        [NMS(Index = 0)]
        /* 0x20 */ public TkModelResource DungeonRootScene;
        [NMS(Index = 3)]
        /* 0x38 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 1)]
        /* 0x50 */ public List<GcFreighterDungeonChoice> DungeonOptions;
    }
}
