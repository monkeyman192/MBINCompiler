using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x258B7B9B1934FA6B, NameHash = 0xD04EA6F623D821D9)]
    public class GcPlanetGroundCombatData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector2f FlybyTimer;
        [NMS(Index = 2)]
        /* 0x08 */ public Vector2f SentinelTimer;
        [NMS(Index = 1)]
        /* 0x10 */ public int MaxActiveDrones;
        [NMS(Index = 0)]
        /* 0x14 */ public GcPlanetSentinelLevel SentinelLevel;
    }
}
