using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x40)]
    public class GcCustomisationBoneScales : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string GroupTitle;
        [NMS(Size = 0x10)]
        public string ScaleBoneName;
        public List<float> Positions;
    }
}
