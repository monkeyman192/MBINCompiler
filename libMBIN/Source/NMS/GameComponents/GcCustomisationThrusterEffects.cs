using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69E5EE8C86E99892, NameHash = 0xFD3FA61F96564C04)]
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
