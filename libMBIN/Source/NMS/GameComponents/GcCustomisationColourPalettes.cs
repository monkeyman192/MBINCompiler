using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38E0, GUID = 0xFEB57F7A1D0FB6A8)]
    public class GcCustomisationColourPalettes : NMSTemplate
    {
        [NMS( EnumType = typeof( GcCustomisationComponentData.CustomisationDataTypeEnum ) )]
        public GcPaletteData[] ColourPalettes;
    }
}
