using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xA8)]
    public class GcCustomisationGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string GroupID;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string GroupTitle;
        /* 0x30 */ public GcCustomisationCameraData CameraData;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x64 */ public byte[] Padding64;
        /* 0x68 */ public GcCustomisationDescriptorGroups DescriptorOptions;
        /* 0x78 */ public List<GcCustomisationTextureGroup> TextureGroups;
        /* 0x88 */ public List<GcCustomisationColourGroup> ColourGroups;
        /* 0x98 */ public List<GcCustomisationBoneScales> BoneScales;
    }
}
