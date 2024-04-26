using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE2A6A2AEC12ACCD, NameHash = 0x529C5D98B446B5B2)]
    public class GcCostStanding : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcAlienRace Race;
        [NMS(Index = 1)]
        /* 0x4 */ public int RequiredStanding;
    }
}
