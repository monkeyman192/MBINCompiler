using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x930885517F548F70, NameHash = 0x231919D5AE192450)]
    public class GcCustomisationRace : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcCustomisationGroup> CustomisationGroups;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 DescriptorGroupOption;
        [NMS(Index = 4)]
        /* 0x20 */ public List<NMSString0x10> Presets;
        [NMS(Index = 2)]
        /* 0x30 */ public float Scale;
        [NMS(Index = 1)]
        /* 0x34 */ public bool IsGek;
    }
}
