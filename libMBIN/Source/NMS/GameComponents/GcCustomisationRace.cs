using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57B1D2DD72D13E15, NameHash = 0x3246D64F)]
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
