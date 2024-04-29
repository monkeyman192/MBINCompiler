using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA528B110F0C1472C, NameHash = 0xFCFB8A97D2A5B063)]
    public class GcLootProbability : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource LootModel;
        [NMS(Index = 1)]
        /* 0x84 */ public float Probability;
    }
}
