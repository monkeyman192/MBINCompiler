using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC60C8A2C2D872B0C, NameHash = 0x78D4180CEDFDC316)]
    public class GcPlayerCharacterAnimationOverrideData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcPlayerCharacterIKOverrideData Data;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 AnimName;
    }
}
