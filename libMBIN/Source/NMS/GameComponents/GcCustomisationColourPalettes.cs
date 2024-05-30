using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x287BD52A6CA7522E, NameHash = 0x8D353F7BD3E655C5)]
    public class GcCustomisationColourPalettes : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x18, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x000 */ public NMSString0x10[] CustomisationTypePalettes;
        [NMS(Index = 0)]
        /* 0x180 */ public List<GcCustomisationColourPalette> Palettes;
    }
}
