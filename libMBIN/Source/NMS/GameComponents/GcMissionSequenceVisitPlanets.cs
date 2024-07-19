using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDEA50C1F433AF811, NameHash = 0xB7D5F052)]
    public class GcMissionSequenceVisitPlanets : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString MessageOnIncompletePlanet;
        [NMS(Index = 2)]
        /* 0x30 */ public List<GcBiomeType> PlanetTypesToWatch;
        [NMS(Index = 5)]
        /* 0x40 */ public int NumberOfEachToDiscover;
        [NMS(Index = 3)]
        /* 0x44 */ public bool MustAlsoDiscover;
        [NMS(Index = 4)]
        /* 0x45 */ public bool MustAlsoTakePhoto;
        [NMS(Index = 6)]
        /* 0x46 */ public bool TakeNumberFromSeasonalData;
    }
}
