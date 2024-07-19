using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54ADFBFD56CC1690, NameHash = 0xE3D2D26E)]
    public class GcRewardMultiSpecificProducts : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A SetName;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSString0x10> ProductIds;
        [NMS(Index = 1)]
        /* 0x30 */ public bool UseListPopup;
    }
}
