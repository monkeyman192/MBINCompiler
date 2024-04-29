using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D1F78B6F0AA4334, NameHash = 0xEF9D92B5E5974FCC)]
    public class GcPoliceSpawnWaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcAIShipSpawnData ShipData;
        [NMS(Index = 1, Size = 0x4)]
        /* 0x1C0 */ public int[] MaxCountsForFireteamSize;
    }
}
