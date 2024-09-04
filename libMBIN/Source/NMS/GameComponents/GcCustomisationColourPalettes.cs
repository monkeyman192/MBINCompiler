using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E5F89E7DA6063AD, NameHash = 0x5B43B452)]
    public class GcCustomisationColourPalettes : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x19, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x000 */ public NMSString0x10[] CustomisationTypePalettes;
        [NMS(Index = 0)]
        /* 0x190 */ public List<GcCustomisationColourPalette> Palettes;
    }
}
