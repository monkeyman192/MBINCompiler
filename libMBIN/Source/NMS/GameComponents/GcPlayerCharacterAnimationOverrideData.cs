using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D61E1D98FB2717F, NameHash = 0xB8DCBC7E)]
    public class GcPlayerCharacterAnimationOverrideData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcPlayerCharacterIKOverrideData Data;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 AnimName;
    }
}
