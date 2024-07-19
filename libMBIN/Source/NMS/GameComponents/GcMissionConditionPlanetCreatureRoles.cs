using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD645F28189DA9312, NameHash = 0x2EDEF58E)]
    public class GcMissionConditionPlanetCreatureRoles : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int NumRoles;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
        [NMS(Index = 2)]
        /* 0x8 */ public bool TakeNumFromSeasonData;
    }
}
