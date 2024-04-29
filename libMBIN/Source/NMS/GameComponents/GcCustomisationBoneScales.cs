using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2922CA68978BF69D, NameHash = 0x79EA3335C4095B8E)]
    public class GcCustomisationBoneScales : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A GroupTitle;
        [NMS(Index = 2)]
        /* 0x20 */ public List<float> Positions;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 ScaleBoneName;
    }
}
