using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C4DA3C5384B20FF, NameHash = 0x5B43B452)]
    public class GcCustomisationColourPalettes : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x18, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x000 */ public NMSString0x10[] CustomisationTypePalettes;
        [NMS(Index = 0)]
        /* 0x180 */ public List<GcCustomisationColourPalette> Palettes;
    }
}
