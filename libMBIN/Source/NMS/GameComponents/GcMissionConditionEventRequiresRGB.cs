using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74AC42112C063A55, NameHash = 0x36CE03A85A61CBFB)]
    public class GcMissionConditionEventRequiresRGB : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 2)]
        /* 0x20 */ public GcGalaxyStarTypes StarType;
        [NMS(Index = 1)]
        /* 0x24 */ public bool IgnoreIfPlayerHasAccess;
    }
}
