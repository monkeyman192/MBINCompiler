using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25120F06105DBEDF, NameHash = 0x273376F8)]
    public class GcCharacterCustomisationData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<GcCharacterCustomisationBoneScaleData> BoneScales;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcCharacterCustomisationColourData> Colours;
        [NMS(Index = 0)]
        /* 0x20 */ public List<NMSString0x10> DescriptorGroups;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 PaletteID;
        [NMS(Index = 3)]
        /* 0x40 */ public List<GcCharacterCustomisationTextureOptionData> TextureOptions;
        [NMS(Index = 5)]
        /* 0x50 */ public float Scale;
    }
}
