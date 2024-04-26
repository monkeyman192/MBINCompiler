namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62BF06516460DDC8, NameHash = 0x3D555D4C64B13971)]
    public class GcRewardScanEventNearestBuilding : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool DoAerialScan;
        [NMS(Index = 1)]
        /* 0x1 */ public bool IncludeVisited;
    }
}
