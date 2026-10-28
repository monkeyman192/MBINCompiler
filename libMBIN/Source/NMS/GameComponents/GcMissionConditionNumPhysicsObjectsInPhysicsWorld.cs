using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x88453A1969BBA98E, NameHash = 0x711C0659)]
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
        [NMS(Index = 10)]
        /* 0x40 */ public GcDeliverableType DeliverableType;
        [NMS(Index = 8)]
        /* 0x44 */ public GcStaticTag ObjectTypeOverride;
        [NMS(Index = 0)]
        /* 0x48 */ public int RequiredNumObjects;
        [NMS(Index = 5)]
        /* 0x4C */ public TkEqualityEnum Test;
        [NMS(Index = 2)]
        /* 0x50 */ public bool TakeAmountFromDefaultNumber;
        [NMS(Index = 1)]
        /* 0x51 */ public bool TakeNumFromSeasonData;
        [NMS(Index = 11)]
        /* 0x52 */ public bool TestForMissionSeed;
        [NMS(Index = 9)]
        /* 0x53 */ public bool UseDeliverableType;
    }
}
