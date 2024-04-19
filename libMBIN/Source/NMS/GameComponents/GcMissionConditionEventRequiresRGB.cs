using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74AC42112C063A55, NameHash = 0x36CE03A85A61CBFB)]
    public class GcMissionConditionEventRequiresRGB : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
        /* 0x20 */ public GcGalaxyStarTypes StarType;
        /* 0x24 */ public bool IgnoreIfPlayerHasAccess;
    }
}
