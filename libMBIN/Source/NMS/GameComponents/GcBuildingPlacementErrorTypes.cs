using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFFCE7B98413C80A7, NameHash = 0xC2EE53901B0156DE)]
    public class GcBuildingPlacementErrorTypes : NMSTemplate
    {
        // size: 0x16
        public enum InvalidPlacementReasonEnum { Offline, InvalidBiome, InvalidAboveWater, InvalidUnderwater, PlanetLimitReached,
            BaseLimitReached, RegionLimitReached, InvalidOverlappingAnyBase,
            InvalidOverlappingSettlement, InvalidOverlappingBase, OutOfBaseRange,
            OutOfConnectionRange, LinkGridMismatch, InsufficientResources, ComplexityLimitReached,
            SubstanceOnly, InvalidPosition, InvalidSnap, MustPlaceOnTerrain,
            Collision, ShipInside, PlayerInside
        }
        /* 0x0 */ public InvalidPlacementReasonEnum InvalidPlacementReason;
    }
}
