using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B3322BD33D5CDCE, NameHash = 0x409E4BD41C6295C9)]
    public class GcPulseEncounterSpawnFrigateFlyby : NMSTemplate
    {
        /* 0x00 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
        /* 0x50 */ public NMSString0x20A CommunicatorOSDLocId;
        /* 0x70 */ public GcFrigateFlybyType FlybyType;
    }
}
