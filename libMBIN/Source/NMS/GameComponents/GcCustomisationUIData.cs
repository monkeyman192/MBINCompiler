using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2EB424180B205DA8, NameHash = 0xFA6C3AD3E80DE203)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x18, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x0 */ public GcCustomisationUI[] CustomisationUIData;
    }
}
