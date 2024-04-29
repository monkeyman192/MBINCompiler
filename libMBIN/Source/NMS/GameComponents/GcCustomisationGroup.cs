using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA529F031CCA53BF, NameHash = 0xB5A01AE676FD46D)]
    public class GcCustomisationGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A GroupTitle;
        [NMS(Index = 8)]
        /* 0x20 */ public List<GcCustomisationBoneScales> BoneScales;
        [NMS(Index = 7)]
        /* 0x30 */ public List<GcCustomisationColourGroup> ColourGroups;
        [NMS(Index = 5)]
        /* 0x40 */ public List<GcCustomisationDescriptorGroupOptions> DescriptorOptions;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 GroupID;
        [NMS(Index = 6)]
        /* 0x60 */ public List<GcCustomisationTextureGroup> TextureGroups;
        [NMS(Index = 4)]
        /* 0x70 */ public GcCustomisationCameraData CameraData;
        [NMS(Index = 3)]
        /* 0xA4 */ public bool ForceShowAllColourOptions;
        [NMS(Index = 2)]
        /* 0xA5 */ public bool IsBannerGroup;
    }
}
