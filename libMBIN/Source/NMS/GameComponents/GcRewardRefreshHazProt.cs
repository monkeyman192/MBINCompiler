using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x318B5FB5C38837A7, NameHash = 0xFCAC7902)]
    public class GcRewardRefreshHazProt : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Amount;
        [NMS(Index = 4)]
        /* 0x4 */ public float RechargeDelay;
        [NMS(Index = 3)]
        /* 0x8 */ public GcPlayerHazardType SpecificHazard;
        [NMS(Index = 1)]
        /* 0xC */ public bool SetNotAdd;
        [NMS(Index = 2)]
        /* 0xD */ public bool Silent;
    }
}
