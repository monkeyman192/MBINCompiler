using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBB9FCA6782A31A70, NameHash = 0x79EA3335C4095B8E)]
    public class GcCustomisationBoneScales : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A GroupTitle;
        /* 0x20 */ public List<float> Positions;
        /* 0x30 */ public NMSString0x10 ScaleBoneName;
    }
}
