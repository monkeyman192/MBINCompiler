using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C75540CD2D41D04, NameHash = 0xD04EA6F623D821D9)]
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
