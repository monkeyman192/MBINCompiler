using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4159CACC869C038, NameHash = 0x9F906ED9)]
    public class GcNPCAnimationsData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcNPCAnimationSetData SittingAnimatons;
        [NMS(Index = 4)]
        /* 0x170 */ public GcNPCAnimationSetData SittingIPadAnimatons;
        [NMS(Index = 0)]
        /* 0x2E0 */ public GcNPCAnimationSetData StandingAnimatons;
        [NMS(Index = 1)]
        /* 0x450 */ public GcNPCAnimationSetData StandingIPadAnimatons;
        [NMS(Index = 2)]
        /* 0x5C0 */ public GcNPCAnimationSetData StandingStaffAnimatons;
    }
}
