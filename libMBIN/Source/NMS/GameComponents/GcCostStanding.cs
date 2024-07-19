using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9EC36BB48ED83363, NameHash = 0x394B9EA5)]
    public class GcCostStanding : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcAlienRace Race;
        [NMS(Index = 1)]
        /* 0x4 */ public int RequiredStanding;
        [NMS(Index = 2)]
        /* 0x8 */ public bool UseCurrentRankString;
    }
}
