namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22B4C5EFBC325DCC, NameHash = 0x881C97F393A2FB50)]
    public class GcMissionType : NMSTemplate
    {
        // size: 0x16
        public enum MissionTypeEnum : uint {
            SpaceCombat,
            GroundCombat,
            Research,
            MissingPerson,
            Repair,
            Cargo,
            Piracy,
            Photo,
            Feeding,
            Planting,
            Construction,
            LocalCorrupted,
            LocalCorruptedCombat,
            LocalSalvage,
            LocalBiomePlants,
            LocalExtreme,
            LocalBones,
            LocalInfested,
            LocalPlanetaryPirates,
            LocalPredators,
            LocalSentinels,
            BuildersLanguage,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionTypeEnum MissionType;
    }
}
