using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x580, GUID = 0xB10F673A15AB98AF, NameHash = 0xFA6C3AD3E80DE203)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        public GcCustomisationUI[] CustomisationUIData;
    }
}
