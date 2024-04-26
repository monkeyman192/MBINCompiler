using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1E8F5FEA4CE3E2D, NameHash = 0x78D4180CEDFDC316)]
    public class GcPlayerCharacterAnimationOverrideData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcPlayerCharacterIKOverrideData Data;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 AnimName;
    }
}
