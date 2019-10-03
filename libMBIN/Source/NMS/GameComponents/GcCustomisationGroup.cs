using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA8, GUID = 0xFDE09687B953C622, NameHash = 0xB5A01AE676FD46D)]
    public class GcCustomisationGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string GroupID;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string GroupTitle;
        /* 0x30 */ public bool IsBannerGroup;
        /* 0x34 */ public GcCustomisationCameraData CameraData;
        /* 0x68 */ public List<GcCustomisationDescriptorGroupOptions> DescriptorOptions;
        /* 0x78 */ public List<GcCustomisationTextureGroup> TextureGroups;
        /* 0x88 */ public List<GcCustomisationColourGroup> ColourGroups;
        /* 0x98 */ public List<GcCustomisationBoneScales> BoneScales;
    }
}
