using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3DC3F536A016394, NameHash = 0x53636362EAB448BF)]
    public class GcBaseSearchFilter : NMSTemplate
    {
        /* 0x00 */ public GcBasePartSearchFilter BasePartFilter;
        /* 0x48 */ public NMSString0x20A OnSpecificPlanetScanEvent;
        /* 0x68 */ public List<GcPersistentBaseTypes> MatchingTypes;
        /* 0x78 */ public ulong InSpecificSystem;
        /* 0x80 */ public ulong OnSpecificPlanet;
        /* 0x88 */ public int ContainsMaxParts;
        /* 0x8C */ public int ContainsMinParts;
        /* 0x90 */ public bool InCurrentSystem;
        /* 0x91 */ public bool IsBuildable;
        /* 0x92 */ public bool IsOverlapping;
        /* 0x93 */ public bool OnCurrentPlanet;
    }
}
