using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8C1E9BFF9FBAD80, NameHash = 0x4B31BB0A)]
    public class GcCustomisationThrusterEffects : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCustomisationBackpackData> BackpackData;
        [NMS(Index = 3)]
        /* 0x10 */ public List<GcCustomisationFreighterEngineEffect> FreighterEngineEffects;
        [NMS(Index = 0)]
        /* 0x20 */ public List<GcCustomisationThrusterEffect> JetpackEffects;
        [NMS(Index = 2)]
        /* 0x30 */ public List<GcCustomisationShipTrails> ShipEffects;
    }
}
