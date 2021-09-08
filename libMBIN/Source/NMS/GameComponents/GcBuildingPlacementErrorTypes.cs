using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x35880E7683FB5A46, NameHash = 0xC2EE53901B0156DE)]
    public class GcBuildingPlacementErrorTypes : NMSTemplate
    {
        // size: 0x15
        public enum InvalidPlacementReasonEnum { Offline, InvalidBiome, InvalidAboveWater, InvalidUnderwater, PlanetLimitReached,
            BaseLimitReached, RegionLimitReached, InvalidOverlappingSettlement,
            InvalidOverlappingBase, OutOfBaseRange, OutOfConnectionRange, LinkGridMismatch,
            InsufficientResources, ComplexityLimitReached, SubstanceOnly,
            InvalidPosition, InvalidSnap, MustPlaceOnTerrain, Collision, ShipInside,
            PlayerInside
        }
        /* 0x0 */ public InvalidPlacementReasonEnum InvalidPlacementReason;
    }
}
