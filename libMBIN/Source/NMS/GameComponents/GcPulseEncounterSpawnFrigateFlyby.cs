using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x111FE58DEE53BB1A, NameHash = 0x409E4BD41C6295C9)]
    public class GcPulseEncounterSpawnFrigateFlyby : NMSTemplate
    {
        /* 0x00 */ public GcFrigateFlybyType FlybyType;
        /* 0x08 */ public NMSString0x20A CommunicatorOSDLocId;
        /* 0x28 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
    }
}
