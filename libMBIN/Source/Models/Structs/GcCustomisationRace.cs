using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x38)]
    public class GcCustomisationRace : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string DescriptorGroupOption;
        /* 0x10 */ public bool IsGek;
        /* 0x14 */ public float Scale;
        /* 0x18 */ public GcCustomisationGroups CustomisationGroups;
        /* 0x28 */ public List<NMSString0x10> Presets;
    }
}
