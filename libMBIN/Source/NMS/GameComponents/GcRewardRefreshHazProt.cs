using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF5A7128CB187223, NameHash = 0xFCAC7902)]
    public class GcRewardRefreshHazProt : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Amount;
        [NMS(Index = 3)]
        /* 0x4 */ public GcPlayerHazardType SpecificHazard;
        [NMS(Index = 1)]
        /* 0x8 */ public bool SetNotAdd;
        [NMS(Index = 2)]
        /* 0x9 */ public bool Silent;
    }
}
