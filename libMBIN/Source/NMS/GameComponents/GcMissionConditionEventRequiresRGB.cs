using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C6FF0332EAD43B3, NameHash = 0x36CE03A85A61CBFB)]
    public class GcMissionConditionEventRequiresRGB : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
        /* 0x20 */ public bool IgnoreIfPlayerHasAccess;
        /* 0x24 */ public GcGalaxyStarTypes StarType;
    }
}
