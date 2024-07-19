using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB69632BA171F8A5D, NameHash = 0x298D7312)]
    public class GcExperienceDebugTriggerAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcExperienceDebugTriggerActionTypes Action;
        [NMS(Index = 1)]
        /* 0x4 */ public int IntParameter;
    }
}
