namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x2)]
    public class GcMissionConditionOnOtherSideOfPortal : NMSTemplate
    {
        /* 0x0 */ public bool TestForRegularPortal;
        /* 0x1 */ public bool TestForStoryPortal;
    }
}
