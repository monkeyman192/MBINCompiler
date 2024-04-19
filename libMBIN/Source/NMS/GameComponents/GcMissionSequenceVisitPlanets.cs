using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1D6B88D4EAC0FE5, NameHash = 0xA6EC06362FCAD424)]
    public class GcMissionSequenceVisitPlanets : NMSTemplate
    {
        /* 0x000 */ public List<GcBiomeType> PlanetTypesToWatch;
        /* 0x010 */ public int NumberOfEachToDiscover;
        /* 0x014 */ public NMSString0x80 DebugText;
        /* 0x094 */ public NMSString0x80 Message;
        /* 0x114 */ public NMSString0x80 MessageOnIncompletePlanet;
        /* 0x194 */ public bool MustAlsoDiscover;
        /* 0x195 */ public bool MustAlsoTakePhoto;
        /* 0x196 */ public bool TakeNumberFromSeasonalData;
    }
}
