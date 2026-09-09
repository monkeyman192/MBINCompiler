using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD319F2C0F8D75E5D, NameHash = 0x711C0659)]
    public class GcMissionConditionNumPhysicsObjectsInPhysicsWorld : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 NumIsDiffBetweenMissionStatAndThisStat;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSString0x10 SubtractThisStatFromNumReq;
        [NMS(Index = 6)]
        /* 0x20 */ public VariableSizeString TextTagForCurrent;
        [NMS(Index = 7)]
        /* 0x30 */ public VariableSizeString TextTagForTarget;
        [NMS(Index = 8)]
        /* 0x40 */ public GcStaticTag ObjectTypeOverride;
        [NMS(Index = 0)]
        /* 0x44 */ public int RequiredNumObjects;
        [NMS(Index = 5)]
        /* 0x48 */ public TkEqualityEnum Test;
        [NMS(Index = 2)]
        /* 0x4C */ public bool TakeAmountFromDefaultNumber;
        [NMS(Index = 1)]
        /* 0x4D */ public bool TakeNumFromSeasonData;
    }
}
