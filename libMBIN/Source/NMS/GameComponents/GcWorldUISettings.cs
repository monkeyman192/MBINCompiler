using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB4F9156DFE56219D, NameHash = 0x1805828080FC646E)]
    public class GcWorldUISettings : NMSTemplate
    {
        /* 0x00 */ public float UIWorldQuadOffset;
        /* 0x04 */ public float UIWorldQuadOffsetBuildMenu;
        /* 0x08 */ public float UIWorldQuadSideOffset;
        /* 0x0C */ public float UIWorldQuadShipAddOffset;
        /* 0x10 */ public float UIWorldQuadScale;
        /* 0x14 */ public float UIWorldQuadShipScale;
        /* 0x18 */ public float HUDWorldQuadOffset;
        /* 0x1C */ public float HUDWorldQuadShipAddOffset;
        /* 0x20 */ public float HUDWorldQuadScale;
        /* 0x24 */ public float HUDWorldQuadShipScale;
        /* 0x28 */ public float HUDInterpSpeed;
        /* 0x2C */ public float HUDThresholdVert;
        /* 0x30 */ public float HUDThresholdHorz;
    }
}
