using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x789499B21C9C9C10, NameHash = 0x972DE7E0)]
    public class GcSettlementColourPalette : NMSTemplate
    {
        [NMS(Index = 3, Size = 0x4)]
        /* 0x000 */ public GcSettlementMaterialData[] UpgradeLevel;
        [NMS(Index = 0)]
        /* 0x100 */ public NMSString0x10 Name;
        [NMS(Index = 1)]
        /* 0x110 */ public float RelativeProbability;
        [NMS(Index = 2)]
        /* 0x114 */ public GcBaseBuildingPartStyle Style;
    }
}
