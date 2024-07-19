using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF1C9A5A6059D4FF1, NameHash = 0xC8671A02)]
    public class GcSquadronPilotData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcResourceElement NPCResource;
        [NMS(Index = 1)]
        /* 0x48 */ public GcResourceElement ShipResource;
        [NMS(Index = 2)]
        /* 0x90 */ public ulong TraitsSeed;
        [NMS(Index = 3)]
        /* 0x98 */ public ushort PilotRank;
    }
}
