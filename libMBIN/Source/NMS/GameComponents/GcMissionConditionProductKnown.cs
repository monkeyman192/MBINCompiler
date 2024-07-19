using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2A719066F4FD48F7, NameHash = 0x2439CF8)]
    public class GcMissionConditionProductKnown : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Product;
        [NMS(Index = 1)]
        /* 0x10 */ public GcDefaultMissionProductEnum Default;
        [NMS(Index = 2)]
        /* 0x14 */ public bool DependentOnSeasonMilestone;
        [NMS(Index = 3)]
        /* 0x15 */ public bool TakeProductFromSeasonData;
    }
}
