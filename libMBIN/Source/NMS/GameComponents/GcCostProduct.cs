using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3334E18F19B1BB24, NameHash = 0xD1E565BF)]
    public class GcCostProduct : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 0)]
        /* 0x14 */ public GcDefaultMissionProductEnum Default;
        [NMS(Index = 3)]
        /* 0x18 */ public bool UseDefaultAmount;
    }
}
