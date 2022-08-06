using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x761C544A3E503351, NameHash = 0xA29C133FB960AEB2)]
    public class GcCustomisationDescriptorGroupOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DescriptorOption;
        /* 0x10 */ public List<GcCustomisationTextureGroup> TextureGroups;
        /* 0x20 */ public bool ReplaceBaseColours;
        /* 0x28 */ public List<GcCustomisationColourGroup> ColourGroups;
        /* 0x38 */ public bool ReplaceBaseBoneScales;
        /* 0x40 */ public List<GcCustomisationBoneScales> BoneScales;
        /* 0x50 */ public int InteractionCameraIndexOverride;
        /* 0x54 */ public NMSString0x20 InteracttionCameraFocusJointOverride;
        /* 0x78 */ public List<NMSString0x10> HideIfGroupActive;
        /* 0x88 */ public List<NMSString0x10> SelectingRemovesGroup;
        /* 0x98 */ public List<NMSString0x10> SelectingAddsGroup;
        /* 0xA8 */ public List<NMSString0x10> UnselectingRemovesGroup;
        /* 0xB8 */ public List<NMSString0x10> UnselectingAddsGroup;
    }
}
