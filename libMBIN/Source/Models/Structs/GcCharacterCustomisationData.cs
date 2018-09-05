using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x48)]
    public class GcCharacterCustomisationData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> DescriptorGroups;
        /* 0x10 */ public List<GcCharacterCustomisationColourData> Colours;
        /* 0x20 */ public List<GcCharacterCustomisationTextureOptionData> TextureOptions;
        /* 0x30 */ public List<GcCharacterCustomisationBoneScaleData> BoneScales;
        /* 0x40 */ public float Scale;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x44 */ public byte[] EndPadding;
    }
}
