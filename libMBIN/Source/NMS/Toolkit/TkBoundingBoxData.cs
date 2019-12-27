using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x20, GUID = 0xB9CE1CD5832C9B24, NameHash = 0x46C380A7C1CCD790)]
    public class TkBoundingBoxData : NMSTemplate
    {
        /* 0x000 */ public Vector3f Min;
        /* 0x010 */ public Vector3f Max;
    }
}
