using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x13558A7DA3393C8A, NameHash = 0x2B457A50)]
    public class GcFrigateFlyByData : NMSTemplate
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
