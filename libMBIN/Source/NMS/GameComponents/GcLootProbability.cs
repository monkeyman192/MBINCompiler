using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x86EDD16B8E8CC77C, NameHash = 0x56FE448D)]
    public class GcLootProbability : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource LootModel;
        [NMS(Index = 1)]
        /* 0x18 */ public float Probability;
    }
}
