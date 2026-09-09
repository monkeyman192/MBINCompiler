using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD735E2EE51CA210, NameHash = 0x329F3467)]
    public class GcBaseSearchFilter : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public GcBasePartSearchFilter BasePartFilter;
        [NMS(Index = 12)]
        /* 0x60 */ public Vector3f ReferenceWorldPosition;
        [NMS(Index = 6)]
        /* 0x70 */ public NMSString0x20A OnSpecificPlanetScanEvent;
        [NMS(Index = 7)]
        /* 0x90 */ public List<GcPersistentBaseTypes> MatchingTypes;
        [NMS(Index = 5)]
        /* 0xA0 */ public ulong InSpecificSystem;
        [NMS(Index = 4)]
        /* 0xA8 */ public ulong OnSpecificPlanet;
        [NMS(Index = 10)]
        /* 0xB0 */ public int ContainsMaxParts;
        [NMS(Index = 9)]
        /* 0xB4 */ public int ContainsMinParts;
        [NMS(Index = 11)]
        /* 0xB8 */ public float MaxDistance;
        [NMS(Index = 1)]
        /* 0xBC */ public bool InCurrentSystem;
        [NMS(Index = 3)]
        /* 0xBD */ public bool IsBuildable;
        [NMS(Index = 2)]
        /* 0xBE */ public bool IsOverlapping;
        [NMS(Index = 0)]
        /* 0xBF */ public bool OnCurrentPlanet;
    }
}
