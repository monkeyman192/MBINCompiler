using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37DF2E4A1163BE1B, NameHash = 0xA6EC06362FCAD424)]
    public class GcMissionSequenceVisitPlanets : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public List<GcBiomeType> PlanetTypesToWatch;
        [NMS(Index = 5)]
        /* 0x010 */ public int NumberOfEachToDiscover;
        [NMS(Index = 7)]
        /* 0x014 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x094 */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x114 */ public NMSString0x80 MessageOnIncompletePlanet;
        [NMS(Index = 3)]
        /* 0x194 */ public bool MustAlsoDiscover;
        [NMS(Index = 4)]
        /* 0x195 */ public bool MustAlsoTakePhoto;
        [NMS(Index = 6)]
        /* 0x196 */ public bool TakeNumberFromSeasonalData;
    }
}
