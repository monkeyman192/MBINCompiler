namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEE2D68A0ACD6454, NameHash = 0xAD8C5D131CC2AD70)]
    public class GcMissionConditionNearRobotSite : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Distance;
        [NMS(Index = 1)]
        /* 0x4 */ public bool RequireNPCs;
        [NMS(Index = 2)]
        /* 0x5 */ public bool RequireRevealTech;
    }
}
