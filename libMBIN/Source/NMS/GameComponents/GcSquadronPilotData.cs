using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4AE5C3A67F6671B, NameHash = 0x1B17AE774F200920)]
    public class GcSquadronPilotData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcResourceElement NPCResource;
        [NMS(Index = 1)]
        /* 0x2A8 */ public GcResourceElement ShipResource;
        [NMS(Index = 2)]
        /* 0x550 */ public ulong TraitsSeed;
        [NMS(Index = 3)]
        /* 0x558 */ public ushort PilotRank;
    }
}
