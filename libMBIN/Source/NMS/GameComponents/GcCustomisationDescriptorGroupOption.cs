using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x84889EC98C27DBD0, NameHash = 0xA29C133FB960AEB2)]
    public class GcCustomisationDescriptorGroupOption : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<GcCustomisationBoneScales> BoneScales;
        [NMS(Index = 3)]
        /* 0x10 */ public List<GcCustomisationColourGroup> ColourGroups;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 DescriptorOption;
        [NMS(Index = 8)]
        /* 0x30 */ public List<NMSString0x10> HideIfGroupActive;
        [NMS(Index = 10)]
        /* 0x40 */ public List<NMSString0x10> SelectingAddsGroup;
        [NMS(Index = 9)]
        /* 0x50 */ public List<NMSString0x10> SelectingRemovesGroup;
        [NMS(Index = 1)]
        /* 0x60 */ public List<GcCustomisationTextureGroup> TextureGroups;
        [NMS(Index = 12)]
        /* 0x70 */ public List<NMSString0x10> UnselectingAddsGroup;
        [NMS(Index = 11)]
        /* 0x80 */ public List<NMSString0x10> UnselectingRemovesGroup;
        [NMS(Index = 6)]
        /* 0x90 */ public int InteractionCameraIndexOverride;
        [NMS(Index = 7)]
        /* 0x94 */ public NMSString0x20 InteracttionCameraFocusJointOverride;
        [NMS(Index = 4)]
        /* 0xB4 */ public bool ReplaceBaseBoneScales;
        [NMS(Index = 2)]
        /* 0xB5 */ public bool ReplaceBaseColours;
    }
}
