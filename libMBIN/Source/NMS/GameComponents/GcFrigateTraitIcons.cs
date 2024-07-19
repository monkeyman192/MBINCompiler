using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD8FEBF92EA3C645, NameHash = 0x671DB0FC)]
    public class GcFrigateTraitIcons : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x0 */ public VariableSizeString[] Icons;
    }
}
