using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CD0E335A93E3E14, NameHash = 0x10FE4DB9ECB98372)]
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
