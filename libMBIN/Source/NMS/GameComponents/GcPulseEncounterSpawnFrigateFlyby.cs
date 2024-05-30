using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32BDBD4966E84E19, NameHash = 0x409E4BD41C6295C9)]
    public class GcPulseEncounterSpawnFrigateFlyby : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
        [NMS(Index = 2)]
        /* 0x50 */ public NMSString0x20A CommunicatorOSDLocId;
        [NMS(Index = 0)]
        /* 0x70 */ public GcFrigateFlybyType FlybyType;
        [NMS(Index = 1)]
        /* 0x74 */ public float RangeOverride;
    }
}
