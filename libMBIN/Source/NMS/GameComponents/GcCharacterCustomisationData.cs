using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x1E2E3056699C2A6C, NameHash = 0xBF5911FBC471448F)]
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
