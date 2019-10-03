using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x78, GUID = 0x9B32669013DA630C, NameHash = 0xA29C133FB960AEB2)]
    public class GcCustomisationDescriptorGroupOption : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string DescriptorOption;
        /* 0x10 */ public List<GcCustomisationTextureGroup> TextureGroups;
        /* 0x20 */ public bool ReplaceBaseColours;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x20 */ public byte[] Padding21;
        /* 0x28 */ public List<GcCustomisationColourGroup> ColourGroups;
        /* 0x38 */ public bool ReplaceBaseBoneScales;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x39 */ public byte[] Padding39;
        /* 0x40 */ public List<GcCustomisationBoneScales> BoneScales;
        /* 0x50 */ public int InteractionCameraIndexOverride;
        [NMS(Size = 0x20)]
        /* 0x54 */ public string InteracttionCameraFocusJointOverride;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x74 */ public byte[] EndPadding;
    }
}
