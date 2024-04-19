using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0D50BB746B55DA9, NameHash = 0xEF9D92B5E5974FCC)]
    public class GcPoliceSpawnWaveData : NMSTemplate
    {
        /* 0x000 */ public GcAIShipSpawnData ShipData;
        [NMS(Size = 0x4)]
        /* 0x1C0 */ public int[] MaxCountsForFireteamSize;
    }
}
