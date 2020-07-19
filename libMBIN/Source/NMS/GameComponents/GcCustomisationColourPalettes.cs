using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4300, GUID = 0x94332187E55E7E7B, NameHash = 0x8D353F7BD3E655C5)]
    public class GcCustomisationColourPalettes : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x0000 */ public GcPaletteData[] ColourPalettes;
        [NMS(Size = 0x10, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x4100 */ public GcCustomisationColourPaletteExtraData[] ExtraData;
    }
}
