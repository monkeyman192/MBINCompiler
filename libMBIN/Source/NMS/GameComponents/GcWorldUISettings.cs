using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xE49D6EF39D256895, NameHash = 0x1805828080FC646E)]
    public class GcWorldUISettings : NMSTemplate
    {
        public float UIWorldQuadOffset;
        public float UIWorldQuadSideOffset;
        public float UIWorldQuadShipAddOffset;
        public float UIWorldQuadScale;
        public float UIWorldQuadShipScale;
        public float HUDWorldQuadOffset;
        public float HUDWorldQuadShipAddOffset;
        public float HUDWorldQuadScale;
        public float HUDWorldQuadShipScale;
        public float HUDInterpSpeed;
        public float HUDThresholdVert;
        public float HUDThresholdHorz;
    }
}
