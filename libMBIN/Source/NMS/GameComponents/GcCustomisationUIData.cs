using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0E0C4D120E6B265, NameHash = 0xE21986C9)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x19, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x0 */ public GcCustomisationUI[] CustomisationUIData;
    }
}
