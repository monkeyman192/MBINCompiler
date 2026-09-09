using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16ED436724AE09F4, NameHash = 0xE21986C9)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x1A, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x0 */ public GcCustomisationUI[] CustomisationUIData;
    }
}
