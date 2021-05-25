using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x9C6FF0332EAD43B3, NameHash = 0x36CE03A85A61CBFB)]
    public class GcMissionConditionEventRequiresRGB : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Event;
        /* 0x20 */ public bool IgnoreIfPlayerHasAccess;
        /* 0x24 */ public GcGalaxyStarTypes StarType;
    }
}
