using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x14C86E78A7D7627A, NameHash = 0x231919D5AE192450)]
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
