using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x16EE631D7C688C2C, NameHash = 0xC2EE53901B0156DE)]
    public class GcBuildingPlacementErrorTypes : NMSTemplate
    {
        // 0x11 entries
        public enum InvalidPlacementReasonEnum { Offline, InvalidBiome, InvalidAboveWater, InvalidUnderwater, OutOfBaseRange, LimitReached, LinkGridMismatch,
            InsufficientResources, ComplexityLimitReached, SubstanceOnly, RoomLimitReached, InvalidPosition, InvalidSnap, MustPlaceOnTerrain, Collision, ShipInside, PlayerInside }
        public InvalidPlacementReasonEnum InvalidPlacementReason;
    }
}
