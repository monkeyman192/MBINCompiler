using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98C51EF5B4DB8CD4, NameHash = 0xC9D7FFE72FBDED51)]
    public class GcDiscoveryWorth : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x00 */ public int[] OnScan;
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0C */ public int[] Record;
        [NMS(Index = 2)]
        /* 0x18 */ public int Mission;
    }
}
