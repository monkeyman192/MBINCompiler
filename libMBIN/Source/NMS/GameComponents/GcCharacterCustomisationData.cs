using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B1FB2E6CD27F8B1, NameHash = 0xBF5911FBC471448F)]
    public class GcCharacterCustomisationData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcCharacterCustomisationBoneScaleData> BoneScales;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcCharacterCustomisationColourData> Colours;
        [NMS(Index = 0)]
        /* 0x20 */ public List<NMSString0x10> DescriptorGroups;
        [NMS(Index = 2)]
        /* 0x30 */ public List<GcCharacterCustomisationTextureOptionData> TextureOptions;
        [NMS(Index = 4)]
        /* 0x40 */ public float Scale;
    }
}
