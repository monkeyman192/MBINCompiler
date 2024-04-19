using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x930885517F548F70, NameHash = 0x231919D5AE192450)]
    public class GcCustomisationRace : NMSTemplate
    {
        /* 0x00 */ public List<GcCustomisationGroup> CustomisationGroups;
        /* 0x10 */ public NMSString0x10 DescriptorGroupOption;
        /* 0x20 */ public List<NMSString0x10> Presets;
        /* 0x30 */ public float Scale;
        /* 0x34 */ public bool IsGek;
    }
}
