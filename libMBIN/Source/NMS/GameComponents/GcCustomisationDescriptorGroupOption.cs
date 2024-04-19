using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE1A812D8DF9CB6A, NameHash = 0xA29C133FB960AEB2)]
    public class GcCustomisationDescriptorGroupOption : NMSTemplate
    {
        /* 0x00 */ public List<GcCustomisationBoneScales> BoneScales;
        /* 0x10 */ public List<GcCustomisationColourGroup> ColourGroups;
        /* 0x20 */ public NMSString0x10 DescriptorOption;
        /* 0x30 */ public List<NMSString0x10> HideIfGroupActive;
        /* 0x40 */ public List<NMSString0x10> SelectingAddsGroup;
        /* 0x50 */ public List<NMSString0x10> SelectingRemovesGroup;
        /* 0x60 */ public List<GcCustomisationTextureGroup> TextureGroups;
        /* 0x70 */ public List<NMSString0x10> UnselectingAddsGroup;
        /* 0x80 */ public List<NMSString0x10> UnselectingRemovesGroup;
        /* 0x90 */ public int InteractionCameraIndexOverride;
        /* 0x94 */ public NMSString0x20 InteracttionCameraFocusJointOverride;
        /* 0xB4 */ public bool ReplaceBaseBoneScales;
        /* 0xB5 */ public bool ReplaceBaseColours;
    }
}
