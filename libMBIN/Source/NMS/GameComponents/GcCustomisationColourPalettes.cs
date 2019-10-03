using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38E0, GUID = 0xFEB57F7A1D0FB6A8, NameHash = 0x8D353F7BD3E655C5)]
    public class GcCustomisationColourPalettes : NMSTemplate
    {
        [NMS(Size = 0xE, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        public GcPaletteData[] ColourPalettes;
    }
}
