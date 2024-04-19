using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0D8E65FE96B47C2, NameHash = 0xB5A01AE676FD46D)]
    public class GcCustomisationGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A GroupTitle;
        /* 0x20 */ public List<GcCustomisationBoneScales> BoneScales;
        /* 0x30 */ public List<GcCustomisationColourGroup> ColourGroups;
        /* 0x40 */ public List<GcCustomisationDescriptorGroupOptions> DescriptorOptions;
        /* 0x50 */ public NMSString0x10 GroupID;
        /* 0x60 */ public List<GcCustomisationTextureGroup> TextureGroups;
        /* 0x70 */ public GcCustomisationCameraData CameraData;
        /* 0xA4 */ public bool ForceShowAllColourOptions;
        /* 0xA5 */ public bool IsBannerGroup;
    }
}
