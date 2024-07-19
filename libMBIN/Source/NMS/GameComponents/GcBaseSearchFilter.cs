using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF26A3A3D1F016C0E, NameHash = 0x329F3467)]
    public class GcBaseSearchFilter : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public GcBasePartSearchFilter BasePartFilter;
        [NMS(Index = 6)]
        /* 0x48 */ public NMSString0x20A OnSpecificPlanetScanEvent;
        [NMS(Index = 7)]
        /* 0x68 */ public List<GcPersistentBaseTypes> MatchingTypes;
        [NMS(Index = 5)]
        /* 0x78 */ public ulong InSpecificSystem;
        [NMS(Index = 4)]
        /* 0x80 */ public ulong OnSpecificPlanet;
        [NMS(Index = 10)]
        /* 0x88 */ public int ContainsMaxParts;
        [NMS(Index = 9)]
        /* 0x8C */ public int ContainsMinParts;
        [NMS(Index = 1)]
        /* 0x90 */ public bool InCurrentSystem;
        [NMS(Index = 3)]
        /* 0x91 */ public bool IsBuildable;
        [NMS(Index = 2)]
        /* 0x92 */ public bool IsOverlapping;
        [NMS(Index = 0)]
        /* 0x93 */ public bool OnCurrentPlanet;
    }
}
