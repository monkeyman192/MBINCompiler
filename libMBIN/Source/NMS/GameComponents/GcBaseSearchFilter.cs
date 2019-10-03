using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0xD4D7EAB206D91BBA, NameHash = 0x53636362EAB448BF)]
    public class GcBaseSearchFilter : NMSTemplate
    {
        /* 0x00 */ public bool OnCurrentPlanet;
        /* 0x01 */ public bool InCurrentSystem;
        /* 0x02 */ public bool IsOverlapping;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x03 */ public byte[] Padding3;
        /* 0x08 */ public ulong OnSpecificPlanet;
        /* 0x10 */ public ulong InSpecificSystem;
        [NMS(Size = 0x20)]
        /* 0x18 */ public string OnSpecificPlanetScanEvent;
        /* 0x38 */ public List<GcPersistentBaseTypes> MatchingTypes;
        /* 0x48 */ public GcBasePartSearchFilter BasePartFilter;
        /* 0x88 */ public int ContainsMinParts;
        /* 0x8C */ public int ContainsMaxParts;
    }
}
