using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcCustomisationDescriptorGroupOption : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string DescriptorOption;
        public List<GcCustomisationTextureGroup> TextureGroups;
        public List<GcCustomisationColourGroup> ColourGroups;
    }
}
