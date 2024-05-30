using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B8D8BF999CA7123, NameHash = 0x3339FF1DC3ABF146)]
    public class GcExperienceDebugTriggerAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcExperienceDebugTriggerActionTypes Action;
        [NMS(Index = 1)]
        /* 0x4 */ public int IntParameter;
    }
}
