using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8283F0189C3113D4, NameHash = 0xFCFB8A97D2A5B063)]
    public class GcLootProbability : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource LootModel;
        [NMS(Index = 1)]
        /* 0x84 */ public float Probability;
    }
}
