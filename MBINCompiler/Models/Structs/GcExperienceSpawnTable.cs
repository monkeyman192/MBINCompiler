using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcExperienceSpawnTable : NMSTemplate
    {
        public List<GcAIShipSpawnData> FlybySpawns;
        public List<GcAIShipSpawnData> OutpostSpawns;
        public List<GcAIShipSpawnData> SpaceFlybySpawns;
        public List<GcAIShipSpawnData> PirateSpawns;
        public List<GcAIShipSpawnData> PirateBattleSpawns;
        public List<GcAIShipSpawnData> PirateBountySpawns;
        public List<GcAIShipSpawnData> PoliceSpawns;
        public List<GcAIShipSpawnData> TraderSpawns;
        public List<GcAIShipSpawnData> AmbientSpawns;
        public List<GcAIShipSpawnData> BattleSpawns;
        public List<GcAIShipSpawnData> BattleInitialStandardSpawns;
        public List<GcAIShipSpawnData> BattleInitialPirateSpawns;
        public List<GcAIShipSpawnData> BattleSecondaryPirateSpawns;
    }
}
