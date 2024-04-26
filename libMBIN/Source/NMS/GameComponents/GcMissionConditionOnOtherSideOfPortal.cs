namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79630CE19B90F4AF, NameHash = 0x7C67CF5773622F4C)]
    public class GcMissionConditionOnOtherSideOfPortal : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool TestForRegularPortal;
        [NMS(Index = 1)]
        /* 0x1 */ public bool TestForStoryPortal;
    }
}
