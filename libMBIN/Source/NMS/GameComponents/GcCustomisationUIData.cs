using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48332DCDA5EFD63B, NameHash = 0xE21986C9)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x18, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x0 */ public GcCustomisationUI[] CustomisationUIData;
    }
}
