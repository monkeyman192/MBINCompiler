using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x78, GUID = 0xB58FA1EE8A51F1E1, NameHash = 0xA29C133FB960AEB2)]
    public class GcCustomisationDescriptorGroupOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DescriptorOption;
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
        /* 0x54 */ public NMSString0x20 InteracttionCameraFocusJointOverride;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x74 */ public byte[] EndPadding;
    }
}
