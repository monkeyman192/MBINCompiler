using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB9CE1CD5832C9B24, NameHash = 0x46C380A7C1CCD790)]
    public class TkBoundingBoxData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Min;
        /* 0x10 */ public Vector3f Max;
    }
}
